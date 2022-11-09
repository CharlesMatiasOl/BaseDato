namespace pryMatiasBaseDatos
{
    partial class frmModificacionDeportista
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoDEportista = new System.Windows.Forms.TextBox();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpDatosEntrenadores = new System.Windows.Forms.GroupBox();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.gpDatosEntrenadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(274, 58);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoDEportista
            // 
            this.txtCodigoDEportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDEportista.Location = new System.Drawing.Point(147, 28);
            this.txtCodigoDEportista.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoDEportista.Name = "txtCodigoDEportista";
            this.txtCodigoDEportista.Size = new System.Drawing.Size(243, 21);
            this.txtCodigoDEportista.TabIndex = 5;
            this.txtCodigoDEportista.TextChanged += new System.EventHandler(this.txtCodigoDEportista_TextChanged);
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Location = new System.Drawing.Point(30, 28);
            this.lblCodigoDeportista.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(103, 15);
            this.lblCodigoDeportista.TabIndex = 4;
            this.lblCodigoDeportista.Text = "Codigo deportista";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(273, 346);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 31);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpDatosEntrenadores
            // 
            this.gpDatosEntrenadores.Controls.Add(this.txtDeporte);
            this.gpDatosEntrenadores.Controls.Add(this.txtTelefono);
            this.gpDatosEntrenadores.Controls.Add(this.txtEdad);
            this.gpDatosEntrenadores.Controls.Add(this.txtDireccion);
            this.gpDatosEntrenadores.Controls.Add(this.lblTelefone);
            this.gpDatosEntrenadores.Controls.Add(this.lblEdad);
            this.gpDatosEntrenadores.Controls.Add(this.lblDeporte);
            this.gpDatosEntrenadores.Controls.Add(this.lblDireccion);
            this.gpDatosEntrenadores.Location = new System.Drawing.Point(34, 100);
            this.gpDatosEntrenadores.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpDatosEntrenadores.Name = "gpDatosEntrenadores";
            this.gpDatosEntrenadores.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpDatosEntrenadores.Size = new System.Drawing.Size(388, 240);
            this.gpDatosEntrenadores.TabIndex = 7;
            this.gpDatosEntrenadores.TabStop = false;
            this.gpDatosEntrenadores.Text = "Datos del deportista";
            // 
            // txtDeporte
            // 
            this.txtDeporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeporte.Location = new System.Drawing.Point(113, 180);
            this.txtDeporte.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(243, 21);
            this.txtDeporte.TabIndex = 4;
            this.txtDeporte.TextChanged += new System.EventHandler(this.txtDeporte_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(113, 137);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 21);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdad.Location = new System.Drawing.Point(113, 85);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(243, 21);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(113, 37);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 21);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(9, 140);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 15);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(9, 88);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(9, 183);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(51, 15);
            this.lblDeporte.TabIndex = 3;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(9, 40);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // frmModificacionDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 395);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpDatosEntrenadores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoDEportista);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmModificacionDeportista";
            this.Text = "Modificacion Deportistas";
            this.Load += new System.EventHandler(this.frmModificacionDeportista_Load);
            this.gpDatosEntrenadores.ResumeLayout(false);
            this.gpDatosEntrenadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoDEportista;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpDatosEntrenadores;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblDireccion;
    }
}