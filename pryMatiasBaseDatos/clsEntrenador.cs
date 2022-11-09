using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace pryMatiasBaseDatos
{
    internal class clsEntrenador
    {
       
        
        private OleDbConnection conexion = new OleDbConnection(); //conexion con la base de datos
        private OleDbCommand comando = new OleDbCommand();//mandar un comando para la base
        private OleDbDataAdapter adapatador = new OleDbDataAdapter();//Adapta los datos de la base
       
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb"; //Ruta para base de datos a utilizar
        private string Tabla = "ENTRENADORES";
        private string codigoEntrenadores;
        private string nombre;
        private string apellido;
        private string direccion;
        private string provincia;
        private string deporte;

        public string codigoEntrenador//retorna el valor de la variable adentro 
        {
            get { return codigoEntrenadores; }
            set { codigoEntrenadores = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        public string Deportes
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public void Buscar(string codigo)
        {
            try//caso tenga alguna cosa mala 
            {
                conexion.ConnectionString = Ruta;//Busco en la base los datos 
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                if (DR.HasRows)//pregunta si hay registros
                {
                    while (DR.Read())
                    {
                        if (DR.GetString(0) == codigo)
                        {
                            codigoEntrenador = DR.GetString(0);
                            nombre = DR.GetString(1);
                            apellido = DR.GetString(2);
                            direccion = DR.GetString(3);
                            provincia = DR.GetString(4);
                            deporte = DR.GetString(5);

                        }
                    }
                }

                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }
        }

        public void Modificar(string codigoEntrenador)
        {
            try
            {
                //usaremos sentencias de SQL
                string Sql = "UPDATE ENTRENADORES SET DIRECCION= '" + Direccion + "', PROVINCIA='" + Provincia + "', DEPORTE='" + Deportes + "' WHERE [CODIGO DEPORTISTA] = '" + codigoEntrenador + "'";
                
                conexion.ConnectionString = Ruta;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();


                MessageBox.Show("Tu registro se pudo modificar");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu registro no se pudo modificar");

            }



        }


    }


}

