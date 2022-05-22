using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Tienda
{
    class Conexion
    {
        public string server = "localhost"; //Nombre del Servidor
        public string database = "bdd"; //Nombre de la base de datos SQL
        public string user = "root"; //Nombre de usuario 
        public string password = ""; //Contraseña de Usuario
        public string port = "3306"; // Puerto de MySQL
        public string sslM = "none";

       MySqlConnection databaseConnection = new MySqlConnection();

        public Conexion()
        {
            this.Conectar();
        }

        public void Conectar()
        {
            
            
            if (databaseConnection.State == ConnectionState.Closed) // si el estado de la base de datos está cerrada, hacemos lo siguiente
            {
                databaseConnection.ConnectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
                databaseConnection.Open(); // Abrimos la base de datos
                Console.WriteLine("Conexion Exitosa");
        
            
            
            
            }
        }

        //Seleccionar
        public DataTable getData(string sql) // ***
        
        
        
        
        {
            this.Conectar();// Abrimos Conexion con la base de Datos
            
            DataTable table = new DataTable();
            
            
            
            
            
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, databaseConnection);
            adapter.Fill(table);
            return table;
        }

        //Obtener una fila de la tabla retornada por getData
        public DataRow getRow(string sql) // ***
        {
            DataRow row = null;
            
            if (this.getData(sql).Rows.Count == 0)
            {
                return null;
            }
            row = this.getData(sql).Rows[0];
            return row;
        }

        //Insert, Update, Delete
        public int Query(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, databaseConnection);
            return command.ExecuteNonQuery();
        }

        //Metodo para cargar comboBox
        public void CargarCombo(ComboBox cbo, String sql, String mostrar, String seleccionar)
        {
            this.Conectar();
            DataTable datos = this.getData(sql);

            if (datos.Rows.Count > 0)
            {
                cbo.DataSource = null;
                cbo.DataSource = datos;
                cbo.DisplayMember = mostrar;
                cbo.ValueMember = seleccionar;
            }
            else
            {
                cbo.Text = "No hay registros";
                cbo.SelectedIndex = -1;
            }

        }
    }
}
