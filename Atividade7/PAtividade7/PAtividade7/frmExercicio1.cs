using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade7
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspaçoBranco_Click(object sender, EventArgs e)
        {
            int qtdeCaracterBranco = 0, cont = 0;
            string Texto = richTxtTexto.Text;


            while (cont < richTxtTexto.Text.Length)
            {
                var x = Texto[cont];
                if (char.IsWhiteSpace(x))
                {
                    qtdeCaracterBranco++;
                }
                cont++;
            }
            MessageBox.Show("Quatidade de caracteres em branco é: " + qtdeCaracterBranco);
        }

        private void btnAparecerR_Click(object sender, EventArgs e)
        {
            int qtdeCaracterR = 0;
            int cont;
            char letra = 'r';
            char letraMaiuscula = 'R';
            string Texto = richTxtTexto.Text;

            for (cont = 0; cont < richTxtTexto.Text.Length; cont++)
            {
                if (Texto[cont] == letra || (Texto[cont] == letraMaiuscula))
                {
                    qtdeCaracterR++;
                }
            }
            MessageBox.Show("Quantidade de letra R é: " + qtdeCaracterR);
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int qtdeCaracterDuplo = 0;
            int cont;
            char letra = ' ';
            string Texto = richTxtTexto.Text;

            for (cont = 0; cont < richTxtTexto.Text.Length; cont++)
            {
                if (letra == Texto[cont])
                {
                    qtdeCaracterDuplo++;
                }
                letra = Texto[cont];
            }
            MessageBox.Show("Quantidade de Caracter Duplo é: " + qtdeCaracterDuplo);
        }
    }
}
