using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClientePremium
    {
        public Cliente oCliente { get; set; }
        public bool premium { get; set; }
        public bool premium_barba { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public int servicios_restantes { get; set; }
    }
}
