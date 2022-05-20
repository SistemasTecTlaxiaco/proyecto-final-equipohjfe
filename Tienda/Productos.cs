using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Productos : Form
    {
        //instancia la clase conexion
        Conexion conMysql = new Conexion();
        DataRow lstProducto = null;

        public Productos()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            textBoxCodigoBarra.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecio.Text = "";
            textBoxExistencias.Text = "";
        }

        /*public void buscar()
        {
            String sql = "select * from productos where id = " + comboBox2.SelectedValue;
            DataRow fila = conMysql.getRow(sql);
            if (fila != null)
            {
                textBox5.Text = fila["codigo"].ToString();
                textBox6.Text = fila["descripcion"].ToString();
                textBox7.Text = fila["valor"].ToString();
                textBox8.Text = fila["cantidad_inicial"].ToString();
                comboBox2.Text = "";
            }
            else
            {
                MessageBox.Show("El producto que buscas no existe");
            }
        }*/

        public void guardar()
        {
            //Comprobar que todos los textBox no esten vacios
            if (textBoxCodigoBarra.Text.Trim() == String.Empty && textBoxDescripcion.Text.Trim() == String.Empty && textBoxPrecio.Text.Trim() == String.Empty
                && textBoxExistencias.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            //Comprobar cada text box que no esten vacios, y si lo estan, mostrar una advertencia
            if (textBoxCodigoBarra.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar un Codigo de Barra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxDescripcion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar una descripción de su producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxPrecio.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar una precio de su producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxExistencias.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar la cantidad de existencias del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //insertar en la tabla productos el CodigoBarra, descripcionProducto, precioProducto, existenciasProductos	

            String sql = String.Format("insert into productos(CodigoBarra,descripcionProducto,precioProducto,existenciasProductos)" +
                          " values('{0}','{1}','{2}','{3}')",
                          textBoxCodigoBarra.Text.Trim(), textBoxDescripcion.Text.Trim(), textBoxPrecio.Text.Trim(), textBoxExistencias.Text.Trim());

            try
            {

                if (conMysql.Query(sql) == 1)
                {
                    MessageBox.Show("Registro de Producto éxitoso");
                }
                else
                {
                    MessageBox.Show("NO se pudo registar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addListView()
        {

            lstProducto = conMysql.getRow("select * from productos where id='" + comboBox1.SelectedValue + "'");

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("EL Producto que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }

            ListViewItem lvItem = new ListViewItem();

            lvItem.SubItems[0].Text = lstProducto[0].ToString();
            lvItem.SubItems.Add(lstProducto[1].ToString());
            lvItem.SubItems.Add(lstProducto[2].ToString());
            lvItem.SubItems.Add(lstProducto[3].ToString());
            lvItem.SubItems.Add(lstProducto[4].ToString());

            listView1.Items.Add(lvItem);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            //Propiedades del ListView
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Columnas
            listView1.Columns.Add("Id", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Código", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Cantidad", 120, HorizontalAlignment.Left);

            //cargar comboBox
            conMysql.Conectar();
            String sql = "select id, descripcion from productos";
            conMysql.CargarCombo(comboBox1, sql, "descripcion", "id");
            conMysql.CargarCombo(comboBox2, sql, "descripcion", "id");
            conMysql.CargarCombo(comboBox3, sql, "descripcion", "id");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            addListView();
        }
    }
}
