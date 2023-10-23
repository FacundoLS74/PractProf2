using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyBarberia.Controles
{
    public partial class ctrBarberos : UserControl
    {
        public ctrBarberos()
        {
            InitializeComponent();
        }

        private void ctrBarberos_Load(object sender, EventArgs e)
        {
            Limpiar();

            // Mostrar todos los barberos
            List<Barbero> listaBarbero = new CN_Barbero().Listar();
            foreach (Barbero item in listaBarbero)
            {
                dgvBarberos.Rows.Add(new object[] {"", item.id_barbero, item.nombre, item.apellido, item.sueldo_base,
                Convert.ToDateTime(item.fecha_contratacion).ToShortDateString(), item.comision});
            }
        }

        // -----------------------------------------------------------------
        // ---------------------------- AGREGAR ----------------------------
        // -----------------------------------------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal sueldoBase;
            int comision;

            if (decimal.TryParse(txtSueldoBase.Text, out sueldoBase) && int.TryParse(txtComision.Text, out comision))
            {
                // Formatear la fecha
                string fechaContratacion = dtpFechaContrato.Value.ToString("yyyy-MM-dd");
                Convert.ToDateTime(fechaContratacion).ToShortDateString();

                dgvBarberos.Rows.Add(new object[] { "", txtIdBarbero.Text, txtNombre.Text, txtApellido.Text, sueldoBase, Convert.ToDateTime(fechaContratacion).ToShortDateString(), comision });

                Barbero nuevoBarbero = new Barbero
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    sueldo_base = sueldoBase,
                    fecha_contratacion = fechaContratacion,
                    comision = comision
                };

                if (new CN_Barbero().AgregarBarbero(nuevoBarbero))
                {
                    // Limpiar la tabla DataGridView
                    dgvBarberos.Rows.Clear();

                    // Realizar una consulta SELECT para obtener todos los barberos
                    List<Barbero> listaBarbero = new CN_Barbero().Listar();

                    // Llenar la tabla DataGridView con los datos de la base de datos
                    foreach (Barbero barbero in listaBarbero)
                    {
                        dgvBarberos.Rows.Add(new object[]
                        {
                            "", barbero.id_barbero, barbero.nombre, barbero.apellido,
                             barbero.sueldo_base, Convert.ToDateTime(barbero.fecha_contratacion).ToShortDateString(), barbero.comision
                        });
                    }

                    MessageBox.Show("Barbero agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el barbero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para Sueldo Base y Comisión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Limpiar()
        {
            txtIdBarbero.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtSueldoBase.Text = string.Empty;
            dtpFechaContrato.Value = DateTime.Now;
            txtComision.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvBarberos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBarberos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdBarbero.Text = dgvBarberos.Rows[indice].Cells["id_barbero"].Value.ToString();
                    txtNombre.Text = dgvBarberos.Rows[indice].Cells["nombre"].Value.ToString();
                    txtApellido.Text = dgvBarberos.Rows[indice].Cells["apellido"].Value.ToString();
                    txtSueldoBase.Text = dgvBarberos.Rows[indice].Cells["sueldo_base"].Value.ToString();

                    if (DateTime.TryParse(dgvBarberos.Rows[indice].Cells["fecha_contratacion"].Value.ToString(), out DateTime fechaContratacion))
                    {
                        dtpFechaContrato.Value = fechaContratacion;
                    }
                    else
                    {
                        MessageBox.Show("La fecha en la celda no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtComision.Text = dgvBarberos.Rows[indice].Cells["comision"].Value.ToString();
                }
            }
        }

        // -----------------------------------------------------------------
        // ---------------------------- ELIMINAR ---------------------------
        // -----------------------------------------------------------------

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtén la ID del barbero a eliminar desde el textbox
            if (int.TryParse(txtIdBarbero.Text, out int idBarberoAEliminar))
            {
                // Llama al método de la capa de negocio para eliminar el barbero
                if (new CN_Barbero().EliminarBarbero(idBarberoAEliminar))
                {
                    // Elimina la fila correspondiente en el DataGridView
                    foreach (DataGridViewRow row in dgvBarberos.Rows)
                    {
                        if (row.Cells["id_barbero"].Value != null && (int)row.Cells["id_barbero"].Value == idBarberoAEliminar)
                        {
                            dgvBarberos.Rows.Remove(row);
                            break; // Sal del bucle una vez que se haya eliminado la fila
                        }
                    }

                    MessageBox.Show("Barbero eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el barbero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una ID de barbero válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------------------------------------------------
        // --------------------------- ACTUALIZAR --------------------------
        // -----------------------------------------------------------------

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtén la ID del barbero a actualizar desde el textbox
            if (int.TryParse(txtIdBarbero.Text, out int idBarberoAActualizar))
            {
                // Valida que los otros campos contengan datos válidos
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) &&
                    decimal.TryParse(txtSueldoBase.Text, out decimal sueldoBase) && int.TryParse(txtComision.Text, out int comision))
                {
                    // Formatea la fecha antes de asignarla
                    string fechaContratacion = dtpFechaContrato.Value.ToString("dd/MM/yyyy");

                    // Crea un objeto Barbero con los nuevos datos
                    Barbero barberoActualizado = new Barbero
                    {
                        id_barbero = idBarberoAActualizar,
                        nombre = txtNombre.Text,
                        apellido = txtApellido.Text,
                        sueldo_base = sueldoBase,
                        fecha_contratacion = fechaContratacion, // Asigna la fecha formateada
                        comision = comision
                    };

                    // Llama al método de la capa de negocio para actualizar el barbero
                    if (new CN_Barbero().ActualizarBarbero(barberoActualizado))
                    {
                        // Actualiza la fila correspondiente en el DataGridView
                        foreach (DataGridViewRow row in dgvBarberos.Rows)
                        {
                            if (row.Cells["id_barbero"].Value != null && (int)row.Cells["id_barbero"].Value == idBarberoAActualizar)
                            {
                                row.Cells["nombre"].Value = txtNombre.Text;
                                row.Cells["apellido"].Value = txtApellido.Text;
                                row.Cells["sueldo_base"].Value = sueldoBase;
                                row.Cells["fecha_contratacion"].Value = fechaContratacion;
                                row.Cells["comision"].Value = comision;
                                break; // Sal del bucle una vez que se haya actualizado la fila
                            }
                        }

                        MessageBox.Show("Barbero actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el barbero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos válidos en los campos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una ID de barbero válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
