using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcAtividade1
{
    public partial class Form1 : Form
    {
        double Num1, Num2, Resultado;

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out Num1) && double.TryParse(textBox2.Text, out Num2))
            {
                Resultado = Num1 - Num2;
                textBox3.Text = Resultado.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out Num1) && double.TryParse(textBox2.Text, out Num2))
            {
                Resultado = Num1 * Num2;
                textBox3.Text = Resultado.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out Num1) && double.TryParse(textBox2.Text, out Num2))
            {
                if (Num2 == 0)
                {
                    MessageBox.Show("Não se pode dividir por 0! ");
                }
                else
                {
                    Resultado = Num1 / Num2;
                    textBox3.Text = Resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Números Inválidos! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out Num1) && double.TryParse(textBox2.Text, out Num2))
            {
                Resultado = Num1 + Num2;
                textBox3.Text = Resultado.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
