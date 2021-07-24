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
    public class RecargaCelularController : ApiController
    {
        [HttpPost]
        [Route("api/tunki/registrarecargacelular")]
        public recargacelularesdto RegistrarUsuario(recargacelularesdto recargacelularesdto)
        {
            return recargacelularsoa.RegistroRecargaCelular(recargacelularesdto);
        }
        [HttpGet]
        [Route("api/tunki/listarecargacelular")]
        public IEnumerable<recargacelularesdto> Listarecarga()
        {
            return recargacelularsoa.ListaRecargacelular();
        }
    }
}
