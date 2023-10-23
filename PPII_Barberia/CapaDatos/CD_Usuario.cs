using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;  

namespace proyBarberia.Clases
{
    public class CD_Usuario
    {
        public List<Usuario> Listar() {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {
                try
                {
                    string query = "select id_usuario, usuario, contrasenia from usuarios";

                    SqlCommand cmd = new SqlCommand(query, oconexion); // Se encarga de ejecutar comandos, pide la accion y la conexion.
                    cmd.CommandType = CommandType.Text; // El tipo de comando que esta ejecutando es de tipo texto

                    oconexion.Open(); // abro la conexion

                    using (SqlDataReader dr = cmd.ExecuteReader()) // lee el resultado del comando
                    {
                        while (dr.Read()) {
                            lista.Add(new Usuario() // Le añado un objeto de tipo Usuario
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                usuario = dr["usuario"].ToString(),
                                contrasenia = dr["contrasenia"].ToString()
                            });
                            
                        }
                    }
                 }
                catch (Exception ex)
                {
                    lista = new List<Usuario>(); // Si hay un error que la lista se haga vacia sin elementos
                }
            }

            return lista;
        }


    }
}
