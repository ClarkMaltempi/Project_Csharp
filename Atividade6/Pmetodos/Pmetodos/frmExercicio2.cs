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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnVerificaIguais_Click(object sender, EventArgs e)
        {
            
            //bola e bola -> 0
            //bola e casa -> -1
            //casa e bola -> 1
            
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
            {
                MessageBox.Show("São Iguais");
            }
            else
            {
                MessageBox.Show("São Diferentes");
            }
        }

        private void btnInsere1_Click(object sender, EventArgs e)
        {
            //a             a
            //casa          fatec
            //caasa         faatec

            int metade = txtPalavra2.Text.Length / 2; //length pega o tamanho
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, metade) + //Substring pega uma parte
                txtPalavra1.Text + txtPalavra2.Text.Substring(metade,
                txtPalavra2.Text.Length-metade);

           // txtPalavra2.Text = txtPalavra2.Text.Insert(metade,txtPalavra1.Text); Insira o conteudo da Palavra 1 na Palavra 2
                


        }

        private void btnInsere2_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(metade, "**");
        }
    }
}
