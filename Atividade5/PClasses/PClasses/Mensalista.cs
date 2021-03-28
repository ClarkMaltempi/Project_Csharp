using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado
    {

        public double SalarioMensal { get; set; }


        public Mensalista()
        {
           
        }

        //sobrecarga - uma nova vesão

        public Mensalista(int matx,string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }

        //sobreescrevendo o método
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

    }
}
