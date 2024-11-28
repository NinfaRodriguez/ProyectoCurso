namespace ProyectoCurso
{
    partial class FormIngresarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIngresar = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            txtNombreEmpleado = new TextBox();
            dtpNacimientoEmpleado = new DateTimePicker();
            dtpContratacionEmpleado = new DateTimePicker();
            label5 = new Label();
            label8 = new Label();
            mtxtCedulaEmpleado = new MaskedTextBox();
            mtxtTelefonoEmpleado = new MaskedTextBox();
            mtxtIDEmpleado = new MaskedTextBox();
            cmbCargoEmpleado = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            btnIngresarEmpleadoDatosCompletos = new Button();
            lblEditar = new Label();
            label11 = new Label();
            txtSalarioEmpleado = new TextBox();
            btnCargarConfiguracion = new Button();
            btnGuardartxt = new Button();
            SuspendLayout();
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresar.Location = new Point(135, 9);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(262, 28);
            lblIngresar.TabIndex = 0;
            lblIngresar.Text = "Ingresar nuevo Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(51, 61);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 105);
            label3.Name = "label3";
            label3.Size = new Size(26, 21);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(51, 368);
            label6.Name = "label6";
            label6.Size = new Size(173, 21);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Contratación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(51, 328);
            label7.Name = "label7";
            label7.Size = new Size(163, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(51, 145);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "Cargo";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(242, 59);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(305, 23);
            txtNombreEmpleado.TabIndex = 8;
            // 
            // dtpNacimientoEmpleado
            // 
            dtpNacimientoEmpleado.Location = new Point(242, 326);
            dtpNacimientoEmpleado.Name = "dtpNacimientoEmpleado";
            dtpNacimientoEmpleado.Size = new Size(305, 23);
            dtpNacimientoEmpleado.TabIndex = 10;
            // 
            // dtpContratacionEmpleado
            // 
            dtpContratacionEmpleado.Location = new Point(242, 368);
            dtpContratacionEmpleado.Name = "dtpContratacionEmpleado";
            dtpContratacionEmpleado.Size = new Size(305, 23);
            dtpContratacionEmpleado.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(51, 283);
            label5.Name = "label5";
            label5.Size = new Size(161, 21);
            label5.TabIndex = 14;
            label5.Text = "Numero de Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(51, 240);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 15;
            label8.Text = "Numero de Cedula";
            // 
            // mtxtCedulaEmpleado
            // 
            mtxtCedulaEmpleado.Location = new Point(242, 238);
            mtxtCedulaEmpleado.Mask = "000-000000-0000>L";
            mtxtCedulaEmpleado.Name = "mtxtCedulaEmpleado";
            mtxtCedulaEmpleado.Size = new Size(305, 23);
            mtxtCedulaEmpleado.TabIndex = 17;
            // 
            // mtxtTelefonoEmpleado
            // 
            mtxtTelefonoEmpleado.Location = new Point(242, 281);
            mtxtTelefonoEmpleado.Mask = "(999)0000-0000";
            mtxtTelefonoEmpleado.Name = "mtxtTelefonoEmpleado";
            mtxtTelefonoEmpleado.Size = new Size(305, 23);
            mtxtTelefonoEmpleado.TabIndex = 18;
            // 
            // mtxtIDEmpleado
            // 
            mtxtIDEmpleado.Location = new Point(242, 103);
            mtxtIDEmpleado.Mask = ">L-0000";
            mtxtIDEmpleado.Name = "mtxtIDEmpleado";
            mtxtIDEmpleado.Size = new Size(305, 23);
            mtxtIDEmpleado.TabIndex = 19;
            // 
            // cmbCargoEmpleado
            // 
            cmbCargoEmpleado.FormattingEnabled = true;
            cmbCargoEmpleado.Location = new Point(242, 143);
            cmbCargoEmpleado.Name = "cmbCargoEmpleado";
            cmbCargoEmpleado.Size = new Size(305, 23);
            cmbCargoEmpleado.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(242, 87);
            label9.Name = "label9";
            label9.Size = new Size(41, 13);
            label9.TabIndex = 21;
            label9.Text = "X-0000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(242, 222);
            label10.Name = "label10";
            label10.Size = new Size(99, 13);
            label10.TabIndex = 22;
            label10.Text = "000-000000-0000X";
            // 
            // btnIngresarEmpleadoDatosCompletos
            // 
            btnIngresarEmpleadoDatosCompletos.Location = new Point(217, 411);
            btnIngresarEmpleadoDatosCompletos.Name = "btnIngresarEmpleadoDatosCompletos";
            btnIngresarEmpleadoDatosCompletos.Size = new Size(146, 43);
            btnIngresarEmpleadoDatosCompletos.TabIndex = 23;
            btnIngresarEmpleadoDatosCompletos.Text = "Guardar";
            btnIngresarEmpleadoDatosCompletos.UseVisualStyleBackColor = true;
            btnIngresarEmpleadoDatosCompletos.Click += IngresarEmpleadoDatosCompletos;
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(135, 11);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(157, 26);
            lblEditar.TabIndex = 24;
            lblEditar.Text = "Editar Empleado";
            lblEditar.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(51, 192);
            label11.Name = "label11";
            label11.Size = new Size(124, 21);
            label11.TabIndex = 26;
            label11.Text = "Salario Mensual";
            // 
            // txtSalarioEmpleado
            // 
            txtSalarioEmpleado.Location = new Point(242, 190);
            txtSalarioEmpleado.Name = "txtSalarioEmpleado";
            txtSalarioEmpleado.Size = new Size(305, 23);
            txtSalarioEmpleado.TabIndex = 27;
            // 
            // btnCargarConfiguracion
            // 
            btnCargarConfiguracion.Location = new Point(51, 411);
            btnCargarConfiguracion.Name = "btnCargarConfiguracion";
            btnCargarConfiguracion.Size = new Size(146, 43);
            btnCargarConfiguracion.TabIndex = 28;
            btnCargarConfiguracion.Text = "Cargar";
            btnCargarConfiguracion.UseVisualStyleBackColor = true;
            btnCargarConfiguracion.Click += btnCargarConfiguracion_Click;
            // 
            // btnGuardartxt
            // 
            btnGuardartxt.Location = new Point(392, 411);
            btnGuardartxt.Name = "btnGuardartxt";
            btnGuardartxt.Size = new Size(146, 43);
            btnGuardartxt.TabIndex = 29;
            btnGuardartxt.Text = "Guardar txt";
            btnGuardartxt.UseVisualStyleBackColor = true;
            btnGuardartxt.Click += btnGuardartxt_Click;
            // 
            // FormIngresarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 511);
            Controls.Add(btnGuardartxt);
            Controls.Add(btnCargarConfiguracion);
            Controls.Add(txtSalarioEmpleado);
            Controls.Add(label11);
            Controls.Add(lblEditar);
            Controls.Add(btnIngresarEmpleadoDatosCompletos);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cmbCargoEmpleado);
            Controls.Add(mtxtIDEmpleado);
            Controls.Add(mtxtTelefonoEmpleado);
            Controls.Add(mtxtCedulaEmpleado);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(dtpContratacionEmpleado);
            Controls.Add(dtpNacimientoEmpleado);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIngresar);
            Name = "FormIngresarEmpleado";
            Text = "FormIngresarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresar;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label4;
        private TextBox txtNombreEmpleado;
        private DateTimePicker dtpNacimientoEmpleado;
        private DateTimePicker dtpContratacionEmpleado;
        private Label label5;
        private Label label8;
        private MaskedTextBox mtxtCedulaEmpleado;
        private MaskedTextBox mtxtTelefonoEmpleado;
        private MaskedTextBox mtxtIDEmpleado;
        private ComboBox cmbCargoEmpleado;
        private Label label9;
        private Label label10;
        private Button btnIngresarEmpleadoDatosCompletos;
        private Label lblEditar;
        private Label label11;
        private TextBox txtSalarioEmpleado;
        private Button btnCargarConfiguracion;
        private Button btnGuardartxt;
    }
}