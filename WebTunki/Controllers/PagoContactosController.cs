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
    public class PagoContactosController : ApiController
    {
        [HttpPost]
        [Route("api/tunki/registrarpagocontacto")]
        public pagocontactodto RegistrarUsuario(pagocontactodto pagocontactodto)
        {
            return pagocontactosoa.RegistroPagoContacto(pagocontactodto);
        }
        [HttpGet]
        [Route("api/tunki/listarpagocontacto")]
        public IEnumerable<pagocontactodto> ListarPagoContacto()
        {
            return pagocontactosoa.ListaPagosContactos();
        }
    }
}
