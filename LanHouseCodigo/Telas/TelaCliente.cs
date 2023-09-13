using LanHouseCodigo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LanHouseCodigo.Telas
{
    public partial class TelaCliente : Form
    {
        List<CadastroCliente> cliente = new List<CadastroCliente>(); 
        public TelaCliente()
        {
            InitializeComponent();
            CarregarArquivosCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroCliente cd = new CadastroCliente();
                cd.nomeC = tx_nomeC.Text;
                cd.emailC = tx_emailC.Text;
                cd.datNasC = Convert.ToDateTime(tx_dtNasC.Text);
                cd.teleC = tx_teleC.Text;

                cliente.Add(cd);

                DgvC.Rows.Add(cd.nomeC, cd.emailC, cd.teleC, cd.datNasC);

                var file = File.AppendText("CadastroClienteLanHouse.docx");
                file.WriteLine(tx_nomeC.Text + "|" + tx_emailC + "|" + tx_dtNasC.Text + "|" + tx_teleC.Text);
                file.Close();

                MessageBox.Show("Cadastro feito com sucesso!!");
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CarregarArquivosCliente()
        {
            // Certifique-se de que o arquivo existe
            if (File.Exists("CadastroFuncionarioLanHouse.docx"))
            {
                // Limpa o DataGridView
                DgvC.Rows.Clear();

                // Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines("CadastroFuncionarioLanHouse.docx");

                foreach (string linha in linhas)
                {
                    // Divide a linha em partes usando o caractere '|'
                    string[] partes = linha.Split('|');

                    // Verifique se há dados suficientes
                    if (partes.Length == 7)
                    {
                        // Adicione os dados ao DataGridView
                        DgvC.Rows.Add(partes[0], partes[3], partes[2], partes[5], partes[4], partes[6], partes[1]);
                    }
                }
            }
            else
            {
                // Lida com o caso em que o arquivo não existe (opcional)
                MessageBox.Show("O arquivo CadastroFuncionarioLanHouse.docx não foi encontrado.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nomeC.Clear();
            tx_dtNasC.Clear();
            tx_emailC.Clear();
            tx_teleC.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DgvC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
