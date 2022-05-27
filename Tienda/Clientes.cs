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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        //instancia la clase conexion
        Conexion conexionBBD = new Conexion();
        DataRow lstclientes = null;

        public void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtCedulaEditar.Text = "";
            txtNombreEditar.Text = "";
            txtDireccionEditar.Text = "";
            txtTelefonoEditar.Text = "";

            comboBoxConsultarEditar.Text = "";
            CboxClienteConsulta.Text = "";
            comboBoxEliminar.Text = "";

            listViewClientes.Clear();
            
        }

        public void buscar()
        {
            String sql = "select * from clientes where idClientes = " + comboBoxConsultarEditar.SelectedValue;
            DataRow fila = conexionBBD.getRow(sql);
            if (fila != null)
            {
                txtCedulaEditar.Text = fila["cedula"].ToString();
                txtNombreEditar.Text = fila["nombre"].ToString();
                txtDireccionEditar.Text = fila["direccion"].ToString();
                txtTelefonoEditar.Text = fila["telefono"].ToString();
                txtCorreoEditar.Text = fila["correo"].ToString();
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
            if (txtCedula.Text.Trim() == String.Empty && txtNombre.Text.Trim() == String.Empty && txtDireccion.Text.Trim() == String.Empty
                && txtTelefono.Text.Trim() == String.Empty && txtCorreo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Comprobar cada text box que no esten vacios, y si lo estan, mostrar una advertencia
            if (txtCedula.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar la cédla del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDireccion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar la dirección del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefono.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el número de telefono cel cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCorreo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el correo electrónico cel cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //insertar en la tabla clientes la cédula, nombre, Dirección, Teléfono y Correo del cliente	

            String sql = String.Format("insert into clientes(cedula,nombre,direccion,telefono,correo)" +
                          " values('{0}','{1}','{2}','{3}', '{4}')",
                          txtCedula.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim());

            try
            {

                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("Registro del Cliente éxitoso");
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

            lstclientes = conexionBBD.getRow("select * from clientes where idClientes='" + CboxClienteConsulta.SelectedValue + "'");

            if (CboxClienteConsulta.SelectedValue == null)
            {
                MessageBox.Show("EL Cliente que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }

            ListViewItem lvcliente = new ListViewItem();

            lvcliente.SubItems[0].Text = lstclientes[0].ToString();
            lvcliente.SubItems.Add(lstclientes[1].ToString());
            lvcliente.SubItems.Add(lstclientes[2].ToString());
            lvcliente.SubItems.Add(lstclientes[3].ToString());
            lvcliente.SubItems.Add(lstclientes[4].ToString());
            lvcliente.SubItems.Add(lstclientes[5].ToString());

            listViewClientes.Items.Add(lvcliente);

        }

        public void editar()
        {
            String sql = String.Format("update clientes set cedula='{0}', nombre='{1}', direccion='{2}', telefono='{3}', correo='{4}' where idProducto='{4}'",
                          txtCedulaEditar.Text.Trim(), txtNombreEditar.Text.Trim(), txtDireccionEditar.Text.Trim(), txtTelefonoEditar.Text.Trim(), comboBoxConsultarEditar.SelectedValue);
            try
            {

                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Edicion de la información del Cliente éxitosa ...!!!");
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
            String sql = String.Format("delete from clientes where idClientes= '{0}'", comboBoxEliminar.SelectedValue);

            if (MessageBox.Show("Seguro que deseas eliminar este Cliente?", "Eliminar Cliente",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                try
                {
                    if (conexionBBD.Query(sql) == 1)
                    {
                        MessageBox.Show("!!!... Cliente Eliminado con éxito ...!!!");
                    }
                    else
                    {
                        MessageBox.Show("!!!... ERROR, NO se pudo eliminar ...!!!");
                    }

                    Limpiar();
                    conexionBBD.CargarCombo(comboBoxEliminar, sql, "", "idProducto");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }



        private void Clientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            // Propiedades del ListView
            listViewClientes.View = View.Details;
            listViewClientes.GridLines = true;
            listViewClientes.FullRowSelect = true;

            //Agregar Descripcion a las Columnas y un tamaño
            listViewClientes.Columns.Add("id", 30, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Cedula", 70, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Direccion", 120, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Telefono", 120, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Correo", 120, HorizontalAlignment.Left);

            //cargar todos los comboBox con la descripcion de productos
            conexionBBD.Conectar();
            String sql = "select idClientes, nombre from clientes";
            conexionBBD.CargarCombo(CboxClienteConsulta, sql, "nombre", "idClientes");
            conexionBBD.CargarCombo(comboBoxEliminar, sql, "nombre", "idClientes");
            conexionBBD.CargarCombo(comboBoxConsultarEditar, sql, "nombre", "idClientes");
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxClienteConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            addListView();
        }

        private void comboBoxConsultarEditar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar();
        }
    }
}
