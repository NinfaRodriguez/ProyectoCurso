namespace ProyectoCurso
{
    partial class FormVerEmpleados
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerEmpleados));
            dgvEmpleados = new DataGridView();
            tsEditarEliminar = new ToolStrip();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            msEditarEliminar = new MenuStrip();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            editarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            eliminarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            cmsOpcionesEmpleados = new ContextMenuStrip(components);
            EditarEmpleadoToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarEmpleadoToolStripMenuItem1 = new ToolStripMenuItem();
            panelContenedorData = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            tsEditarEliminar.SuspendLayout();
            msEditarEliminar.SuspendLayout();
            cmsOpcionesEmpleados.SuspendLayout();
            panelContenedorData.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.Location = new Point(0, 0);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(800, 401);
            dgvEmpleados.TabIndex = 0;
            // 
            // tsEditarEliminar
            // 
            tsEditarEliminar.Items.AddRange(new ToolStripItem[] { tsbEditar, tsbEliminar });
            tsEditarEliminar.Location = new Point(0, 24);
            tsEditarEliminar.Name = "tsEditarEliminar";
            tsEditarEliminar.Size = new Size(800, 25);
            tsEditarEliminar.TabIndex = 2;
            tsEditarEliminar.Text = "toolStrip1";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(23, 22);
            tsbEditar.Text = "Editar Empleado";
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 22);
            tsbEliminar.Text = "Eliminar Empleado";
            // 
            // msEditarEliminar
            // 
            msEditarEliminar.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem });
            msEditarEliminar.Location = new Point(0, 0);
            msEditarEliminar.Name = "msEditarEliminar";
            msEditarEliminar.Size = new Size(800, 24);
            msEditarEliminar.TabIndex = 3;
            msEditarEliminar.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarEmpleadoToolStripMenuItem, eliminarEmpleadoToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            editarEmpleadoToolStripMenuItem.Image = (Image)resources.GetObject("editarEmpleadoToolStripMenuItem.Image");
            editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            editarEmpleadoToolStripMenuItem.Size = new Size(180, 22);
            editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            eliminarEmpleadoToolStripMenuItem.Image = (Image)resources.GetObject("eliminarEmpleadoToolStripMenuItem.Image");
            eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            eliminarEmpleadoToolStripMenuItem.Size = new Size(180, 22);
            eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            // 
            // cmsOpcionesEmpleados
            // 
            cmsOpcionesEmpleados.Items.AddRange(new ToolStripItem[] { EditarEmpleadoToolStripMenuItem1, eliminarEmpleadoToolStripMenuItem1 });
            cmsOpcionesEmpleados.Name = "contextMenuStrip1";
            cmsOpcionesEmpleados.Size = new Size(174, 48);
            // 
            // EditarEmpleadoToolStripMenuItem1
            // 
            EditarEmpleadoToolStripMenuItem1.Name = "EditarEmpleadoToolStripMenuItem1";
            EditarEmpleadoToolStripMenuItem1.Size = new Size(173, 22);
            EditarEmpleadoToolStripMenuItem1.Text = "Editar Empleado";
            EditarEmpleadoToolStripMenuItem1.Click += EditarEmpleadoStrip;
            // 
            // eliminarEmpleadoToolStripMenuItem1
            // 
            eliminarEmpleadoToolStripMenuItem1.Name = "eliminarEmpleadoToolStripMenuItem1";
            eliminarEmpleadoToolStripMenuItem1.Size = new Size(173, 22);
            eliminarEmpleadoToolStripMenuItem1.Text = "Eliminar Empleado";
            eliminarEmpleadoToolStripMenuItem1.Click += EliminarEmpleadoStrip;
            // 
            // panelContenedorData
            // 
            panelContenedorData.Controls.Add(dgvEmpleados);
            panelContenedorData.Dock = DockStyle.Fill;
            panelContenedorData.Location = new Point(0, 49);
            panelContenedorData.Name = "panelContenedorData";
            panelContenedorData.Size = new Size(800, 401);
            panelContenedorData.TabIndex = 4;
            // 
            // FormVerEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedorData);
            Controls.Add(tsEditarEliminar);
            Controls.Add(msEditarEliminar);
            Name = "FormVerEmpleados";
            Text = "FormVerEmpleados";
            Load += FormVerEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            tsEditarEliminar.ResumeLayout(false);
            tsEditarEliminar.PerformLayout();
            msEditarEliminar.ResumeLayout(false);
            msEditarEliminar.PerformLayout();
            cmsOpcionesEmpleados.ResumeLayout(false);
            panelContenedorData.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private ToolStrip tsEditarEliminar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
        private MenuStrip msEditarEliminar;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private ContextMenuStrip cmsOpcionesEmpleados;
        private ToolStripMenuItem EditarEmpleadoToolStripMenuItem1;
        private ToolStripMenuItem eliminarEmpleadoToolStripMenuItem1;
        private Panel panelContenedorData;
    }
}