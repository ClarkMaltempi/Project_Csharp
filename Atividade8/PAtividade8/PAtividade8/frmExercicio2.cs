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

namespace PAtividade8
{
    public partial class frmExercicio2 : Form
    {
        int[] lista = new int[20];
        
        public frmExercicio2()
        {
            InitializeComponent();

            string auxiliar = "";
            int Num = 0;
            int cont = 0;
            int contador = 0;

            for (cont = 0; cont <= 19; cont++)
            {
                auxiliar = Interaction.InputBox("Digite Mais Um Numero :: Posição: " + contador, "Entre com 20 Numeros");
                Num = Convert.ToInt32(auxiliar);//convertendo em inteiro
                lista[cont] = Num;

                contador++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NumChar;
            int cont = 0;
            string[] NumConvertidos = new string[20];
            

            // Converte os numeros em formato String
            for (cont = 0; cont <= 19; cont++)
            {
                NumConvertidos [cont] = lista[cont].ToString();
            }

            //método para inverter um array
            Array.Reverse(NumConvertidos);

            NumChar = " ";
           
            //percorre Array e armazena em uma variável
            foreach (string elemento in NumConvertidos)
            {
                NumChar = NumChar + " , " + elemento.ToString();
                label1.Text = NumChar;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
