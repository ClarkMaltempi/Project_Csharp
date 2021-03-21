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

        //sobreescrevendo o método
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

    }
}
