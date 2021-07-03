using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTunki.transfer;

namespace WebTunki.Models
{
    public class contactosoa
    {
        public static contactodto RegistroContacto(contactodto contactodto)
        {
            tunkiEntities1 db = new tunkiEntities1();
            contactos obj = new contactos()
            {
                nombrecontacto = contactodto.nombrecontacto,
                telefono = contactodto.telefono,
               
            };
            db.contactos.Add(obj);
            db.SaveChanges();
            contactodto.idcontacto = obj.idcontacto;
            return contactodto;
        }


        public static IEnumerable<contactodto> ListarContactos()
        {
           tunkiEntities1 db = new tunkiEntities1();
            var list = from b in db.contactos
                       select new contactodto()
                       {
                           idcontacto=b.idcontacto,
                           nombrecontacto=b.nombrecontacto,
                           telefono=b.telefono
                       };
            return list;
        }
    }
}
