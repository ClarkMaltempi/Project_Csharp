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

namespace PAtividade8
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            int[,] lista = new int[20, 3];
            string [] MediaAlunos = new string[20];

            ArrayList Alunos = new ArrayList(); // tipo string
            Alunos.Add("Ana");
            Alunos.Add("André");
            Alunos.Add("Débora");
            Alunos.Add("Fátima");
            Alunos.Add("João");
            Alunos.Add("Janete");
            Alunos.Add("Otávio");
            Alunos.Add("Marcelo");
            Alunos.Add("Pedro");
            Alunos.Add("Taís");

            Alunos.Add("Ted");
            Alunos.Add("Caio");
            Alunos.Add("Will");
            Alunos.Add("Vandão");
            Alunos.Add("Carlão");
            Alunos.Add("Wesley");
            Alunos.Add("Vinicius");
            Alunos.Add("Val");
            Alunos.Add("Veron");
            Alunos.Add("Rafa");
           
            string auxiliar = "";
            int Num = 0;
            int cont = 0;
            int contador = 0;
            double media;
            string MediaFinal = "";
            string NotaFinal = "";

            
            for (cont = 0; cont <= 29; cont++)
            {

                //Armazena as notas dos Alunos

                auxiliar = Interaction.InputBox("Digite a primeira Nota:: Posição  " + contador,"_"+ Alunos[cont] );
                Num = Convert.ToInt32(auxiliar);//convertendo em inteiro
                lista[cont, 0] = Num;

                auxiliar = Interaction.InputBox("Digite a segunda Nota:: Posição  " + contador, "_" + Alunos[cont]);
                Num = Convert.ToInt32(auxiliar);//convertendo em inteiro
                lista[cont, 1] = Num;

                auxiliar = Interaction.InputBox("Digite a terceira Nota:: Posição " + contador, "_" + Alunos[cont] );
                Num = Convert.ToInt32(auxiliar);//convertendo em inteiro
                lista[cont, 2] = Num;

                contador++;

                if (contador == 20)
                {
                    break;
                }

            }

            for (cont = 0; cont <= 19; cont++)
            {
                media = (lista[cont, 0] + lista[cont, 1] + lista[cont, 2]) / 3;
                MediaAlunos[cont] = media.ToString();

            }

            foreach (string c in MediaAlunos)
            {
                NotaFinal = NotaFinal + " \n " + c;
                lblNotas.Text = NotaFinal;

            }
            
            
            foreach (string elemento in Alunos)
            {
                MediaFinal = MediaFinal + " \n " + elemento.ToString();
                lblMediaAlunos.Text = MediaFinal;

            }
            


        }
    }
}
