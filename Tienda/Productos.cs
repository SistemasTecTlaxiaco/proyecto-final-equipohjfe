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
    public partial class Productos : Form
    {
        //instancia la clase conexion
        Conexion conexionBBD = new Conexion();
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

            textBoxCodigoEditar.Text = "";
            textBoxDescripcionEditar.Text = "";
            textBoxValorEditar.Text = "";
            textBoxCantidadEditar.Text = "";

            comboBoxConsultarEditar.Text = "";
            comboBoxProductosConsulta.Text = "";
            comboBoxEliminar.Text = "";

            listViewProductos.Clear();

        }

        public void buscar()
        {
            String sql = "select * from productos where idProducto = " + comboBoxConsultarEditar.SelectedValue;
            DataRow fila = conexionBBD.getRow(sql);
            if (fila != null)
            {
                textBoxCodigoEditar.Text = fila["CodigoBarra"].ToString();
                textBoxDescripcionEditar.Text = fila["descripcionProducto"].ToString();
                textBoxValorEditar.Text = fila["precioProducto"].ToString();
                textBoxCantidadEditar.Text = fila["existenciasProductos"].ToString();
                comboBoxConsultarEditar.Text = "";
            }
            else
            {
                MessageBox.Show("El producto que buscas no existe");
            }
        }

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

                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("Registro de Producto éxitoso");
                }
                else
                {
                    MessageBox.Show("NO se pudo registar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addListView()
        {
            //Agregar producto al listView1

            lstProducto = conexionBBD.getRow("select * from productos where idProducto='" + comboBoxProductosConsulta.SelectedValue + "'");

            if (comboBoxProductosConsulta.SelectedValue == null)
            {
                MessageBox.Show("EL Producto que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }

            ListViewItem lvItem = new ListViewItem();

            lvItem.SubItems[0].Text = lstProducto[0].ToString();
            lvItem.SubItems.Add(lstProducto[1].ToString());
            lvItem.SubItems.Add(lstProducto[2].ToString());
            lvItem.SubItems.Add(lstProducto[3].ToString());
            lvItem.SubItems.Add(lstProducto[4].ToString());

            listViewProductos.Items.Add(lvItem);

        }

        public void editar()
        {
            String sql = String.Format("update productos set CodigoBarra='{0}', descripcionProducto='{1}', precioProducto='{2}', existenciasProductos='{3}' where idProducto='{4}'",
                          textBoxCodigoEditar.Text.Trim(), textBoxDescripcionEditar.Text.Trim(), textBoxValorEditar.Text.Trim(), textBoxCantidadEditar.Text.Trim(), comboBoxConsultarEditar.SelectedValue);
            try
            {

                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Edicion de Producto éxitosa ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, NO se pudo editar ...!!!");
                }

                Limpiar();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void eliminar()
        {
            String sql = String.Format("delete from productos where idProducto= '{0}'", comboBoxEliminar.SelectedValue);

            if (MessageBox.Show("Seguro que deseas eliminar este Producto?", "Eliminar Producto",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                try
                {
                    if (conexionBBD.Query(sql) == 1)
                    {
                        MessageBox.Show("!!!... Producto Eliminado con éxito ...!!!");
                    }
                    else
                    {
                        MessageBox.Show("!!!... ERROR, NO se pudo eliminar ...!!!");
                    }

                    Limpiar();
                    conexionBBD.CargarCombo(comboBoxEliminar, sql, "descripcionProducto", "idProducto");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //Evento al cargar Formulario Productos
        private void Productos_Load(object sender, EventArgs e)
        {
            //Propiedades del ListView
            listViewProductos.View = View.Details;
            listViewProductos.GridLines = true;
            listViewProductos.FullRowSelect = true;

            //Agregar Descripcion a las Columnas y un tamaño
            listViewProductos.Columns.Add("id", 30, HorizontalAlignment.Left);
            listViewProductos.Columns.Add("CodigoBarra", 70, HorizontalAlignment.Left);
            listViewProductos.Columns.Add("Descripcion", 150, HorizontalAlignment.Left);
            listViewProductos.Columns.Add("Precio", 120, HorizontalAlignment.Left);
            listViewProductos.Columns.Add("Existencias", 120, HorizontalAlignment.Left);

            //cargar todos los comboBox con la descripcion de productos
            conexionBBD.Conectar();
            String sql = "select idProducto, descripcionProducto from productos";
            conexionBBD.CargarCombo(comboBoxProductosConsulta, sql, "descripcionProducto", "idProducto");
            conexionBBD.CargarCombo(comboBoxEliminar, sql, "descripcionProducto", "idProducto");
            conexionBBD.CargarCombo(comboBoxConsultarEditar, sql, "descripcionProducto", "idProducto");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            addListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void comboBoxProductosConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Lector codigo de barras
            if (e.KeyChar == (char)Keys.Enter)
            {
                
            }
        }

        private void textBoxCodigoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Lector codigo de barras
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
    }
}
