using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            //Empregado objEmpregado = new Empregado ();
            // não pode instanciar objeto de classe abstrata

            //criando o objeto, instanciando o objeto
            Horista objHorista = new Horista();

            //set
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);

            //get
            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                "\n" + "Matrícula:" + objHorista.Matricula +"\n"+
                "Tempo Trabalho:"+ objHorista.TempoTrabalho().ToString()
                +"\n"+"Salario:" + objHorista.SalarioBruto().ToString("N2"));

        }
    }
}
