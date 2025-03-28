using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_NET_SQL.Models
{
    public class TAsignaturas
    {
        public int IdAsignatura;
        public String CodAsignatura;
        public int IdTipoAsignatura;
        public double ECTS;
        public String Asignatura;
        public bool EsPersonalizable;
        public double? Horas;
        public int IdModalidad;
        public bool PublicarWeb;
        public DateTime FechaAlta;
        public DateTime? FechaModificacion;
        public int? IdUsuarioModificacion;
    }
}