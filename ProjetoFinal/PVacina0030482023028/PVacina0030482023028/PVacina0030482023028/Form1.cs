using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482023028
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depender da sua máquina da escola ou particular
                conexao = new SqlConnection("Data Source=DESKTOP-0TUCTS4;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroDeVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacina objVacina = new frmVacina();
            objVacina.MdiParent = this;
            objVacina.WindowState = FormWindowState.Maximized;
            objVacina.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 objAbout = new AboutBox1();
            objAbout.WindowState = FormWindowState.Normal;
            objAbout.Show();
        }
    }
}

