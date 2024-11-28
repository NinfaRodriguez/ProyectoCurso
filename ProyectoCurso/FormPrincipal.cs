namespace ProyectoCurso
{
    public partial class FormPrincipal : Form
    {
        private FormVerEmpleados formVerEmpleados;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void GestorEmpleados(object sender, EventArgs e)
        {
            FormGestorEmpleados formGestorempleados = new FormGestorEmpleados();
            formGestorempleados.Show();
        }
    }
}


