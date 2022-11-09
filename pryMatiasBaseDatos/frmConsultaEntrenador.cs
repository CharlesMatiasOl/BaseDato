﻿using System;
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
    public partial class frmConsultaEntrenador : Form
    {
        //Variables globales que utilizaremos

        OleDbConnection conexionBase;
        OleDbCommand queQuierodeEntrenador;
        OleDbDataReader lectorBaseEntrenador;
        public string rutaEntrenador = "DEPORTE.accdb";


        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void frmConsultaEntrenador_Load(object sender, EventArgs e)
        {

        }

        private void btnListarEntrenadores_Click(object sender, EventArgs e)
        {
            dtgEntrenadores.DataSource = null;
            dtgEntrenadores.Rows.Clear();
            try
            {    //abrimos la base de datos
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + rutaEntrenador); //conexion de la base de datos
                conexionBase.Open(); 

                //utilziaremos los comandos para traer las tablas
                queQuierodeEntrenador = new OleDbCommand();
                queQuierodeEntrenador.Connection = conexionBase;
                queQuierodeEntrenador.CommandType = CommandType.TableDirect;
                queQuierodeEntrenador.CommandText = "ENTRENADORES"; //le decimos que nos traiga, la tabla de entrenadores
                lectorBaseEntrenador = queQuierodeEntrenador.ExecuteReader();

                while (lectorBaseEntrenador.Read()) // creamos el while para cargar los objetos en la grilla
                {
                    dtgEntrenadores.Rows.Add(lectorBaseEntrenador["Codigo Deportista"], lectorBaseEntrenador["Nombre"], lectorBaseEntrenador["Apellido"], lectorBaseEntrenador["Direccion"], lectorBaseEntrenador["Provincia"], lectorBaseEntrenador["Deporte"]);
                }

                lectorBaseEntrenador.Close();
                conexionBase.Close();




            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
           
        }

        private void Verificacion()
        {
            if (txtCodigoEntrenador.Text != "")
            {
                btnEliminarRegistro.Enabled = true;
            }
            else
            {
                btnEliminarRegistro.Enabled = false;
            }
        }

        private void txtCodigoEntrenador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarRegistro_Click_1(object sender, EventArgs e)
        {
            string codigo = Convert.ToString(txtCodigoEntrenador.Text);


            try
            {

                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + rutaEntrenador);
                queQuierodeEntrenador.Connection = conexionBase;
                conexionBase.Open();

                queQuierodeEntrenador.CommandType = CommandType.Text;
                queQuierodeEntrenador.CommandText = "DELETE FROM ENTRENADORES " +
                    "WHERE('" + codigo + "'=[CODIGO DEPORTISTA])";
                queQuierodeEntrenador.ExecuteNonQuery();
                MessageBox.Show("El registro fue eleminado");
                txtCodigoEntrenador.Text = "";
                txtCodigoEntrenador.Focus();



            }
            catch (Exception)
            {
                MessageBox.Show("Tu registro no fue elminado");
                //throw;
            }
            conexionBase.Close();

        }

        private void txtCodigoEntrenador_TextChanged_1(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void dtgEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
