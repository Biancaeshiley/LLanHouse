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
    public partial class TelaFuncionario : Form
    {
        List<CadastroFuncionario> funcionario = new List<CadastroFuncionario>(); 

        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroFuncionario CF = new CadastroFuncionario();
                CF.nomeF = tx_nomeF.Text;
                CF.numBF = tx_NumBF.Text;
                CF.endF = tx_endF.Text;
                CF.emalF = tx_emailF.Text;
                CF.CpfF = tx_cpfF.Text;
                CF.teleF = tx_teleF.Text;
                CF.dtNasF = Convert.ToDateTime(tx_dtNasF.Text);

                funcionario.Add(CF);

                DgvF.Rows.Add(CF.nomeF, CF.emalF, CF.endF, CF.teleF, CF.CpfF, CF.dtNasF, CF.numBF);

                MessageBox.Show("Cadastro feito com sucesso!!!");

                ValidacaoCPF.ValidaCPF(CF.CpfF);
                MessageBox.Show(ValidacaoCPF.ValidaCPF(CF.CpfF).ToString());

                if(ValidacaoCPF.ValidaCPF(CF.CpfF) == true)
                {
                    MessageBox.Show("CPf válido");
                }

               

                var file = File.AppendText("CadastroFuncionarioLanHouse.docx");
                file.WriteLine(tx_nomeF.Text + "|" + tx_NumBF.Text + "|" + tx_endF.Text + "|" + tx_emailF.Text +
                               "|" + tx_cpfF.Text + "|" + tx_teleF.Text + "|" + tx_dtNasF.Text);
                file.Close();

               
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tx_NumBF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tx_nomeF.Clear();
            tx_emailF.Clear();
            tx_endF.Clear();
            tx_teleF.Clear();
            tx_cpfF.Clear();
            tx_dtNasF.Clear();
            tx_NumBF.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {
          
        }

        private void DgvF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void tx_cpfF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
