using CapaDatos;
using CapaEntidad;
using proyBarberia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Barbero
    {
        private CD_Barbero objcd_barbero = new CD_Barbero(); // Instancia a nuestra clase CD_Barbero
        public List<Barbero> Listar()
        {
            return objcd_barbero.Listar(); // Retornar la misma lista que tiene la clase CD_Usuario
        }

        public bool AgregarBarbero(Barbero barbero)
        {
            return objcd_barbero.Agregar(barbero);
        }

        public bool EliminarBarbero(int idBarbero)
        {
            // Puedes agregar lógica adicional aquí, como verificar si el barbero existe antes de eliminarlo.
            // Si el barbero no existe, puedes devolver false.

            return objcd_barbero.Eliminar(idBarbero);
        }

        public bool ActualizarBarbero(Barbero barbero)
        {
            // Puedes agregar lógica adicional aquí, como verificar si el barbero existe antes de actualizarlo.
            // Si el barbero no existe, puedes devolver false.

            return objcd_barbero.Actualizar(barbero);
        }
    }
}
