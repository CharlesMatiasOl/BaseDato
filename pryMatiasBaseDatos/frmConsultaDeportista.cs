using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace pryMatiasBaseDatos
{
    public partial class frmConsultaDeportista : Form
    { 
        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeportista;
        OleDbDataReader lectorDeportista;
        public string rutaDeportista = "DEPORTE.accdb"; //vartiables globales 

        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {

        }

        private void btnListarDeportista_Click(object sender, EventArgs e)
        {
            dtgDeportistas.DataSource = null;
            dtgDeportistas.Rows.Clear();
            try
            {
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + rutaDeportista);
                conexionBase.Open(); //Abre la base de datos 

                queQuieroDeportista = new OleDbCommand();
                queQuieroDeportista.Connection = conexionBase;
                queQuieroDeportista.CommandType = CommandType.TableDirect;
                queQuieroDeportista.CommandText = "DEPORTISTA";
                lectorDeportista = queQuieroDeportista.ExecuteReader();

                while (lectorDeportista.Read())
                {
                    dtgDeportistas.Rows.Add(lectorDeportista["Codigo deportista"], lectorDeportista["Nombre"], lectorDeportista["Apellido"], lectorDeportista["Direccion"], lectorDeportista["Edad"], lectorDeportista["Deporte"]);

                }
                lectorDeportista.Close();
                conexionBase.Close();



            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            string codigo = Convert.ToString(txtCodigoDeportista.Text);


            try
            {

                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + rutaDeportista);
                queQuieroDeportista.Connection = conexionBase;
                conexionBase.Open();

                queQuieroDeportista.CommandType = CommandType.Text;
                queQuieroDeportista.CommandText = "DELETE FROM DEPORTISTA " +
                    "WHERE('" + codigo + "'=[CODIGO DEPORTISTA])";
                queQuieroDeportista.ExecuteNonQuery();
                MessageBox.Show("El registro fue eleminado");



            }
            catch (Exception)
            {
                MessageBox.Show("Tu registro no fue elminado");
                //throw;
            }
            conexionBase.Close();

        }

        private void Verificacion()
        {
            if (txtCodigoDeportista.Text != "")
            {
                btnEliminarRegistro.Enabled = true;
            }
            else
            {
                btnEliminarRegistro.Enabled = false;

            }
        }

        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }
    }
}
