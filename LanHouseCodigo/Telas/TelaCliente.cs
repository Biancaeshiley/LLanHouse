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

                DgvC.DataSource = null;
                DgvC.Refresh();
                DgvC.DataSource = cliente;

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
    }
}
