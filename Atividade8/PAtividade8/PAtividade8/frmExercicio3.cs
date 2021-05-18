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
    public partial class frmExercicio3 : Form
    {

        public frmExercicio3()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] lista = new int[11];
            int[] QtdProduto = new int[11];
            string preco = "";
            int cont = 0;
            double FaturaMensal = 0;


            for (cont = 1; cont <= 10; cont++)
            {
                preco = Interaction.InputBox("Digite o Preço ::", "Cadastro Preço: " + cont);



                if (!int.TryParse(preco, out lista[cont]))
                {
                    



                    MessageBox.Show("Erro no preco");
                    cont--;
                }
                else
                {
                    while (!(QtdProduto[cont] > 0))
                    {
                        preco = Interaction.InputBox("Digite a Quantidade ::", "Cadastro da Quantidade:  " + cont);
                        
                        if (!int.TryParse(preco, out QtdProduto[cont]))
                            MessageBox.Show("Erro na quantidade");
                    }
                }
                
            }




            for (cont = 1; cont <= 10; cont++)
            {

                FaturaMensal = FaturaMensal + lista[cont] * QtdProduto[cont];

            }


            listBoxProd.Items.Add(FaturaMensal);


        }
    }

}
