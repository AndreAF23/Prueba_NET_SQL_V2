using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba_NET_SQL.Data
{
    public class Conexion
    {
        private static string _cadenaBD = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaBD);
        }
    }
}