using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Prueba_NET_SQL.Models;
using Dapper;

namespace Prueba_NET_SQL.Data
{
    public class AsignaturaRepository
    {

        public IEnumerable<TAsignaturas> obtenerDATA()
        {

            using (IDbConnection db = Conexion.ObtenerConexion())
            {

                
                string sql = @"
                    SELECT TA.*
                    FROM TAsignaturas AS TA
                    INNER JOIN TProgramasAsignaturas AS TX ON TA.IdAsignatura = TX.IdAsignatura
                    INNER JOIN TProgramas AS TP ON TX.IdPrograma = TP.IdPrograma
                    WHERE TP.Programa = 'Grado en Enfermería';
                ";
                
                //string sql = "SELECT * FROM TAsignaturas";
                return db.Query<TAsignaturas>(sql).ToList();
            }
        }
    }
}