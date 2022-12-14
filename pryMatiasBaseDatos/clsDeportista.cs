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
    internal class clsDeportista
    {
        //Realizo las distintas conexiones en la base
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adapatador = new OleDbDataAdapter();
        
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";//Ruta para base de datos a utilizar
        private string Tabla = "DEPORTISTA";
        private string codigoDEPORTISTA;
        private string nombre;
        private string apellido;
        private string direccion;
        private Int32 telefono;
        private Int32 edad;
        private string deporte;

        public string codigoDeportista
        {
            get { return codigoDEPORTISTA; }
            set { codigoDEPORTISTA = value; }
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
        public Int32 Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public Int32 Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Deportes
        {
            get { return deporte; }
            set { deporte = value; }
        }

        
        public void Buscar(string codigo)
        {
            try
            {
                conexion.ConnectionString = Ruta;
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
                            codigoDEPORTISTA = DR.GetString(0);
                            nombre = DR.GetString(1);
                            apellido = DR.GetString(2);
                            direccion = DR.GetString(3);
                            telefono = Int32.Parse(DR.GetString(4));
                            edad = DR.GetInt32(5);
                            deporte = DR.GetString(6);

                        }
                    }
                }

                conexion.Close();



            }
            catch (Exception)
            {


            }
        }

        public void Modificar(string codigoDeportista)
        {
            try
            {
                //usaremos sentencias de SQL
                string Sql = "UPDATE DEPORTISTA SET DIRECCION= '" + Direccion + "', TELEFONO=" + Telefono + ", EDAD=" + Edad + ", DEPORTE='" + Deportes + "' WHERE [CODIGO DEPORTISTA] = '" + codigoDeportista + "'";
                //Conecto la base de datos
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
