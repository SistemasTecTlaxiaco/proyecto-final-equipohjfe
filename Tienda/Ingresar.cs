using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tienda
{
    public partial class Ingresar : Form
    {
        Conexion conectar = new Conexion();//Creamos un Objecto conectar de la clase Conexion
        public string idUsuario;
        public Ingresar()
        {
            InitializeComponent();
            try
            {
                conectar.Conectar();// Llamamos al metodo Conectar() de la clase Conexion que hace la coneccion con la base de datos.
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void IngresarForm()
        {
            //Seleccionamos el Usuario y Contraseña de la tabla usuarios, donde Usuario = textBoxUsuario y Contraseña = textBoxContraseña
            String sql1 = String.Format(@"select Usuario,Contraseña from usuarios where Usuario='" + comboBoxUsuario.Text + "' and Contraseña='" + textBoxContraseña.Text + "'");
            DataRow fila = conectar.getRow(sql1);// ***
            if (fila != null)// ***
            {
                MessageBox.Show("Bienvenido: " + comboBoxUsuario.Text);
                MenuPrincipal abrir = new MenuPrincipal();
                abrir.nombre.Text = comboBoxUsuario.Text;
                abrir.idUsuario = comboBoxUsuario.SelectedValue.ToString();
                abrir.Show(); // Abrimos el Formulario MenuPrincipal
                this.Hide(); // Cerramos el actual
                Console.WriteLine("Id_usuario: "+idUsuario);
                //cobrar(comboBoxUsuario);
            }

            else
            {
                MessageBox.Show("Error, usuario y/o contraseña incorrectos");
            }
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            IngresarForm();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            //cargar todos los comboBox con la descripcion de productos
            conectar.Conectar();
            String sql = "select idUsuario, Usuario from usuarios";
            //idUsuario = sql;
            conectar.CargarCombo(comboBoxUsuario, sql, "Usuario", "idUsuario");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresarForm();
            }
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
