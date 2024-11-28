using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCurso
{
    public partial class FormVerEmpleados : Form
    {
        //Uso colecciones genéricas
        private static List<Empleado> empleados = new List<Empleado>();


        public FormVerEmpleados()
        {
            InitializeComponent();
            CargarDataGridView();

            //Asignar Eventos
            tsbEditar.Click += EditarEmpleado;
            tsbEliminar.Click += EliminarEmpleado;
            editarEmpleadoToolStripMenuItem.Click += EditarEmpleado;
            eliminarEmpleadoToolStripMenuItem.Click += EliminarEmpleado;

        }
        public void CargarDataGridView()
        {
            dgvEmpleados.ContextMenuStrip = cmsOpcionesEmpleados;
            dgvEmpleados.DataSource = null; // Limpia la fuente de datos
            dgvEmpleados.DataSource = empleados.Select(e => new Empleado //Uso LINQ
            {
                ID = e.ID,
                Nombre = e.Nombre,
                Cargo = e.Cargo,
                Cedula = e.Cedula,
                Telefono = e.Telefono,
                FechaNacimiento = e.FechaNacimiento,
                FechaContratacion = e.FechaContratacion,
                SalarioMensual = e.SalarioMensual,
            }).ToList(); // Crea una lista nueva para evitar referencias compartidas
        }

        private void cmsOpcionesEmpleados_Opening(object sender, CancelEventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                e.Cancel = true; // Ocultar el menú si no hay una fila seleccionada
            }
        }

        private void FormVerEmpleados_Load(object sender, EventArgs e)
        {
            // Configurar el Panel contenedor
            panelContenedorData.AutoScroll = true; // Habilitar scroll
            panelContenedorData.Dock = DockStyle.Fill; // Ajustar al tamaño del formulario

            // Ajustar el DataGridView
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Cargar datos
            CargarDataGridView();
        }

        public static void AgregarEmpleado(Empleado nuevoEmpleado)
        {
            // Crear una nueva instancia al agregar para evitar referencias compartidas
            Empleado empleadoCopia = new Empleado
            {
                ID = nuevoEmpleado.ID,
                Nombre = nuevoEmpleado.Nombre,
                Cargo = nuevoEmpleado.Cargo,
                Cedula = nuevoEmpleado.Cedula,
                Telefono = nuevoEmpleado.Telefono,
                FechaNacimiento = nuevoEmpleado.FechaNacimiento,
                FechaContratacion = nuevoEmpleado.FechaContratacion,
                SalarioMensual = nuevoEmpleado.SalarioMensual

            };

            empleados.Add(empleadoCopia); // Agregar la copia a la lista
        }


        private void EditarEmpleadoSeleccionado()
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                // Obtener el índice del empleado seleccionado
                int index = dgvEmpleados.SelectedRows[0].Index;

                // Recuperar el empleado seleccionado
                Empleado empleadoSeleccionado = empleados[index];

                // Abrir el formulario de edición
                FormIngresarEmpleado formIngresarEmpleado = new FormIngresarEmpleado(empleadoSeleccionado);

                if (formIngresarEmpleado.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar los datos del empleado seleccionado
                    empleados[index] = formIngresarEmpleado.Empleado;

                    // Refrescar el DataGridView
                    CargarDataGridView();
                    ActualizarEstado("Empleado editado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditarEmpleado(object sender, EventArgs e)
        {
            EditarEmpleadoSeleccionado();
        }

        private void EliminarEmpleadoSeleccionado()
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {


                // Confirmar eliminación
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este empleado?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Obtener el índice del empleado seleccionado
                    int index = dgvEmpleados.SelectedRows[0].Index;

                    // Eliminar el empleado de la lista
                    empleados.RemoveAt(index);

                    // Refrescar el DataGridView
                    CargarDataGridView();
                    ActualizarEstado("Empleado eliminado correctamente.");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void EliminarEmpleado(object sender, EventArgs e)
        {
            EliminarEmpleadoSeleccionado();
        }


        private void ActualizarEstado(string mensaje)
        {
            MessageBox.Show(mensaje, "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditarEmpleadoStrip(object sender, EventArgs e)
        {
            EditarEmpleadoSeleccionado();
        }

        private void EliminarEmpleadoStrip(object sender, EventArgs e)
        {
            EliminarEmpleadoSeleccionado();
        }
        public static List<Empleado> ObtenerListaEmpleados()
        {
            return empleados;
        }

    }
}

