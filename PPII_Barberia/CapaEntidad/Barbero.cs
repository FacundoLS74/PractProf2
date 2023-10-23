using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Barbero
    {
        public int id_barbero { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal sueldo_base { get; set; }
        public string fecha_contratacion { get; set; }
        public int comision { get; set; }
    }
}
