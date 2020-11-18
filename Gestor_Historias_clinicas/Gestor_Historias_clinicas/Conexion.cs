using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Historias_clinicas
{
    class Conexion
    {
        SqlConnection connection;
        SqlCommand Command;
        SqlDataReader reader;

        public Conexion()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=HistoriaClinica;Integrated Security=True");
                connection.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Conexion: " + ex.ToString());
            }
        }

        public void insertar(int Ci, string nombre, string Apellidos)
        {
            //string salida = "Si se inserto";

            try
            {
                Command = new SqlCommand("Insert into Paciente(CI, Nombres, Apellidos) values(" + Ci + ", '" + nombre + "', '" + Apellidos + "')",connection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Se inserto los datos");
            }
            catch (Exception ex)
            {
                //salida = "no se conecto: " + ex.ToString();
                MessageBox.Show("Error en Conexion: " + ex.ToString());
            }
            //return salida;
        }
    }
}
