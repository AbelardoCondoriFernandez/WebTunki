using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTunki.transfer;

namespace WebTunki.Models
{
    public class recargacelularsoa
    {
        public static recargacelularesdto RegistroRecargaCelular(recargacelularesdto recargacelulardto)
        {
            tunkiEntities1 db = new tunkiEntities1();
            recargacelulares obj = new recargacelulares()
            {
                idrecargacelular = recargacelulardto.idrecargacelular,
                telefono = (decimal)recargacelulardto.telefono,
                monto = (decimal)recargacelulardto.monto,
                idoperador = (int)recargacelulardto.idoperador,
                idusuario = (int)recargacelulardto.idusuario,
                idmediopago = (int)recargacelulardto.idmediopago

            };
            db.recargacelulares.Add(obj);
            db.SaveChanges();
            recargacelulardto.idrecargacelular = obj.idrecargacelular;
            return recargacelulardto;
        }
        public static IEnumerable<recargacelularesdto> ListaRecargacelular()
        {
            tunkiEntities1 db = new tunkiEntities1();
            var list = from b in db.recargacelulares
                       select new recargacelularesdto()
                       {
                           idrecargacelular = b.idrecargacelular,
                           telefono = (double)b.telefono,
                           monto = (double)b.monto,
                           idmediopago=b.idmediopago,
                           idoperador=b.idoperador,
                           idusuario=b.idusuario

                       };
            return list;
        }
    }
}