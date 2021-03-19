using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double descontoINSS = 0;
            double descontoIR = 0;
            double salarioFamilia = 0;
            double salarioLiquido = 0;
            double salarioBruto = 0;

            if ((txtBoxNomeFunc.Text == "") || (txtBoxNomeFunc.Text.Length < 10))
                MessageBox.Show("Nome inválido");
            else if (double.TryParse(mskSalarioBruto.Text, out salarioBruto))
            {

                //      calculo INSS
                if (salarioBruto <= 800.47)
                {
                    txtBoxINSS.Text = "7.65%";
                    descontoINSS = 0.0765 * salarioBruto;
                    txtDescontoINSS.Text = descontoINSS.ToString();
                }
                else if (salarioBruto <= 1050)
                {
                    txtBoxINSS.Text = "8.65%";
                    descontoINSS = 0.0865 * salarioBruto;
                    txtDescontoINSS.Text = descontoINSS.ToString();
                }
                else if (salarioBruto <= 1400.77)
                {
                    txtBoxINSS.Text = "9%";
                    descontoINSS = 0.09 * salarioBruto;
                    txtDescontoINSS.Text = descontoINSS.ToString();
                }

                // ATENCAO AQUI FALTARAM AS OUTRAS FAIXAS DO INSS


                //    calculo da IR

                if (salarioBruto <= 1257.12)
                {
                    txtBoxIR.Text = "isento";
                }

                else if (salarioBruto >= 1257.12 && salarioBruto<=2512.08)
                {
                    txtBoxIR.Text = "15%";
                    descontoIR = 0.15 * salarioBruto;
                    //double.TryParse(txtIR.Text, out descontoIR);
                    txtIR.Text = descontoIR.ToString();
                }
                
                if (salarioBruto >2512.08)
                {
                    txtBoxIR.Text = "27.5%";
                    descontoIR = 0.15 * salarioBruto;
                    txtIR.Text = descontoIR.ToString();
                    
                }

                // USAR SEMPRE ELSE IF --> AO INVES DE VARIOS IFS
                if (salarioBruto <= 1257.12)
                {
                    txtBoxINSS.Text = "isento";
                }

                else if ((salarioBruto >= 1257.13) && (salarioBruto <= 2512.08))
                {
                    txtBoxINSS.Text = "15%";
                    descontoINSS = 0.15 * salarioBruto;
                    txtDescontoINSS.Text = descontoINSS.ToString();
                }

                if (salarioBruto >= 2512.08)
                {
                    txtBoxINSS.Text = "27.5%";
                    descontoINSS = 0.275 * salarioBruto;
                    txtDescontoINSS.Text = descontoINSS.ToString();
                }

                //   calculo do Salario familia


                
                if (salarioBruto <= 435.52)
                {
                    
                    double.TryParse(comboBoxFilhos.Text, out salarioFamilia);
                    salarioFamilia = salarioFamilia * 22.33 + salarioBruto;
                    txtBoxSalFamilia.Text = salarioFamilia.ToString();

                }
                else if (salarioBruto >= 435.53)
                {

                    double.TryParse(comboBoxFilhos.Text, out salarioFamilia);
                    salarioFamilia = salarioFamilia * 15.74 + salarioBruto;
                    txtBoxSalFamilia.Text = salarioFamilia.ToString();

                }
                if (salarioBruto > 654.61)
                {

                    double.TryParse(comboBoxFilhos.Text, out salarioFamilia);
                    salarioFamilia = 0;
                    txtBoxSalFamilia.Text = salarioFamilia.ToString();
                }

                //     Salario Líquido

                double.TryParse(txtSalLiquido.Text, out salarioLiquido);
                salarioLiquido = salarioBruto - descontoINSS - descontoIR + salarioFamilia;
                txtSalLiquido.Text = salarioLiquido.ToString();


                //     Monta Mensagem

                lblMensagem.Text = " Os descontos do salario ";

                if (ckBoxFem.Checked)
                {
                    lblMensagem.Text = lblMensagem.Text + " da Sra. " + txtBoxNomeFunc.Text;
                }
                else
                {
                    lblMensagem.Text = lblMensagem.Text + " do Sr. " + txtBoxNomeFunc.Text;
                    lblMensagem.Text = lblMensagem.Text + " que é ";
                }
                if (ckCasado.Checked == true && ckBoxMasc.Checked== true)
                {
                    lblMensagem.Text = lblMensagem.Text + " casado: ";
                }
                else if (ckCasado.Checked == true && ckBoxFem.Checked == true)
                {
                    lblMensagem.Text = lblMensagem.Text + " casada: ";
                }

            }
        }

        private void ckBoxMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxMasc.Checked==true)
            {
                ckBoxFem.Enabled = false;
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ckBoxFem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxFem.Checked == true)
            {
                ckBoxMasc.Enabled = false;
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void ckCasado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCasado.Checked == true)
            {
                ckSolteiro.Enabled = false;
            }
        }

        private void ckSolteiro_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSolteiro.Checked == true)
            {
                ckCasado.Enabled = false;
            }
        }

        
    }
}
