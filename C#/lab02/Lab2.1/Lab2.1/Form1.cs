using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2._1
{
    public partial class Form1 : Form
    {
        int i = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean ok = true;
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            label2.Hide();
            label3.Hide();
            CPF cpf = new CPF();
            ok = cpf.validarCPF(textBox1.Text);

            if (ok)
            {
                panel1.BackColor = Color.Gray;
                panel2.BackColor = Color.Green;
                label2.Hide();
                label3.Show();
            }
            else
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Gray;
                label2.Show();
                label3.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            label2.Hide();
            label3.Hide();
        }
    }
}
