using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebTunki.Models;
using WebTunki.transfer;

namespace WebTunki.Controllers
{
    public class ContactoController : ApiController
    {
        [HttpPost]
        [Route("api/tunki/registrarcontacto")]
        public contactodto RegistrarUsuario(contactodto contactodto)
        {
            return contactosoa.RegistroContacto(contactodto);
        }
        [HttpGet]
        [Route("api/tunki/listarcontacto")]
        public IEnumerable<contactodto> Listarcontacto( )
        {
            return contactosoa.ListarContactos();
        }
    }
}
