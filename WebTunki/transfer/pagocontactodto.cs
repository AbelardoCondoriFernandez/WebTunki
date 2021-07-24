using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTunki.transfer
{
    public class pagocontactodto
    {   
        public int idpagocontacto { get; set; }
        public string codigodeoperacion { get; set; }
        public double saldo { get; set; }
        public Nullable<DateTime> fecha { get; set; }
        public double monto { get; set; }
        public Nullable <int> idmediopago { get; set; }
        public Nullable <int> idusuarios { get; set; }
        public Nullable<int> idcontacto { get; set; }

    }
}