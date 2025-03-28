using Prueba_NET_SQL.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prueba_NET_SQL.Data;
namespace Prueba_NET_SQL.Controllers
{
    //base controlador

    [RoutePrefix("api/Asignatura")]
    public class AsignaturaController : ApiController
    {
        [HttpGet]
        [Route("")]
        // GET Aisnatura
        public IEnumerable<TAsignaturas> Get()
        {
            AsignaturaRepository FasignaturaRepository = new AsignaturaRepository();
            return FasignaturaRepository.obtenerDATA();
        }

    }


}