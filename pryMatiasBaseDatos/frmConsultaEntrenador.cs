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
        public string rutaEntrenador = "DEPORTE.accdb";//Variables globales


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
            {
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + rutaEntrenador); //conexion de la base de datos
                conexionBase.Open(); //abrimos la base de datos

                //utilziaremos los siguientes comandos para traer las tablas
                queQuierodeEntrenador = new OleDbCommand();
                queQuierodeEntrenador.Connection = conexionBase;
                queQuierodeEntrenador.CommandType = CommandType.TableDirect;
                queQuierodeEntrenador.CommandText = "ENTRENADORES"; //le decimos que nos traiga de la base de datos, la tabla de entrenadores
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

        private void txtCodigoEntrenador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}