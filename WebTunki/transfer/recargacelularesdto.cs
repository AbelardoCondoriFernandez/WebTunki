using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTunki.transfer
{
    public class recargacelularesdto
    {
        public int idrecargacelular { get; set; }
        public double telefono { get; set; }
        public double monto { get; set; }
        public Nullable<int> idmediopago { get; set; }
        public Nullable<int> idusuario { get; set; }
        public Nullable<int> idoperador { get; set; }

    }
}