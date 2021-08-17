using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BombonesApp.Datos.Common;

namespace BombonesApp.Datos.Sql
{
    public class ConexionBd : IConexionBd
    {
        private readonly string cadenaDeConexion;
        private SqlConnection cn;

        public static ConexionBd instancia;
        //Patrón Singleton
        public static ConexionBd GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBd();
            }

            return instancia;
        }
        private ConexionBd()
        {
            this.cadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }

        public IDbConnection GetConexion()
        {
            try
            {

                cn = new SqlConnection(cadenaDeConexion);
                

            }
            catch (Exception ex)
            {
                cn = null;
            }
            return cn;
        }

    }
}
