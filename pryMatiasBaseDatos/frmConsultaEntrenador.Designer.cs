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
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).BeginInit();
            this.gpConsulta.SuspendLayout();
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
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 360);
            this.Controls.Add(this.gpConsulta);
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta Entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).EndInit();
            this.gpConsulta.ResumeLayout(false);
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
    }
}