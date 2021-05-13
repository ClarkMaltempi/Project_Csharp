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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnTestarPalindromo_Click(object sender, EventArgs e)
        {
            string texto = txtMensagem.Text;
            string textoInv = "";
            char[] textoArr = texto.ToCharArray();
            Array.Reverse(textoArr);

            foreach (char c in textoArr)
            {
                textoInv = textoInv + c.ToString();
            }
                texto = texto.ToUpper().Trim().Replace(" ", "");
                textoInv = textoInv.ToUpper().Trim().Replace(" ", "");

            if (string.Equals(texto, textoInv))
            {
                MessageBox.Show("Palavra: " + texto + "\n Esta palavra é um palíndromo");
            }
            else
            {
                MessageBox.Show("Palavra: " + texto + "\n Esta palavra não é um palíndromo");
            }
        }
    }
}
