using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btVarrerNum_Click(object sender, EventArgs e)
        {
            int TextoTotal = rchTextBox.Text.Length;
            int cont, QtdCaracter = 0;
            string Texto = rchTextBox.Text;


            for (cont = 0; cont < TextoTotal; cont++)
            {
                var c = Texto[cont];
                if (Char.IsNumber(c))
                {
                    QtdCaracter++;
                }

            }
            MessageBox.Show("A quantidade de caracteres numéricos no texto são: " + QtdCaracter);



        }

        private void btLocalizaEspaco_Click(object sender, EventArgs e)
        {
            int posCaracter = 1, cont = 0;
            string Texto = rchTextBox.Text;


            while (cont <= rchTextBox.Text.Length)
            {
                var x = Texto[cont];
                if (char.IsWhiteSpace(x))
                {
                    break;
                }
                else
                {
                    posCaracter++;
                }
                cont++;
            }
            MessageBox.Show("Posição do 1º caracter em branco: " + posCaracter);
        }

        private void btContaCaracter_Click(object sender, EventArgs e)
        {
            int caracterTotal = rchTextBox.Text.Length;
            int QtdCaracter = 0;
            string Texto = rchTextBox.Text;


            foreach (Char c in Texto)
            {
                if (Char.IsLetter(c))
                {
                    QtdCaracter++;
                }

            }
            MessageBox.Show("A quantidade de caracteres alfabéticos no texto são: " + QtdCaracter);
        }
    }
}
