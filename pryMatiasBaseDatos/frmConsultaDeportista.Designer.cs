namespace pryMatiasBaseDatos
{
    partial class frmConsultaDeportista
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
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.dtgDeportistas = new System.Windows.Forms.DataGridView();
            this.clDeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarDeportista = new System.Windows.Forms.Button();
            this.grpEliminarRegistro = new System.Windows.Forms.GroupBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.lblCodigodeportista = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.grpConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeportistas)).BeginInit();
            this.grpEliminarRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsultas
            // 
            this.grpConsultas.Controls.Add(this.dtgDeportistas);
            this.grpConsultas.Controls.Add(this.btnListarDeportista);
            this.grpConsultas.Location = new System.Drawing.Point(12, 12);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Size = new System.Drawing.Size(676, 302);
            this.grpConsultas.TabIndex = 5;
            this.grpConsultas.TabStop = false;
            this.grpConsultas.Text = "Consulta";
            // 
            // dtgDeportistas
            // 
            this.dtgDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDeporte,
            this.clCodigo,
            this.clNombre,
            this.clApellido,
            this.clDireccion,
            this.clEdad});
            this.dtgDeportistas.Location = new System.Drawing.Point(16, 19);
            this.dtgDeportistas.Name = "dtgDeportistas";
            this.dtgDeportistas.Size = new System.Drawing.Size(643, 220);
            this.dtgDeportistas.TabIndex = 2;
            // 
            // clDeporte
            // 
            this.clDeporte.HeaderText = "Codigo";
            this.clDeporte.Name = "clDeporte";
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Nombre";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Apellido";
            this.clNombre.Name = "clNombre";
            this.clNombre.ReadOnly = true;
            // 
            // clApellido
            // 
            this.clApellido.HeaderText = "Direccion";
            this.clApellido.Name = "clApellido";
            this.clApellido.ReadOnly = true;
            // 
            // clDireccion
            // 
            this.clDireccion.HeaderText = "Edad ";
            this.clDireccion.Name = "clDireccion";
            this.clDireccion.ReadOnly = true;
            // 
            // clEdad
            // 
            this.clEdad.HeaderText = "Deporte";
            this.clEdad.Name = "clEdad";
            this.clEdad.ReadOnly = true;
            // 
            // btnListarDeportista
            // 
            this.btnListarDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDeportista.Location = new System.Drawing.Point(538, 255);
            this.btnListarDeportista.Name = "btnListarDeportista";
            this.btnListarDeportista.Size = new System.Drawing.Size(121, 27);
            this.btnListarDeportista.TabIndex = 3;
            this.btnListarDeportista.Text = "Listar";
            this.btnListarDeportista.UseVisualStyleBackColor = true;
            this.btnListarDeportista.Click += new System.EventHandler(this.cmdListarDeportista_Click);
            // 
            // grpEliminarRegistro
            // 
            this.grpEliminarRegistro.Controls.Add(this.txtCodigoDeportista);
            this.grpEliminarRegistro.Controls.Add(this.lblCodigodeportista);
            this.grpEliminarRegistro.Controls.Add(this.btnEliminarRegistro);
            this.grpEliminarRegistro.Location = new System.Drawing.Point(384, 332);
            this.grpEliminarRegistro.Name = "grpEliminarRegistro";
            this.grpEliminarRegistro.Size = new System.Drawing.Size(304, 85);
            this.grpEliminarRegistro.TabIndex = 6;
            this.grpEliminarRegistro.TabStop = false;
            this.grpEliminarRegistro.Text = "Eliminar registro";
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDeportista.Location = new System.Drawing.Point(166, 19);
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoDeportista.TabIndex = 6;
            this.txtCodigoDeportista.TextChanged += new System.EventHandler(this.txtCodigoDeportista_TextChanged);
            // 
            // lblCodigodeportista
            // 
            this.lblCodigodeportista.AutoSize = true;
            this.lblCodigodeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigodeportista.Location = new System.Drawing.Point(36, 23);
            this.lblCodigodeportista.Name = "lblCodigodeportista";
            this.lblCodigodeportista.Size = new System.Drawing.Size(114, 16);
            this.lblCodigodeportista.TabIndex = 5;
            this.lblCodigodeportista.Text = "Codigo deportista";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Enabled = false;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.Location = new System.Drawing.Point(166, 45);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(121, 26);
            this.btnEliminarRegistro.TabIndex = 4;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 429);
            this.Controls.Add(this.grpEliminarRegistro);
            this.Controls.Add(this.grpConsultas);
            this.Name = "frmConsultaDeportista";
            this.Text = "Consulta Deportistas";
            this.Load += new System.EventHandler(this.frmConsultaDeportista_Load);
            this.grpConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeportistas)).EndInit();
            this.grpEliminarRegistro.ResumeLayout(false);
            this.grpEliminarRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultas;
        private System.Windows.Forms.DataGridView dtgDeportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEdad;
        private System.Windows.Forms.Button btnListarDeportista;
        private System.Windows.Forms.GroupBox grpEliminarRegistro;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.Label lblCodigodeportista;
        private System.Windows.Forms.Button btnEliminarRegistro;
    }
}