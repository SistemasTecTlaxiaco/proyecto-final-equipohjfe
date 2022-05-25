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
    public partial class Ventas : Form
    {
        //instancia la clase conexion
        Conexion conexionBBD = new Conexion();
        DataRow lstProducto = null;

        public Ventas()
        {
            InitializeComponent();
        }

        public void addListView()
        {
            //Agregar producto al listView1
            lstProducto = conexionBBD.getRow("select * from productos where CodigoBarra='" + codigoBarraText.Text + "'");
            Console.WriteLine(lstProducto);


            if (codigoBarraText.Text == null || lstProducto == null)
            {
                MessageBox.Show("EL Producto que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }
            else
            {
                ListViewItem lvItem = new ListViewItem();
                int cantidad = 1;
                float venta = float.Parse((lstProducto[3].ToString()));

                lvItem.SubItems[0].Text = lstProducto[1].ToString();
                lvItem.SubItems.Add(lstProducto[2].ToString());
                lvItem.SubItems.Add(lstProducto[3].ToString());
                lvItem.SubItems.Add(cantidad.ToString());
                lvItem.SubItems.Add((venta * cantidad).ToString());
                lvItem.SubItems.Add(lstProducto[4].ToString());

                listView1.Items.Add(lvItem);
                codigoBarraText.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addListView();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //Propiedades del ListView
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Agregar Descripcion a las Columnas y un tamaño
            listView1.Columns.Add("CodigoBarra", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción del Producto", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Precio Venta", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Cant", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Importe", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Existencias", 120, HorizontalAlignment.Left);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Lector codigo de barras
            if (e.KeyChar == (char)Keys.Enter){
                addListView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.ShowDialog();// Abrir el Foirmulario Productos
        }
    }
}
