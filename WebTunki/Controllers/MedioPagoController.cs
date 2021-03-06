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
    public class MedioPagoController : ApiController
    {
        [HttpPost]
        [Route("api/tunki/registrarmediopago")]
        public mediopagosdto RegistrarMedioPago(mediopagosdto mediopagosdto)
        {
            return mediopagosoa.RegistroMedioPago(mediopagosdto);
        }
        [HttpGet]
        [Route("api/tunki/listarmediopago")]
        public IEnumerable<mediopagosdto> ListarMediopago()
        {
            return mediopagosoa.ListarMedioPago();
        }
      /*  [HttpPost]
        [Route("api/tunki/registra")]
        public pagocontactodto RegistrarPagoContacto(pagocontactodto pagocontactodto)
        {
            return pagocontactosoa.RegistroPagoContacto(pagocontactodto);
        }
        [HttpGet]
        [Route("api/tunki/listarpagocontactos")]
        public IEnumerable<pagocontactodto> ListarPagoContacto(int idmediopago)
        {
            return pagocontactosoa.ListarPagosContactos(idmediopago);
        }*/
    }
}

