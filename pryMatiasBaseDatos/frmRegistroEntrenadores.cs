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
    public partial class frmRegistroEntrenadores : Form
    {
        public OleDbConnection conexionBD; //declaracion de conexion de BD
        public OleDbCommand comandoBD;//representa una instruccion 
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";//declaracion de la ruta donde esta alojada la BD

        public frmRegistroEntrenadores()
        {
            InitializeComponent();
        }

        private void StatusBDEntrenador_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmRegistroEntrenadores_Load(object sender, EventArgs e)
        {
            try
            {
                StatusBDEntrenador.BackColor = Color.Green;
            }
            catch (Exception barraColor)
            {
                StatusBDEntrenador.BackColor = Color.Red;
                //throw;
            }
        }

        private void cmdRegistroEntrenadores_Click(object sender, EventArgs e)
        {
            
            string IdEntrenadores = txtCodigoEntrenador.Text; //declaracion de variables grabar
            string NombreEntrenador = txtNombreEntrenador.Text;
            string ApellidoEntrenador = txtApellidoEntrenador.Text;
            string DireccionEntrenador = Convert.ToString(txtDireccionEntrenador.Text);
            string ProvinciaEntrenador = txtProvincia.Text;
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);

            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = " INSERT INTO " + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                        " VALUES ('" + IdEntrenadores + "','" + NombreEntrenador + "','" + ApellidoEntrenador + "','" + DireccionEntrenador + "','" + ProvinciaEntrenador + "','" + Deporte + "')";

                comandoBD.ExecuteNonQuery();//numero de filas afectadas
                MessageBox.Show("Tus datos fueron ingresados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Tus datos  NO fueron ingresados con exito");
                //throw;
            }
            //luego de grabar debemos limpiar las cajas de textos
            txtApellidoEntrenador.Text = "";
            txtCodigoEntrenador.Text = "";
            txtDireccionEntrenador.Text = "";
            txtNombreEntrenador.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedItem = -1;
            txtCodigoEntrenador.Focus();
            lstDeporte.SelectedItem = "";



        }

        private void Verificacion()
        {
            if (txtApellidoEntrenador.Text != "" && txtCodigoEntrenador.Text != "" && txtDireccionEntrenador.Text != "" && txtNombreEntrenador.Text != "" && txtProvincia.Text != "" && lstDeporte.SelectedIndex >= 0)
            {
                btnRegistroEntrenadores.Enabled = true;
            }
            else
            {
                btnRegistroEntrenadores.Enabled = false;
            }
       
        }

        private void txtCodigoEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtNombreEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtApellidoEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDireccionEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verificacion();
        }
    }
}
