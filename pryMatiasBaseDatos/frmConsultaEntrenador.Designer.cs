namespace pryMatiasBaseDatos
{
    partial class frmConsultaEntrenador
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
            this.dtgEntrenadores = new System.Windows.Forms.DataGridView();
            this.clCodigoEntrenadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarEntrenadores = new System.Windows.Forms.Button();
            this.gpConsulta = new System.Windows.Forms.GroupBox();
            this.grpEliminarRegistro = new System.Windows.Forms.GroupBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).BeginInit();
            this.gpConsulta.SuspendLayout();
            this.grpEliminarRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEntrenadores
            // 
            this.dtgEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigoEntrenadores,
            this.clNombre,
            this.clApellido,
            this.clDireccion,
            this.clProvincia,
            this.clDeporte});
            this.dtgEntrenadores.Location = new System.Drawing.Point(19, 29);
            this.dtgEntrenadores.Name = "dtgEntrenadores";
            this.dtgEntrenadores.Size = new System.Drawing.Size(636, 220);
            this.dtgEntrenadores.TabIndex = 1;
            // 
            // clCodigoEntrenadores
            // 
            this.clCodigoEntrenadores.HeaderText = "Codigo Entrenadores";
            this.clCodigoEntrenadores.Name = "clCodigoEntrenadores";
            this.clCodigoEntrenadores.ReadOnly = true;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.Name = "clNombre";
            this.clNombre.ReadOnly = true;
            // 
            // clApellido
            // 
            this.clApellido.HeaderText = "Apellido";
            this.clApellido.Name = "clApellido";
            this.clApellido.ReadOnly = true;
            // 
            // clDireccion
            // 
            this.clDireccion.HeaderText = "Direccion";
            this.clDireccion.Name = "clDireccion";
            this.clDireccion.ReadOnly = true;
            // 
            // clProvincia
            // 
            this.clProvincia.HeaderText = "Provincia";
            this.clProvincia.Name = "clProvincia";
            this.clProvincia.ReadOnly = true;
            // 
            // clDeporte
            // 
            this.clDeporte.HeaderText = "Deporte";
            this.clDeporte.Name = "clDeporte";
            this.clDeporte.ReadOnly = true;
            // 
            // btnListarEntrenadores
            // 
            this.btnListarEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEntrenadores.Location = new System.Drawing.Point(540, 265);
            this.btnListarEntrenadores.Name = "btnListarEntrenadores";
            this.btnListarEntrenadores.Size = new System.Drawing.Size(115, 26);
            this.btnListarEntrenadores.TabIndex = 8;
            this.btnListarEntrenadores.Text = "Listar";
            this.btnListarEntrenadores.UseVisualStyleBackColor = true;
            this.btnListarEntrenadores.Click += new System.EventHandler(this.btnListarEntrenadores_Click);
            // 
            // gpConsulta
            // 
            this.gpConsulta.Controls.Add(this.dtgEntrenadores);
            this.gpConsulta.Controls.Add(this.btnListarEntrenadores);
            this.gpConsulta.Location = new System.Drawing.Point(24, 12);
            this.gpConsulta.Name = "gpConsulta";
            this.gpConsulta.Size = new System.Drawing.Size(673, 310);
            this.gpConsulta.TabIndex = 9;
            this.gpConsulta.TabStop = false;
            this.gpConsulta.Text = "Consulta";
            // 
            // grpEliminarRegistro
            // 
            this.grpEliminarRegistro.Controls.Add(this.txtCodigoEntrenador);
            this.grpEliminarRegistro.Controls.Add(this.lblCodigoEntrenador);
            this.grpEliminarRegistro.Controls.Add(this.btnEliminarRegistro);
            this.grpEliminarRegistro.Location = new System.Drawing.Point(393, 338);
            this.grpEliminarRegistro.Name = "grpEliminarRegistro";
            this.grpEliminarRegistro.Size = new System.Drawing.Size(304, 85);
            this.grpEliminarRegistro.TabIndex = 10;
            this.grpEliminarRegistro.TabStop = false;
            this.grpEliminarRegistro.Text = "Eliminar registro";
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(171, 19);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(115, 20);
            this.txtCodigoEntrenador.TabIndex = 6;
            this.txtCodigoEntrenador.TextChanged += new System.EventHandler(this.txtCodigoEntrenador_TextChanged_1);
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(36, 23);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(119, 16);
            this.lblCodigoEntrenador.TabIndex = 5;
            this.lblCodigoEntrenador.Text = "Codigo entrenador";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Enabled = false;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.Location = new System.Drawing.Point(171, 45);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(115, 26);
            this.btnEliminarRegistro.TabIndex = 4;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click_1);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.grpEliminarRegistro);
            this.Controls.Add(this.gpConsulta);
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta Entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).EndInit();
            this.gpConsulta.ResumeLayout(false);
            this.grpEliminarRegistro.ResumeLayout(false);
            this.grpEliminarRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEntrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigoEntrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeporte;
        private System.Windows.Forms.Button btnListarEntrenadores;
        private System.Windows.Forms.GroupBox gpConsulta;
        private System.Windows.Forms.GroupBox grpEliminarRegistro;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.Button btnEliminarRegistro;
    }
}