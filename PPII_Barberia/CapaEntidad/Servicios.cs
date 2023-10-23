using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servicios
    {
        public int id_servicio { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string duracion { get; set; }
        public decimal precio { get; set; }
    }
}
