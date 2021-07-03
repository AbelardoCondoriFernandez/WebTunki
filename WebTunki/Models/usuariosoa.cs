using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTunki.transfer;

namespace WebTunki.Models
{
    public class usuariosoa
    {
        public static usuariodto RegistroUsuario(usuariodto usuariodto)
        {
            tunkiEntities1 db = new tunkiEntities1();
            usuarios obj = new usuarios()
            {
                nombre = usuariodto.nombre,
                correo = usuariodto.correo,
                saldo = (decimal?)usuariodto.saldo,
            };
            db.usuarios.Add(obj);
            db.SaveChanges();
            usuariodto.idusuario = obj.idusuario;
            return usuariodto;
        }
        public static IEnumerable<usuariodto> ListarUsuarios()
        {
            tunkiEntities1 db = new tunkiEntities1();
            var list = from b in db.usuarios
                       select new usuariodto()
                       {
                           idusuario = b.idusuario,
                           nombre = b.nombre,
                           correo=b.correo,
                           saldo= (double)b.saldo
                       };
            return list;
        }
    }
}