using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AcercaDe = new Form2();
            AcercaDe.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFilePro.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


            }
        }
    }
}
