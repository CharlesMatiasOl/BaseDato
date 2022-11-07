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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarDeportista = new System.Windows.Forms.Button();
            this.grpEliminarRegistro = new System.Windows.Forms.GroupBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdEliminarRegistro = new System.Windows.Forms.Button();
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
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgDeportistas.Location = new System.Drawing.Point(16, 19);
            this.dtgDeportistas.Name = "dtgDeportistas";
            this.dtgDeportistas.Size = new System.Drawing.Size(643, 220);
            this.dtgDeportistas.TabIndex = 2;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edad ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Deporte";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.grpEliminarRegistro.Controls.Add(this.label1);
            this.grpEliminarRegistro.Controls.Add(this.cmdEliminarRegistro);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo  deportista";
            // 
            // cmdEliminarRegistro
            // 
            this.cmdEliminarRegistro.Enabled = false;
            this.cmdEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarRegistro.Location = new System.Drawing.Point(166, 45);
            this.cmdEliminarRegistro.Name = "cmdEliminarRegistro";
            this.cmdEliminarRegistro.Size = new System.Drawing.Size(121, 26);
            this.cmdEliminarRegistro.TabIndex = 4;
            this.cmdEliminarRegistro.Text = "Eliminar";
            this.cmdEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 429);
            this.Controls.Add(this.grpEliminarRegistro);
            this.Controls.Add(this.grpConsultas);
            this.Name = "frmConsultaDeportista";
            this.Text = "frmConsultaDeportista";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnListarDeportista;
        private System.Windows.Forms.GroupBox grpEliminarRegistro;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdEliminarRegistro;
    }
}