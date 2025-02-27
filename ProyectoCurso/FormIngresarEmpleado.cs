﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCurso;

namespace ProyectoCurso
{
    public partial class FormIngresarEmpleado : Form
    {
        public Empleado Empleado { get; private set; }

        // Lista de empleados, que debe estar en tu formulario o clase
        private List<Empleado> empleados = new List<Empleado>();
        private bool esEdicion; //Cuando se invoca el formulario de ingresar empleado para editar

        public FormIngresarEmpleado()
        {
            InitializeComponent();
            CargarCargos(); //Inicializar el combobox
            esEdicion = false;
        }
        private bool ValidarFormulario()
        {
            // 1. Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreEmpleado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCargoEmpleado.Text))
            {
                MessageBox.Show("El campo 'Cargo' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargoEmpleado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSalarioEmpleado.Text) || !double.TryParse(txtSalarioEmpleado.Text, out double salario) || salario < 0)
            {
                MessageBox.Show("El campo 'Salario Mensual' debe contener un valor numérico válido mayor o igual a 0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioEmpleado.Focus();
                return false;
            }

            if (!mtxtCedulaEmpleado.MaskCompleted)
            {
                MessageBox.Show("El campo 'Cédula' debe estar completo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtCedulaEmpleado.Focus();
                return false;
            }

            if (!mtxtTelefonoEmpleado.MaskCompleted)
            {
                MessageBox.Show("El campo 'Teléfono' debe estar completo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtTelefonoEmpleado.Focus();
                return false;
            }

            if (!mtxtIDEmpleado.MaskCompleted)
            {
                MessageBox.Show("El campo 'ID' debe estar completo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtIDEmpleado.Focus();
                return false;
            }

            // 2. Validar fecha de nacimiento
            DateTime fechaNacimiento = dtpNacimientoEmpleado.Value;
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNacimientoEmpleado.Focus();
                return false;
            }

            if (edad < 18)
            {
                MessageBox.Show("El empleado debe tener al menos 18 años.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNacimientoEmpleado.Focus();
                return false;
            }

            if (edad > 100)
            {
                MessageBox.Show("El empleado no puede tener más de 100 años.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNacimientoEmpleado.Focus();
                return false;
            }

            // 3. Validar fecha de contratación
            DateTime fechaContratacion = dtpContratacionEmpleado.Value;

            if (fechaContratacion > DateTime.Now)
            {
                MessageBox.Show("La fecha de contratación no puede ser en el futuro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpContratacionEmpleado.Focus();
                return false;
            }

            if (fechaContratacion < fechaNacimiento.AddYears(18))
            {
                MessageBox.Show("La fecha de contratación no puede ser antes de que el empleado cumpla 18 años.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpContratacionEmpleado.Focus();
                return false;
            }

            return true; // Si todas las validaciones son exitosas
        }
        public FormIngresarEmpleado(Empleado empleado)
        {
            InitializeComponent();
            CargarCargos();
            esEdicion = true; // Modo edición
            lblIngresar.Visible = false;
            lblEditar.Visible = true;

            // Cargar datos del empleado seleccionado en los controles
            txtNombreEmpleado.Text = empleado.Nombre;
            cmbCargoEmpleado.Text = empleado.Cargo;
            mtxtCedulaEmpleado.Text = empleado.Cedula;
            mtxtTelefonoEmpleado.Text = empleado.Telefono;
            mtxtIDEmpleado.Text = empleado.ID;
            mtxtIDEmpleado.Enabled = false; // El ID no debe ser editable en modo edición
            dtpNacimientoEmpleado.Value = empleado.FechaNacimiento;
            dtpContratacionEmpleado.Value = empleado.FechaContratacion;
            txtSalarioEmpleado.Text = empleado.SalarioMensual.ToString();

            Empleado = empleado; // Guardar referencia del empleado que se está editando
        }
        private void CargarCargos()
        {
            cmbCargoEmpleado.Items.Clear(); // Limpia cualquier elemento existente
            foreach (var cargo in Enum.GetValues(typeof(Cargos)))
            {
                string nombreConEspacios = string.Concat(cargo.ToString().Select(x => char.IsUpper(x) ? " " + x : x.ToString())).Trim();
                cmbCargoEmpleado.Items.Add(nombreConEspacios); //Agrega espacios a los elementos del Enum para añadirlos al Combobox
            }
        }
        private void IngresarEmpleadoDatosCompletos(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                // Verificar si el ID ya existe en la lista global de empleados
                bool idExistente = FormVerEmpleados.ObtenerListaEmpleados().Any(emp => emp.ID == mtxtIDEmpleado.Text);

                // Si el ID ya existe y no estamos en modo edición, mostrar un error
                if (idExistente && !esEdicion)
                {
                    MessageBox.Show("El ID ingresado ya está registrado. Por favor, ingrese un ID único.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtIDEmpleado.Focus();
                    return;
                }

                // Crear empleado
                Empleado = new Empleado
                {
                    ID = mtxtIDEmpleado.Text,
                    Nombre = txtNombreEmpleado.Text,
                    Cargo = cmbCargoEmpleado.Text,
                    Cedula = mtxtCedulaEmpleado.Text,
                    Telefono = mtxtTelefonoEmpleado.Text,
                    FechaNacimiento = dtpNacimientoEmpleado.Value,
                    FechaContratacion = dtpContratacionEmpleado.Value,
                    SalarioMensual = double.Parse(txtSalarioEmpleado.Text)

                };

                // En modo agregar, lo enviamos a la lista global
                if (!esEdicion)
                {
                    FormVerEmpleados.AgregarEmpleado(Empleado);
                }

                // Refrescar el DataGridView en FormVerEmpleados
                FormVerEmpleados formVerEmpleados = Application.OpenForms.OfType<FormVerEmpleados>().FirstOrDefault();
                formVerEmpleados?.CargarDataGridView();

                // Confirmación
                MessageBox.Show(esEdicion ? "¡Empleado editado correctamente!" : "¡Empleado agregado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

                // Limpiar los campos si se está agregando un empleado
                if (!esEdicion)
                {
                    LimpiarControles();
                }
            }
             

        }
        private void LimpiarControles()
        {
            txtNombreEmpleado.Clear();
            cmbCargoEmpleado.SelectedIndex = -1;
            mtxtCedulaEmpleado.Clear();
            mtxtTelefonoEmpleado.Clear();
            mtxtIDEmpleado.Clear();
            txtSalarioEmpleado.Clear();
            dtpNacimientoEmpleado.Value = DateTime.Now;
            dtpContratacionEmpleado.Value = DateTime.Now;
        }
    }
}  

