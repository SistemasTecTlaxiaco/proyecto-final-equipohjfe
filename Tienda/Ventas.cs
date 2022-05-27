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
        public string idUsuario;

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
            MostrarTotal();
        }
        public void Clean()
        {
            listView1.Clear();
            label2.Text = "0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addListView();
        }

        public void MostrarTotal()
        {
            //Mostrar total
            Double dblSuma = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                dblSuma += Convert.ToDouble(item.SubItems[4].Text);
            }
            label2.Text = dblSuma.ToString();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            //Propiedades del ListView
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Agregar Descripcion a las Columnas y un tamaño
            listView1.Columns.Add("CodigoBarra", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción del Producto", 280, HorizontalAlignment.Left);
            listView1.Columns.Add("Precio Venta", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Cantidad", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Importe", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Existencias", 90, HorizontalAlignment.Left);

            //cargar todos los comboBox con la descripcion de productos
            conexionBBD.Conectar();
            String sql = "select idClientes, nombre from clientes";
            conexionBBD.CargarCombo(comboBoxClientes, sql, "nombre", "idClientes");

            //String sql2 = "select idUsuario, Usuario from usuarios";
            //conexionBBD.CargarCombo(IDlabel, sql2, "Usuario", "idUsuario");
            IDlabel.Text = idUsuario;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Lector codigo de barras
            if (e.KeyChar == (char)Keys.Enter) {
                addListView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.ShowDialog();// Abrir el Foirmulario Productos
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                var message = MessageBox.Show(
                    "Desea eliminar los elementos seleccionados?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (message == DialogResult.Yes)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                        {
                            listView1.Items[i].Remove();
                            i--;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes sellecionar al menos un elemento", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cobrar cobrar = new Cobrar();
            cobrar.Cliente = comboBoxClientes.SelectedValue.ToString();
            Console.WriteLine("clienteSelect " + comboBoxClientes.Text);//Obtener el id
            cobrar.Usuario = idUsuario;
            cobrar.clienteNombre = comboBoxClientes.Text;
            cobrar.NombreUsuario = nombre2.Text;
            cobrar.label1.Text = label2.Text;
            cobrar.ShowDialog();// Abrir el Foirmulario Productos
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
