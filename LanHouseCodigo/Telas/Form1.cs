using LanHouseCodigo.Classes;
using LanHouseCodigo.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanHouseCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCliente TC = new TelaCliente();
            TC.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           TelaFuncionario TF = new TelaFuncionario();
            TF.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Computadores c = new Computadores();
            c.ShowDialog(); 

        }
    }
}
