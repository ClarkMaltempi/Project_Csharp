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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculaSalario_Click(object sender, EventArgs e)
        {
            double salarioBruto, A;
            double salario = Convert.ToDouble(masktxtSalario.Text);
            double gratificacao = Convert.ToDouble(masktxtGratificacao.Text);
            int producao = Convert.ToInt32(masktxtProducao.Text);
            string numInscricao = masktxtInscricao.Text;
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            int B, C, D;

            A = salario;

            if (producao >= 100)
            {
                B = 1;
            }
            else
            {
                B = 0;
            }
            if (producao >= 120)
            {
                C = 1;
            }
            else
            {
                C = 0;
            }
            if (producao >= 150)
            {
                D = 1;
            }
            else
            {
                D = 0;
            }

            salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            if (salarioBruto > 7000)
            {
                if (producao >= 150 && gratificacao > 0)
                {
                    salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;
                }
                else
                {
                    salarioBruto = 7000;
                }
            }
            MessageBox.Show("\n Nome: " + nome + "\n Cargo: " + cargo + "\n Número de Inscrição: " + numInscricao + "\n Produção: " + producao + "\n Salário: " + salario +
                " \n Gratificação: " + gratificacao + "\n Salário Bruto: " + salarioBruto);

        }
    }
}
