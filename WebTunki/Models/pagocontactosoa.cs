using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTunki.transfer;

namespace WebTunki.Models
{
    public class pagocontactosoa
    {
        public static pagocontactodto RegistroPagoContacto(pagocontactodto pagocontactodto)
        {
            tunkiEntities1 db = new tunkiEntities1();
            pagocontactos obj = new pagocontactos()
            {
              idpagocontacto=pagocontactodto.idpagocontacto,
                codigodeoperacion = pagocontactodto.codigodeoperacion,
                saldo= (decimal)pagocontactodto.saldo,
                    fecha=DateTime.Now,
                    monto=(decimal)pagocontactodto.monto,
                idcontacto = (int)pagocontactodto.idcontacto,
                idusuarios = (int)pagocontactodto.idusuarios,
                idmediopago = (int)pagocontactodto.idmediopago

            };
            db.pagocontactos.Add(obj);
            db.SaveChanges();
            pagocontactodto.idpagocontacto = obj.idpagocontacto;
            return pagocontactodto;
        }
        /*     public static IEnumerable<pagocontactodto> ListarPagosContactos(int idmediopago)
             {
                 tunkiEntities1 db = new tunkiEntities1();
                 var list = from b in db.pagocontactos.Where(t=>t.idmediopago==idmediopago)
                            select new pagocontactodto()
                            {
                                idpagocontacto = b.idpagocontacto,
                                codigodeoperacion = b.codigodeoperacion,
                                fecha=b.fecha,
                                idcontacto=b.idcontacto,
                                idmediopago=b.idmediopago,
                                idusuario = b.idusuario
                            };
                 return list;
             }*/
        public static IEnumerable<pagocontactodto> ListaPagosContactos()
        {
            tunkiEntities1 db = new tunkiEntities1();
            var list = from b in db.pagocontactos
                       select new pagocontactodto()
                       {
                           idpagocontacto = b.idpagocontacto,
                           codigodeoperacion = b.codigodeoperacion,
                           monto = (double)b.monto,
                           fecha=b.fecha,
                           saldo= (double)b.saldo,
                           idmediopago = b.idmediopago,
                           idcontacto = b.idcontacto,
                           idusuarios = b.idusuarios

                       };
            return list;
        }
    }
}