using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace PVacina0030482023028
{
    class Cidade
    {
        // atributos
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;

        //properties
        public int IdCidade
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }



        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }



            set
            {
                nomeCidade = value;
            }
        }



        public string UfCidade
        {
            get
            {
                return ufCidade;
            }
            set
            {
                ufCidade = value;
            }
        }
        //Métodos
        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM Cidade", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

    }
}
