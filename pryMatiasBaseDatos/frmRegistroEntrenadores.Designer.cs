namespace pryMatiasBaseDatos
{
    partial class frmRegistroEntrenadores
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
            this.lblRegistroEntrenadores = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.txtApellidoEntrenador = new System.Windows.Forms.TextBox();
            this.txtDireccionEntrenador = new System.Windows.Forms.TextBox();
            this.txtNombreEntrenador = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.btnRegistroEntrenadores = new System.Windows.Forms.Button();
            this.StatusBDEntrenador = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBDEntrenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroEntrenadores
            // 
            this.lblRegistroEntrenadores.AutoSize = true;
            this.lblRegistroEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroEntrenadores.Location = new System.Drawing.Point(104, 9);
            this.lblRegistroEntrenadores.Name = "lblRegistroEntrenadores";
            this.lblRegistroEntrenadores.Size = new System.Drawing.Size(196, 24);
            this.lblRegistroEntrenadores.TabIndex = 1;
            this.lblRegistroEntrenadores.Text = "Registro entrenadores";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(30, 265);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(72, 20);
            this.lblProvincia.TabIndex = 40;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(32, 312);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(67, 20);
            this.lblDeporte.TabIndex = 39;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(30, 218);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 38;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(30, 171);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 37;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(30, 77);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(141, 20);
            this.lblCodigoEntrenador.TabIndex = 35;
            this.lblCodigoEntrenador.Text = "Codigo entrenador";
            // 
            // txtProvincia
            // 
            this.txtProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(199, 265);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(181, 21);
            this.txtProvincia.TabIndex = 45;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(199, 77);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtCodigoEntrenador.TabIndex = 44;
            this.txtCodigoEntrenador.TextChanged += new System.EventHandler(this.txtCodigoEntrenador_TextChanged);
            // 
            // txtApellidoEntrenador
            // 
            this.txtApellidoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEntrenador.Location = new System.Drawing.Point(199, 171);
            this.txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            this.txtApellidoEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtApellidoEntrenador.TabIndex = 43;
            this.txtApellidoEntrenador.TextChanged += new System.EventHandler(this.txtApellidoEntrenador_TextChanged);
            // 
            // txtDireccionEntrenador
            // 
            this.txtDireccionEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEntrenador.Location = new System.Drawing.Point(199, 218);
            this.txtDireccionEntrenador.Name = "txtDireccionEntrenador";
            this.txtDireccionEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtDireccionEntrenador.TabIndex = 42;
            this.txtDireccionEntrenador.TextChanged += new System.EventHandler(this.txtDireccionEntrenador_TextChanged);
            // 
            // txtNombreEntrenador
            // 
            this.txtNombreEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEntrenador.Location = new System.Drawing.Point(199, 124);
            this.txtNombreEntrenador.Name = "txtNombreEntrenador";
            this.txtNombreEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtNombreEntrenador.TabIndex = 41;
            this.txtNombreEntrenador.TextChanged += new System.EventHandler(this.txtNombreEntrenador_TextChanged);
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "VOLEY"});
            this.lstDeporte.Location = new System.Drawing.Point(199, 314);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(181, 21);
            this.lstDeporte.TabIndex = 46;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // btnRegistroEntrenadores
            // 
            this.btnRegistroEntrenadores.Enabled = false;
            this.btnRegistroEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroEntrenadores.Location = new System.Drawing.Point(245, 358);
            this.btnRegistroEntrenadores.Name = "btnRegistroEntrenadores";
            this.btnRegistroEntrenadores.Size = new System.Drawing.Size(135, 33);
            this.btnRegistroEntrenadores.TabIndex = 47;
            this.btnRegistroEntrenadores.Text = "Registrar";
            this.btnRegistroEntrenadores.UseVisualStyleBackColor = true;
            this.btnRegistroEntrenadores.Click += new System.EventHandler(this.cmdRegistroEntrenadores_Click);
            // 
            // StatusBDEntrenador
            // 
            this.StatusBDEntrenador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.StatusBDEntrenador.Location = new System.Drawing.Point(0, 417);
            this.StatusBDEntrenador.Name = "StatusBDEntrenador";
            this.StatusBDEntrenador.Size = new System.Drawing.Size(407, 22);
            this.StatusBDEntrenador.TabIndex = 48;
            this.StatusBDEntrenador.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusBDEntrenador_ItemClicked);
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
            // frmRegistroEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 439);
            this.Controls.Add(this.StatusBDEntrenador);
            this.Controls.Add(this.btnRegistroEntrenadores);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCodigoEntrenador);
            this.Controls.Add(this.txtApellidoEntrenador);
            this.Controls.Add(this.txtDireccionEntrenador);
            this.Controls.Add(this.txtNombreEntrenador);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoEntrenador);
            this.Controls.Add(this.lblRegistroEntrenadores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRegistroEntrenadores";
            this.Text = "Registro Entrenadores";
            this.Load += new System.EventHandler(this.frmRegistroEntrenadores_Load);
            this.StatusBDEntrenador.ResumeLayout(false);
            this.StatusBDEntrenador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroEntrenadores;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.TextBox txtApellidoEntrenador;
        private System.Windows.Forms.TextBox txtDireccionEntrenador;
        private System.Windows.Forms.TextBox txtNombreEntrenador;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Button btnRegistroEntrenadores;
        private System.Windows.Forms.StatusStrip StatusBDEntrenador;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}