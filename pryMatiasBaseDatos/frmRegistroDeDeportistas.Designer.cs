namespace pryMatiasBaseDatos
{
    partial class frmRegistroDeDeportistas
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
            this.lblRegistroDeportista = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.StatusBDdeportista = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtEdad = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.txtApellidoDeportista = new System.Windows.Forms.TextBox();
            this.txtDireccionDeportista = new System.Windows.Forms.TextBox();
            this.txtNombreDeportista = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.btnRegistroDeportistas = new System.Windows.Forms.Button();
            this.StatusBDdeportista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroDeportista
            // 
            this.lblRegistroDeportista.AutoSize = true;
            this.lblRegistroDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeportista.Location = new System.Drawing.Point(124, 9);
            this.lblRegistroDeportista.Name = "lblRegistroDeportista";
            this.lblRegistroDeportista.Size = new System.Drawing.Size(165, 24);
            this.lblRegistroDeportista.TabIndex = 0;
            this.lblRegistroDeportista.Text = "Registro deportista";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(31, 342);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(67, 20);
            this.lblDeporte.TabIndex = 13;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(31, 297);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(31, 252);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(71, 20);
            this.lbltelefono.TabIndex = 11;
            this.lbltelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(31, 207);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(31, 162);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 117);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportista.Location = new System.Drawing.Point(31, 72);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(134, 20);
            this.lblCodigoDeportista.TabIndex = 7;
            this.lblCodigoDeportista.Text = "Codigo deportista";
            this.lblCodigoDeportista.Click += new System.EventHandler(this.label8_Click);
            // 
            // StatusBDdeportista
            // 
            this.StatusBDdeportista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.StatusBDdeportista.Location = new System.Drawing.Point(0, 447);
            this.StatusBDdeportista.Name = "StatusBDdeportista";
            this.StatusBDdeportista.Size = new System.Drawing.Size(417, 22);
            this.StatusBDdeportista.TabIndex = 19;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(211, 297);
            this.txtEdad.Mask = "99";
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(181, 21);
            this.txtEdad.TabIndex = 27;
            this.txtEdad.ValidatingType = typeof(int);
            this.txtEdad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskEdad_MaskInputRejected);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(211, 252);
            this.txtTelefono.Mask = "99999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 21);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.ValidatingType = typeof(int);
            this.txtTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeportista.Location = new System.Drawing.Point(211, 71);
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.Size = new System.Drawing.Size(181, 21);
            this.txtCodigoDeportista.TabIndex = 25;
            this.txtCodigoDeportista.TextChanged += new System.EventHandler(this.txtCodigoDeportista_TextChanged);
            // 
            // txtApellidoDeportista
            // 
            this.txtApellidoDeportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDeportista.Location = new System.Drawing.Point(211, 162);
            this.txtApellidoDeportista.Name = "txtApellidoDeportista";
            this.txtApellidoDeportista.Size = new System.Drawing.Size(181, 21);
            this.txtApellidoDeportista.TabIndex = 24;
            this.txtApellidoDeportista.TextChanged += new System.EventHandler(this.txtApellidoDeportista_TextChanged);
            // 
            // txtDireccionDeportista
            // 
            this.txtDireccionDeportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionDeportista.Location = new System.Drawing.Point(211, 207);
            this.txtDireccionDeportista.Name = "txtDireccionDeportista";
            this.txtDireccionDeportista.Size = new System.Drawing.Size(181, 21);
            this.txtDireccionDeportista.TabIndex = 23;
            this.txtDireccionDeportista.TextChanged += new System.EventHandler(this.txtDireccionDeportista_TextChanged);
            // 
            // txtNombreDeportista
            // 
            this.txtNombreDeportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeportista.Location = new System.Drawing.Point(211, 117);
            this.txtNombreDeportista.Name = "txtNombreDeportista";
            this.txtNombreDeportista.Size = new System.Drawing.Size(181, 21);
            this.txtNombreDeportista.TabIndex = 22;
            this.txtNombreDeportista.TextChanged += new System.EventHandler(this.txtNombreDeportista_TextChanged);
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "VOLEY"});
            this.lstDeporte.Location = new System.Drawing.Point(211, 341);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(181, 23);
            this.lstDeporte.TabIndex = 21;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // btnRegistroDeportistas
            // 
            this.btnRegistroDeportistas.Enabled = false;
            this.btnRegistroDeportistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeportistas.Location = new System.Drawing.Point(257, 389);
            this.btnRegistroDeportistas.Name = "btnRegistroDeportistas";
            this.btnRegistroDeportistas.Size = new System.Drawing.Size(135, 33);
            this.btnRegistroDeportistas.TabIndex = 28;
            this.btnRegistroDeportistas.Text = "Registrar";
            this.btnRegistroDeportistas.UseVisualStyleBackColor = true;
            this.btnRegistroDeportistas.Click += new System.EventHandler(this.btnRegistroDeportistas_Click);
            // 
            // frmRegistroDeDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 469);
            this.Controls.Add(this.btnRegistroDeportistas);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCodigoDeportista);
            this.Controls.Add(this.txtApellidoDeportista);
            this.Controls.Add(this.txtDireccionDeportista);
            this.Controls.Add(this.txtNombreDeportista);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.StatusBDdeportista);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Controls.Add(this.lblRegistroDeportista);
            this.Name = "frmRegistroDeDeportistas";
            this.Text = "Registro Deportistas";
            this.Load += new System.EventHandler(this.frmRegistroDeDeportistas_Load);
            this.StatusBDdeportista.ResumeLayout(false);
            this.StatusBDdeportista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroDeportista;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.StatusStrip StatusBDdeportista;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.MaskedTextBox txtEdad;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.TextBox txtApellidoDeportista;
        private System.Windows.Forms.TextBox txtDireccionDeportista;
        private System.Windows.Forms.TextBox txtNombreDeportista;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Button btnRegistroDeportistas;
    }
}