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
    public class UsuarioController : ApiController
    {
        [HttpPost]
        [Route("api/tunki/registrarusuario")]
        public usuariodto RegistrarUsuario(usuariodto usuariodto )
        {
            return usuariosoa.RegistroUsuario(usuariodto);
        }
        [HttpGet]
        [Route("api/tunki/listarusuario")]
        public IEnumerable<usuariodto> ListarUsuario()
        {
            return usuariosoa.ListarUsuarios();
        }
    }
}
