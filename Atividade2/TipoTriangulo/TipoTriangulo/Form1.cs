using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoTriangulo
{
    public partial class Form1 : Form
    {

        string A, B, C;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            
                A = textBox1.Text;
                B = textBox2.Text;
                C = textBox3.Text;

                if (A == B || C == B || A == C)
                {
                    textBox4.Text = "Triangulo Isóceles";
                }

                if (A == B && C == B && A == C)
                {
                    textBox4.Text = "Triangulo Equilatero";
                }


                if (A != B && C != B && A != C)
                {
                    textBox4.Text = "Triangulo Escaleno";
                }
            
        }
    }
}
