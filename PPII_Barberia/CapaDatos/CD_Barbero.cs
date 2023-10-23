using CapaEntidad;
using proyBarberia.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CapaDatos
{
    public class CD_Barbero
    {

        public List<Barbero> Listar()
        {
            List<Barbero> lista = new List<Barbero>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select id_barbero, nombre, apellido, sueldo_base, fecha_contratacion, comision from barberos";

                    SqlCommand cmd = new SqlCommand(query, oconexion); // Se encarga de ejecutar comandos, pide la accion y la conexion.
                    cmd.CommandType = CommandType.Text; // El tipo de comando que esta ejecutando es de tipo texto

                    oconexion.Open(); // abro la conexion

                    using (SqlDataReader dr = cmd.ExecuteReader()) // lee el resultado del comando
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Barbero() // Le añado un objeto de tipo Barbero
                            {
                                id_barbero = Convert.ToInt32(dr["id_barbero"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                sueldo_base = Convert.ToDecimal(dr["sueldo_base"]),
                                fecha_contratacion = dr["fecha_contratacion"].ToString(),
                                comision = Convert.ToInt32(dr["comision"])
                            });

                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Barbero>(); // Si hay un error que la lista se haga vacia sin elementos
                }
            }

            return lista;
        }

        public bool Agregar(Barbero barbero)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO barberos (nombre, apellido, sueldo_base, fecha_contratacion, comision) VALUES (@nombre, @apellido, @sueldo_base, @fecha_contratacion, @comision)";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nombre", barbero.nombre);
                    cmd.Parameters.AddWithValue("@apellido", barbero.apellido);
                    cmd.Parameters.AddWithValue("@sueldo_base", barbero.sueldo_base);
                    cmd.Parameters.AddWithValue("@fecha_contratacion", barbero.fecha_contratacion);
                    cmd.Parameters.AddWithValue("@comision", barbero.comision);

                    oconexion.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool Eliminar(int idBarbero)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM barberos WHERE id_barbero = @id_barbero";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id_barbero", idBarbero);

                    oconexion.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool Actualizar(Barbero barbero)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE barberos SET nombre = @nombre, apellido = @apellido, sueldo_base = @sueldo_base, fecha_contratacion = @fecha_contratacion, comision = @comision WHERE id_barbero = @id_barbero";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id_barbero", barbero.id_barbero);
                    cmd.Parameters.AddWithValue("@nombre", barbero.nombre);
                    cmd.Parameters.AddWithValue("@apellido", barbero.apellido);
                    cmd.Parameters.AddWithValue("@sueldo_base", barbero.sueldo_base);
                    cmd.Parameters.AddWithValue("@fecha_contratacion", barbero.fecha_contratacion);
                    cmd.Parameters.AddWithValue("@comision", barbero.comision);

                    oconexion.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }




    }
}
