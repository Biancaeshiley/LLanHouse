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
using Microsoft.Office.Interop.Word;

namespace LanHouseCodigo.Telas
{
    public partial class Computadores : Form
    {
        public List<int> pcOcupadas = new List<int>();
        public Computadores()
        {
            InitializeComponent();
        }

        private void Computadores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroComputador = Convert.ToInt32(tx_numPC.Text);
                string horasUso = combo_horasUso.Text;
                DateTime dataHoraAtual = DateTime.Now;


                if (tx_numPC.Text == null)
                {
                    MessageBox.Show("Por favor, insira um número do PC que deseja.");
                }

                if (pcOcupadas.Contains(numeroComputador))//ESTE COMPUTADOR ESTA JA OCUPADO
                {
                    MessageBox.Show("Este pc ja esta ocupado!");
                }
                else if (numeroComputador > 15)
                {
                    MessageBox.Show("Numero de pc invalido!");
                }
                else
                {
                    pcOcupadas.Add(numeroComputador);
                    MessageBox.Show("PC NUMERO" + numeroComputador + " RESERVADO COM SUCESSO!");

                    if (horasUso == "Menos de 1 hora")
                    {
                        lbl_valor.Text = 5.ToString("C2");
                    }
                    else if (horasUso == "1 hora de uso")
                    {
                        lbl_valor.Text = 10.ToString("C2");
                    }
                    else if (horasUso == "Mais de 2 horas")
                    {
                        lbl_valor.Text = 15.ToString("C2");
                    }

                    var file = File.AppendText("AgendamentoComputadores.docx");
                    file.WriteLine(numeroComputador + "|" + horasUso + "|" + dataHoraAtual + "|");
                    file.Close();
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("ERROR: " + error.Message);
            }      
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
