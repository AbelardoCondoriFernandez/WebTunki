using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebTunki.transfer;
using WebTunki.Models;

namespace WebTunki.Controllers
{
    public class OperadorController : ApiController
    {
        [HttpPost]
        [Route("api/tunki/registraroperador")]
        public operadoresdto RegistrarOperador(operadoresdto operadoresdto)
        {
            return operadoresoa.RegistroOperador(operadoresdto);
        }
        [HttpGet]
        [Route("api/tunki/listaroperador")]
        public IEnumerable<operadoresdto> ListarOperador()
        {
            return operadoresoa.ListarOperadores();
        }
    }
}


