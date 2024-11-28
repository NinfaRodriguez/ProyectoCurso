namespace ProyectoCurso
{
    partial class FormGestorEmpleados
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            btnVerEmpleados = new Button();
            btnAgregarEmpleado = new Button();
            label1 = new Label();
            tbcEmpleados = new TabControl();
            tbpIngresarEmpleado = new TabPage();
            pnlIngresarEmpleado = new Panel();
            tbpVerEmpleados = new TabPage();
            pnlVerEmpleados = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            tbcEmpleados.SuspendLayout();
            tbpIngresarEmpleado.SuspendLayout();
            tbpVerEmpleados.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tbcEmpleados);
            splitContainer1.Size = new Size(884, 511);
            splitContainer1.SplitterDistance = 255;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVerEmpleados);
            groupBox1.Controls.Add(btnAgregarEmpleado);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 480);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // btnVerEmpleados
            // 
            btnVerEmpleados.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerEmpleados.Location = new Point(26, 266);
            btnVerEmpleados.Name = "btnVerEmpleados";
            btnVerEmpleados.Size = new Size(193, 107);
            btnVerEmpleados.TabIndex = 1;
            btnVerEmpleados.Text = "Ver Empleados";
            btnVerEmpleados.UseVisualStyleBackColor = true;
            btnVerEmpleados.Click += VerEmpleados;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEmpleado.Location = new Point(26, 69);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(193, 107);
            btnAgregarEmpleado.TabIndex = 0;
            btnAgregarEmpleado.Text = "Ingresar Nuevo Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += IngresarNuevoEmpleado;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 28);
            label1.TabIndex = 0;
            label1.Text = "GESTOR DE EMPLEADOS";
            // 
            // tbcEmpleados
            // 
            tbcEmpleados.Controls.Add(tbpIngresarEmpleado);
            tbcEmpleados.Controls.Add(tbpVerEmpleados);
            tbcEmpleados.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbcEmpleados.Location = new Point(2, 3);
            tbcEmpleados.Name = "tbcEmpleados";
            tbcEmpleados.SelectedIndex = 0;
            tbcEmpleados.Size = new Size(623, 508);
            tbcEmpleados.TabIndex = 0;
            // 
            // tbpIngresarEmpleado
            // 
            tbpIngresarEmpleado.Controls.Add(pnlIngresarEmpleado);
            tbpIngresarEmpleado.Location = new Point(4, 30);
            tbpIngresarEmpleado.Name = "tbpIngresarEmpleado";
            tbpIngresarEmpleado.Padding = new Padding(3);
            tbpIngresarEmpleado.Size = new Size(615, 474);
            tbpIngresarEmpleado.TabIndex = 0;
            tbpIngresarEmpleado.Text = "Ingresar Empleado";
            tbpIngresarEmpleado.UseVisualStyleBackColor = true;
            // 
            // pnlIngresarEmpleado
            // 
            pnlIngresarEmpleado.Dock = DockStyle.Fill;
            pnlIngresarEmpleado.Location = new Point(3, 3);
            pnlIngresarEmpleado.Name = "pnlIngresarEmpleado";
            pnlIngresarEmpleado.Size = new Size(609, 468);
            pnlIngresarEmpleado.TabIndex = 0;
            // 
            // tbpVerEmpleados
            // 
            tbpVerEmpleados.Controls.Add(pnlVerEmpleados);
            tbpVerEmpleados.Location = new Point(4, 30);
            tbpVerEmpleados.Name = "tbpVerEmpleados";
            tbpVerEmpleados.Padding = new Padding(3);
            tbpVerEmpleados.Size = new Size(615, 474);
            tbpVerEmpleados.TabIndex = 1;
            tbpVerEmpleados.Text = "Ver Empleados";
            tbpVerEmpleados.UseVisualStyleBackColor = true;
            // 
            // pnlVerEmpleados
            // 
            pnlVerEmpleados.Dock = DockStyle.Fill;
            pnlVerEmpleados.Location = new Point(3, 3);
            pnlVerEmpleados.Name = "pnlVerEmpleados";
            pnlVerEmpleados.Size = new Size(609, 468);
            pnlVerEmpleados.TabIndex = 0;
            // 
            // FormGestorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(splitContainer1);
            Name = "FormGestorEmpleados";
            Text = "FormGestorEmpleados";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tbcEmpleados.ResumeLayout(false);
            tbpIngresarEmpleado.ResumeLayout(false);
            tbpVerEmpleados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Button btnAgregarEmpleado;
        private Label label1;
        private Button btnVerEmpleados;
        private TabControl tbcEmpleados;
        private TabPage tbpIngresarEmpleado;
        private TabPage tbpVerEmpleados;
        private Panel pnlIngresarEmpleado;
        private Panel pnlVerEmpleados;
    }
}