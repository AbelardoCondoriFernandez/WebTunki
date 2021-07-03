using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTunki.transfer
{
    public class recargacelulares
    {
        public int idrecargacelular { get; set; }
        public string telefono { get; set; }
        public double monto { get; set; }
        public usuariodto usuariodto { get; set; }
        public operadoresdto operadoresdto { get; set; }
        public mediopagosdto mediopagosdto { get; set; }

    }
}