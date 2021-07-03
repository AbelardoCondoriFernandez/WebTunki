using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTunki.transfer;

namespace WebTunki.Models
{
    public class mediopagosoa
    {
        public static mediopagosdto RegistroMedioPago(mediopagosdto mediopagosdto)
        {
            tunkiEntities1 db = new tunkiEntities1();
            mediopagos obj = new mediopagos()
            {
                nombremediopago = mediopagosdto.nombremediopago,
              
            };
            db.mediopagos.Add(obj);
            db.SaveChanges();
            mediopagosdto.idmediopago = obj.idmediopago;
            return mediopagosdto;
        }
        public static IEnumerable<mediopagosdto> ListarMedioPago()
        {
            tunkiEntities1 db = new tunkiEntities1();
            var list = from b in db.mediopagos
                       select new mediopagosdto()
                       {
                           idmediopago = b.idmediopago,
                           nombremediopago = b.nombremediopago
                       };
            return list;
        }
    }
}
