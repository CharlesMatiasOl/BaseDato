using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMatiasBaseDatos
{
    public partial class frmModificacionDeportista : Form
    {
        public frmModificacionDeportista()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoDEportista.Text;
            clsDeportista Buscar = new clsDeportista();
            Buscar.Buscar(codigo);
            if (Buscar.codigoDeportista != codigo)
            {
                MessageBox.Show("No se encuentra el codigo en la base de datos");
            }
            else
            {
                txtDireccion.Text = Buscar.Direccion;
                txtTelefono.Text = Convert.ToString(Buscar.Telefono);
                txtEdad.Text = Convert.ToString(Buscar.Edad);
                txtDeporte.Text = Convert.ToString(Buscar.Deportes);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string deportistaCodigo = txtCodigoDEportista.Text;
            string direccion = txtDireccion.Text;
            string deporte = txtDeporte.Text;
            Int32 edad = Convert.ToInt32(txtEdad.Text);
            Int32 telefono = Convert.ToInt32(txtTelefono.Text);
            clsDeportista modificar = new clsDeportista();
            modificar.Direccion = direccion;
            modificar.Edad = edad;
            modificar.Deportes = deporte;
            modificar.Telefono = telefono;
            modificar.Modificar(deportistaCodigo);


            //limpiamos cajas de textos
            txtCodigoDEportista.Text = "";
            txtDeporte.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtCodigoDEportista.Focus();

        }

        private void verificacion()
        {
            if (txtCodigoDEportista.Text != "" && txtDeporte.Text != "" && txtDireccion.Text != "" && txtEdad.Text != "" && txtTelefono.Text != "")
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtCodigoDEportista_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void frmModificacionDeportista_Load(object sender, EventArgs e)
        {

        }
    }
}
