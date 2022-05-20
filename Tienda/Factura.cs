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
    public partial class Factura : Form
    {
        Conexion conexionBBD = new Conexion();
        public Factura()
        {
            InitializeComponent();
        }

        public void addProducto()
        {
            String sql3 = "select precioProducto from productos where idProducto = " + comboBoxProducto.SelectedValue;
            DataRow valor_unit = conexionBBD.getRow(sql3);

            int valor_producto = 0;
            int cantidad = int.Parse(textBoxCantidad.Text);
            var v_unit = (int)valor_unit[0];

            valor_producto = v_unit * cantidad;

            dataGridViewTabla.Rows.Add(comboBoxClientes.SelectedValue, comboBoxProducto.SelectedValue, v_unit, cantidad, valor_producto);
        }

        public void totalFactura()
        {
            //Variable donde almacenaremos el resultado de la sumatoria.
            double sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in dataGridViewTabla.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Total_producto"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            textBoxTotal.Text = Convert.ToString(sumatoria);
        }

        public void limpiar()
        {
            textBoxCantidad.Text = "";
            textBoxTotal.Text = "";
            comboBoxClientes.Text = "";
            comboBoxProducto.Text = "";
            dataGridViewTabla.DataSource = "";
        }

        public void guardar()
        {
            if (textBoxCantidad.Text.Trim() == String.Empty && textBoxTotal.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, los campos no pueden estar vacios ...!!!");
                return;
            }

            if (textBoxCantidad.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, el campo cantidad no puede estar vacio ...!!!");
                return;
            }

            if (textBoxTotal.Text.Trim() == String.Empty)
            {
                MessageBox.Show("!!!... Error, el campo total factura no puede estar vacio ...!!!");
                return;
            }

            dateTimePicker1.Value = DateTime.Now;

            String sql = String.Format("insert into factura (fecha,idCliente,valorTotal)" +
                          " values('{0}','{1}','{2}')",
                          dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBoxClientes.SelectedValue, textBoxTotal.Text.Trim());
            try
            {
                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Registro de Factura éxitoso ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataRow busq1 = conexionBBD.getRow("select max(idFactura) from factura");
            String sql2 = String.Format("insert into detallesfactura (idFactura,idProductos,cantidad)" +
                          " values('{0}','{1}','{2}')",
                          busq1[0], comboBoxProducto.SelectedValue, textBoxCantidad.Text.Trim());
            try
            {
                if (conexionBBD.Query(sql2) == 1)
                {
                    MessageBox.Show("!!!... Registro de Factura-Detalle éxitoso \n" +
                                    " Número Factura: " + busq1[0] + "\n" +
                                    " Cliente: " + comboBoxClientes.Text + "\n" +
                                    " Producto: " + comboBoxProducto.Text + "\n" +
                                    " Cantidad: " + textBoxCantidad.Text + "\n" +
                                    " Total Factura: " + textBoxTotal.Text + "\n" +
                                    " ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo registar ...!!!");
                }
                limpiar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Factura_Load(object sender, EventArgs e)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridViewTabla.ColumnCount = 5;
            dataGridViewTabla.ColumnHeadersVisible = true;


            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewTabla.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridViewTabla.Columns[0].Name = "Id_Cliente";
            dataGridViewTabla.Columns[1].Name = "Id_Producto";
            dataGridViewTabla.Columns[2].Name = "Valor_Unit.";
            dataGridViewTabla.Columns[3].Name = "Cant.";
            dataGridViewTabla.Columns[4].Name = "Total_producto";

            // Set the column header width.
            dataGridViewTabla.Columns[0].Width = 80;
            dataGridViewTabla.Columns[1].Width = 90;
            dataGridViewTabla.Columns[2].Width = 120;
            dataGridViewTabla.Columns[3].Width = 60;
            dataGridViewTabla.Columns[4].Width = 140;

            //cargar comboBox
            conexionBBD.Conectar();
            String sql = "select idClientes, nombre from clientes";
            String sql2 = "select idProducto,descripcionProducto from productos";
            conexionBBD.CargarCombo(comboBoxClientes, sql, "nombre", "idClientes");
            conexionBBD.CargarCombo(comboBoxProducto, sql2, "descripcionProducto", "idProducto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProducto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalFactura();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
