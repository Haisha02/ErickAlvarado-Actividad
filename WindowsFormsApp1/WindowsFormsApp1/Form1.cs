using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
        }
    }
}
