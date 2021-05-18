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
    public partial class frmExercicio1 : Form
    {
        int[] lista = new int[20];
        

        public frmExercicio1()
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


            //foreach (int elemento in lista)
            //{
             //MessageBox.Show("Dig:" + elemento.ToString());
                
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Fazer manualmente posção por posição
             *
             *
             *string Pos0, Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9, Pos10,
            Pos11, Pos12, Pos13, Pos14, Pos15, Pos16, Pos17, Pos18, Pos19;

            label1.Text = " , ";

            Pos0 = lista[19].ToString();
            Pos1 = lista[18].ToString();
            Pos2 = lista[17].ToString();
            Pos3 = lista[16].ToString();
            Pos4 = lista[15].ToString();
            Pos5 = lista[14].ToString();
            Pos6 = lista[13].ToString();
            Pos7 = lista[12].ToString();
            Pos8 = lista[11].ToString();
            Pos9 = lista[10].ToString();
            Pos10 = lista[9].ToString();
            Pos11 = lista[8].ToString();
            Pos12 = lista[7].ToString();
            Pos13 = lista[6].ToString();
            Pos14 = lista[5].ToString();
            Pos15 = lista[4].ToString();
            Pos16 = lista[3].ToString();
            Pos17 = lista[2].ToString();
            Pos18 = lista[1].ToString();
            Pos19 = lista[0].ToString();


            label1.Text = label1.Text + Pos0 + label1.Text + Pos1 + label1.Text + Pos2 +
                label1.Text + Pos3 + label1.Text + Pos4 + label1.Text + Pos5 +
                label1.Text + Pos6 + label1.Text + Pos7 + label1.Text + Pos8 +
                label1.Text + Pos9 + label1.Text + Pos10 +"\n" + label1.Text + Pos11 +
                label1.Text + Pos12 + label1.Text + Pos13 + label1.Text + Pos14 +
                label1.Text + Pos15 + label1.Text + Pos16 + "\n" + label1.Text + Pos17 +
                label1.Text + Pos18 + label1.Text + Pos19;
            */
            string[] NumConvertidos = new string[20];
            string[] NumUsers = new string[20];
            int cont = 0;
            


            // Converte os numeros em formato String
            for (cont = 0; cont <= 19; cont++)
            {
                NumConvertidos[cont] = lista[cont].ToString();
            }

           // Percorre Array ao contrário e exibe valor em uma Label
            for (cont = 19; cont >= 0; cont--)
            {

                NumUsers[cont] = NumConvertidos[cont];
                label1.Text = label1.Text + " , " + NumUsers[cont];

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
