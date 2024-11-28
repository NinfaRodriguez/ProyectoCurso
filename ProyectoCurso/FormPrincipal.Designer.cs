namespace ProyectoCurso
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label1 = new Label();
            label2 = new Label();
            BtnGestorEmpleados = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 93);
            label1.Name = "label1";
            label1.Size = new Size(390, 54);
            label1.TabIndex = 0;
            label1.Text = "VELORA MOTORS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB Demi", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 160);
            label2.Name = "label2";
            label2.Size = new Size(279, 27);
            label2.TabIndex = 1;
            label2.Text = "GESTOR DE EMPLEADOS";
            // 
            // BtnGestorEmpleados
            // 
            BtnGestorEmpleados.BackColor = SystemColors.Control;
            BtnGestorEmpleados.DialogResult = DialogResult.Ignore;
            BtnGestorEmpleados.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGestorEmpleados.Location = new Point(325, 313);
            BtnGestorEmpleados.Name = "BtnGestorEmpleados";
            BtnGestorEmpleados.Size = new Size(200, 111);
            BtnGestorEmpleados.TabIndex = 2;
            BtnGestorEmpleados.Text = "GESTOR DE EMPLEADOS";
            BtnGestorEmpleados.UseVisualStyleBackColor = false;
            BtnGestorEmpleados.Click += GestorEmpleados;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(884, 511);
            Controls.Add(pictureBox1);
            Controls.Add(BtnGestorEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnGestorEmpleados;
        private PictureBox pictureBox1;
    }
}
