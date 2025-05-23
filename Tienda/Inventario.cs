﻿using System;
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
    public partial class Inventario : Form
    {
        Conexion conMysql = new Conexion();
        public Inventario()
        {
            InitializeComponent();
        }

        public void addProducto()
        {
            String sql2 = "select CodigoBarra,precioProducto,existenciasProductos from productos where idProducto=" + comboBox1.SelectedValue;
            DataRow fila = conMysql.getRow(sql2);

            String sql3 = (@"select cantidad as Cant_vendidas from detallesfactura inner join productos on detallesfactura.idProductos=productos.idProducto where productos.idProducto=" + comboBox1.SelectedValue);
            DataRow cant_vendidas = conMysql.getRow(sql3);

            if (cant_vendidas != null)
            {
                
                int canVen = (int)cant_vendidas[0];
                var canIni = (int)fila[2];
                int canFinal = canIni - canVen;
                dataGridView1.Rows.Add(comboBox1.SelectedValue, fila[0], comboBox1.Text, fila[1], fila[2], cant_vendidas[0], canFinal);
            }
            else
            {
                MessageBox.Show("No hay ventas de este producto");
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 7;
            dataGridView1.ColumnHeadersVisible = true;


            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "idProducto";
            dataGridView1.Columns[1].Name = "CodigoBarra";
            dataGridView1.Columns[2].Name = "descripcionProducto";
            dataGridView1.Columns[3].Name = "precioProducto";
            dataGridView1.Columns[4].Name = "existenciasProductos";
            dataGridView1.Columns[5].Name = "Cant. Vendidas";
            dataGridView1.Columns[6].Name = "Cant. Final";


            // Set the column header width.
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 120;

            //cargar comboBox
            conMysql.Conectar();
            String sql = "select idProducto,descripcionProducto from productos";
            conMysql.CargarCombo(comboBox1, sql, "descripcionProducto", "idProducto");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProducto();
        }
    }
}
