using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTunki.transfer;

namespace WebTunki.Models
{
    public class operadoresoa
    {
        public static operadoresdto RegistroOperador(operadoresdto operadoresdto)
        {
            tunkiEntities1 db = new tunkiEntities1();
            operadores obj = new operadores()
            {
                nombreoperador = operadoresdto.nombreoperador,
              
            };
            db.operadores.Add(obj);
            db.SaveChanges();
            operadoresdto.idoperador = obj.idoperador;
            return operadoresdto;
        }


        public static IEnumerable<operadoresdto> ListarOperadores()
        {
            tunkiEntities1 db = new tunkiEntities1();
            var list = from b in db.operadores
                       select new operadoresdto()
                       {
                           idoperador  = b.idoperador,
                           nombreoperador = b.nombreoperador
                       };
            return list;
        }
    }
}
