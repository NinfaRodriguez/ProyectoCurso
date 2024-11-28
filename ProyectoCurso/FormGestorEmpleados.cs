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
    public partial class FormGestorEmpleados : Form
    {
        public FormGestorEmpleados()
        {
            InitializeComponent();
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            try
            {
                // Limpia los controles existentes en la pestaña
                tabPage.Controls.Clear();

                // Configura el formulario para que se muestre dentro de la pestaña
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                // Agrega el formulario a la pestaña y lo muestra
                tabPage.Controls.Add(formulario);
                formulario.Show();

                // Selecciona la pestaña donde se está mostrando el formulario
                tbcEmpleados.SelectedTab = tabPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarNuevoEmpleado(object sender, EventArgs e)
        {
            FormIngresarEmpleado formIngresarEmpleado = new FormIngresarEmpleado();
            MostrarFormularioEnTabPage(formIngresarEmpleado, tbpIngresarEmpleado); // tbpIngresarEmpleado es la TabPage correspondiente
        }

        private void VerEmpleados(object sender, EventArgs e)
        {
            FormVerEmpleados formVerEmpleados = new FormVerEmpleados();
            MostrarFormularioEnTabPage(formVerEmpleados, tbpVerEmpleados); // tbpVerEmpleados es la TabPage correspondiente
        }
    }
}

