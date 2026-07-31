namespace RegistroDeClientes
{
    partial class Form1
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnRegistrar = new Button();
            lstClientes = new ListBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 162);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(133, 215);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 23);
            txtTelefono.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(133, 265);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(215, 23);
            txtCorreo.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(133, 323);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(215, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(387, 102);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(553, 244);
            lstClientes.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(76, 165);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(74, 218);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(84, 273);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo";
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistro.Location = new Point(76, 60);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(273, 37);
            lblRegistro.TabIndex = 8;
            lblRegistro.Text = "Registro de Clientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 450);
            Controls.Add(lblRegistro);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lstClientes);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Registro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnRegistrar;
        private ListBox lstClientes;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblRegistro;
    }
}
