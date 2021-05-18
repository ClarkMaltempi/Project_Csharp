using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace PAtividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 objFrm1 = new frmExercicio1();
            objFrm1.MdiParent = this; //
            objFrm1.WindowState = FormWindowState.Maximized; //
            objFrm1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
            "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show("A resposta do Exercício 4:    "+ Total);
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList(); // tipo string
            lista.Add("Ana");
            lista.Add("André");
            lista.Add("Débora");
            lista.Add("Fátima");
            lista.Add("João");
            lista.Add("Janete");
            lista.Add("Otávio");
            lista.Add("Marcelo");
            lista.Add("Pedro");
            lista.Add("Taís");

            lista.Remove("Otávio");

            foreach (string item in lista)
            {
                MessageBox.Show(item);
            }

        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmExercicio6 objFrm6 = new frmExercicio6();
            objFrm6.MdiParent = this;
            objFrm6.WindowState = FormWindowState.Maximized;
            objFrm6.Show();
            


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio7 objFrm7 = new frmExercicio7();
            objFrm7.MdiParent = this;
            objFrm7.WindowState = FormWindowState.Maximized;
            objFrm7.Show();
        }
    }
}
