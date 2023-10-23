using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Turnos
    {
        public int id_turno { get; set; }
        public Barbero oBarbero { get; set; }
        public Cliente oCliente { get; set; }
        public Servicios oServicios { get; set; }
        public string fecha { get; set; }
        public bool cancelado { get; set; }
    }
}
