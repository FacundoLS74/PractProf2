using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using proyBarberia.Clases;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario(); // Instancia a nuestra clase CD_Usuario
        public List<Usuario> Listar() { 
         return objcd_usuario.Listar(); // Retornar la misma lista que tiene la clase CD_Usuario
        }
    }
}
