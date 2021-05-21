using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double[,] Vendas = new double[9, 4];
            double[] Meses = new double[9];
            string preco;
            double totalMeses = 0;
            int cont = 0;
            int i = 0;

            for (cont = 0; cont < 9; cont++)
            {   
                //Verifica entrada de dados
                for (i = 0; i < 4; i++)
                {
                    preco = Interaction.InputBox("Digite as Vendas da semana " + (i + 1) + " Do Mês: " + (cont + 1), "Entrada de dados");
                    if (preco == "")
                    {
                        MessageBox.Show("Campo vazio");
                        i--;
                    } //verifica entrada de dados do tipo "double"
                    else if (double.TryParse(preco, out Vendas[cont, i]))
                    {
                        double.TryParse(preco, out Vendas[cont, i]);
                    }
                    else
                    {
                        MessageBox.Show("Digite apenas números!");
                        i--;
                    }
                }
            }

            //Faz o faturamento
            for (cont = 0; cont < 9; cont++)
            {
                for (i = 0; i < 4; i++)
                {
                    Meses[cont] = Meses[cont] + Vendas[cont, i];
                }
                totalMeses = totalMeses + Meses[cont];
            }

            //Visualização 
            for (cont = 0; cont < 9; cont++)
            {
                for (i = 0; i < 4; i++)
                {
                  ListaBox.Items.Add("Total do Mês: " + (cont + 1) + " Semana: " + (i + 1) + ": R$" + Vendas[cont, i].ToString("N2"));
                }
                ListaBox.Items.Add("*Total Mês: R$" + Meses[cont].ToString("N2"));
                ListaBox.Items.Add("         ");
            }
                ListaBox.Items.Add("*Total Geral: R$" + totalMeses.ToString("N2"));


        }
    }

}


