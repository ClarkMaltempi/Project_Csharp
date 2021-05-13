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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerarNum_Click(object sender, EventArgs e)
        {
            double numH = 0, numT = 0;
            double i;
            if (Convert.ToDouble(txtNumeroN.Text) > 0)
            {
                for (i = 1; i <= Convert.ToDouble(txtNumeroN.Text); i++)
                {
                    numT = 1 / i;
                    numH = numH + numT;
                }
            }
            MessageBox.Show("O número H gerado é: " + numH);
        }
    }
}
