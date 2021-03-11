using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPesoIdeal
{
    
    public partial class Form1 : Form
    {
        double Altura, Peso, Resultado, PesoAtual;
        //double PesoIdeal;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Peso.ToString();
            textBox4.Text = Peso.ToString()+" kg";
            textBox3.Text = Resultado.ToString();

            if (radioButton1.Checked)
            {
                radioButton1.PerformClick();

                Resultado = (72.7 * Altura - 58);
                Console.WriteLine();
                Resultado = Math.Round(Resultado);
                textBox3.Text = Resultado.ToString() + " Kg";

            }

            if (radioButton2.Checked)
            {
                radioButton2.PerformClick();

                Resultado = (62.1 * Altura - 44.7);
                Resultado = Math.Round(Resultado);
                textBox3.Text = Resultado.ToString() + " Kg";

            }


            if (PesoAtual >= Resultado)
            {
                MessageBox.Show("Regime Obrigatório Já!!!");
            }
            else if(PesoAtual < Resultado)
            {
                MessageBox.Show("Você está com o Peso Ideal!!!");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out Altura);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out Peso);
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = String.Empty;
            textBox4.Clear();

            
        }

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
