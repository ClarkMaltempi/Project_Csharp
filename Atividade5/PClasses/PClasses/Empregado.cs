using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula;//atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }


        public string NomeEmpregado //propriedade
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa //propriedade
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        //método são ações/comportamentos
        //virtual --> poder ser sobreescrito

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        //deve ser implementado
        // Derived classes must implement this

        public abstract double SalarioBruto();



    }
}
