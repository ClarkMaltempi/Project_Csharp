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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string Nome = "";
            string QtdCaracter = "";
            string auxiliar = "";
            int cont = 0;
            int contador = 0;

            //ra 30482023029


            ArrayList ArmazenaNome = new ArrayList(); // tipo string


            for(cont=0;cont<=9;cont++)
            {
                
                auxiliar = Interaction.InputBox("Insira Nomes  ", "Digite um Nome: " + contador);

               
                   
                    ArmazenaNome.Add(auxiliar);
                    contador++;
               
            }

            foreach (string elemento in ArmazenaNome)
            {

                    Nome = elemento.ToString();
                    //QtdCaracter = Nome.Length.ToString();
                    QtdCaracter = Nome.Replace(" ", "").Length.ToString();

                Nome = Nome + " tem " + QtdCaracter + " Caracteres ";
                    ListaNomes.Items.Add(Nome);//listBox1.Items.Clear();
                    
            }
        }
            
  

        
    }
}
