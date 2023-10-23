using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pagos
    {
        public int id_pago { get; set; }
        public Turnos oTurnos { get; set; }
        public FormasPago oFormasPago { get; set; }
        public string fecha { get; set; }
        public decimal importe_total { get; set; }
    }
}
