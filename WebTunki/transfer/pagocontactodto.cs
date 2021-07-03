using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTunki.transfer
{
    public class pagocontactodto
    {
        public int idpagocontacto { get; set; }
        public string codigodeoperacionr { get; set; }
        public double saldo { get; set; }
        public mediopagosdto mediopagosdto { get; set; }
        public usuariodto usuariodto { get; set; }
        public contactodto contactodto { get; set; }
        public DateTime fecha { get; set; }

    }
}