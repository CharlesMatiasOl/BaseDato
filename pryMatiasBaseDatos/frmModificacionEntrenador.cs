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
    public partial class frmModificacionEntrenador : Form
    {
        public frmModificacionEntrenador()
        {
            InitializeComponent();
        }

        private void frmModificacionEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoDeEntrenador.Text;
            clsEntrenador Buscar = new clsEntrenador();
            Buscar.Buscar(codigo);
            if (Buscar.codigoEntrenador != codigo)
            {
                MessageBox.Show("No se encuentra el codigo en la base de datos");
            }
            else
            {
                txtDireccion.Text = Buscar.Direccion;
                txtProvincia.Text = Convert.ToString(Buscar.Provincia);
                txtDeporte.Text = Convert.ToString(Buscar.Deportes);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigoEntrenador = txtCodigoDeEntrenador.Text;
            string direccion = txtDireccion.Text;
            string deporte = txtDeporte.Text;
            string provincia = txtProvincia.Text;
            clsEntrenador modificar = new clsEntrenador();
            modificar.Direccion = direccion;
            modificar.Deportes = deporte;
            modificar.Provincia = provincia;
            modificar.Modificar(codigoEntrenador);

            //limpiamos las cajas de texto
            txtCodigoDeEntrenador.Text = "";
            txtDeporte.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            txtCodigoDeEntrenador.Focus();

        }
        private void Verificacion()
        {
            if (txtCodigoDeEntrenador.Text != "" && txtDeporte.Text != "" && txtDireccion.Text != "" && txtProvincia.Text != "")
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtCodigoDeEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }
    }
}
