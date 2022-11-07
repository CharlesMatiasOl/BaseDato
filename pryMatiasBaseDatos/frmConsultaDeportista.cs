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

        private void cmdListarDeportista_Click(object sender, EventArgs e)
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

    }
}
