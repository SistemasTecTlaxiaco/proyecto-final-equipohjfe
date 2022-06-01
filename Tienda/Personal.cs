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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }
        //instancia la clase conexion
        Conexion conexionBBD = new Conexion();
        DataRow lstpersonal = null;

        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtIDEditar.Text = "";
            txtNombreEditar.Text = "";
            txtDireccionEditar.Text = "";
            txtTelefonoEditar.Text = "";

            comboBoxConsultarEditar.Text = "";
            CboxCajeroConsulta.Text = "";
            comboBoxEliminar.Text = "";

            listViewCajero.Clear();

        }

        public void buscar()
        {
            String sql = "select * from personal where ID = " + comboBoxConsultarEditar.SelectedValue;
            DataRow fila = conexionBBD.getRow(sql);
            if (fila != null)
            {
                txtIDEditar.Text = fila["IDE"].ToString();
                txtNombreEditar.Text = fila["NOMBRE"].ToString();
                txtDireccionEditar.Text = fila["DIRECCION"].ToString();
                txtTelefonoEditar.Text = fila["TELEFONO"].ToString();
                txtCorreoEditar.Text = fila["CORREO"].ToString();
                comboBoxConsultarEditar.Text = "";
            }
            else
            {
                MessageBox.Show("El personal que usted buca no existe.");
                MessageBox.Show("Ingrese un personal valido.");
            }
        }

        public void guardar()
        {
            //Comprobar que todos los textBox no esten vacios
            if (txtID.Text.Trim() == String.Empty && txtNombre.Text.Trim() == String.Empty && txtDireccion.Text.Trim() == String.Empty
                && txtTelefono.Text.Trim() == String.Empty && txtCorreo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Comprobar cada text box que no esten vacios, y si lo estan, mostrar una advertencia
            if (txtID.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar un ID de cajero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el nombre del cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDireccion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar la dirección del cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefono.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el número de telefono del cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCorreo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar el correo electrónico del cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //insertar en la tabla clientes el ID, Nombre, Dirección, Teléfono y Correo del cliente	

            String sql = String.Format("insert into personal(ID,Nombre,Direccion,Telefono,Email)" +
                          " values('{0}','{1}','{2}','{3}', '{4}')",
                          txtID.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim());

            try
            {

                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("Registro del cajero éxitoso");
                }
                else
                {
                    MessageBox.Show("NO se pudo registar el cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            lstpersonal = conexionBBD.getRow("select * from personal where idPersonal='" + CboxCajeroConsulta.SelectedValue + "'");

            if (CboxCajeroConsulta.SelectedValue == null)
            {
                MessageBox.Show("EL personal que intentas mostrar, ya no se encuentra en nuestra base de datos");
            }

            ListViewItem lvpersonal = new ListViewItem();

            lvpersonal.SubItems[0].Text = lstpersonal[0].ToString();
            lvpersonal.SubItems.Add(lstpersonal[1].ToString());
            lvpersonal.SubItems.Add(lstpersonal[2].ToString());
            lvpersonal.SubItems.Add(lstpersonal[3].ToString());
            lvpersonal.SubItems.Add(lstpersonal[4].ToString());
            lvpersonal.SubItems.Add(lstpersonal[5].ToString());

            listViewCajero.Items.Add(lvpersonal);

        }

        public void editar()
        {
            String sql = String.Format("update personal set ID='{0}', Nombre='{1}', Direccion='{2}', Telefono='{3}', Email='{4}' where ID='{4}'",
                          txtIDEditar.Text.Trim(), txtNombreEditar.Text.Trim(), txtDireccionEditar.Text.Trim(), txtTelefonoEditar.Text.Trim(), comboBoxConsultarEditar.SelectedValue);
            try
            {

                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Edicion de la información del caajero éxitosa ...!!!");
                }
                else
                {
                    MessageBox.Show("!!!... ERROR, nO se pudo editar la informacion del cajero ...!!!");
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
            String sql = String.Format("delete from personal where ID= '{0}'", comboBoxEliminar.SelectedValue);

            if (MessageBox.Show("Seguro que deseas eliminar este Cliente?", "Eliminar Cliente",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                try
                {
                    if (conexionBBD.Query(sql) == 1)
                    {
                        MessageBox.Show("!!!... Cajero eliminado con éxito ...!!!");
                    }
                    else
                    {
                        MessageBox.Show("!!!... ERROR, no se pudo eliminar ...!!!");
                    }

                    Limpiar();
                    conexionBBD.CargarCombo(comboBoxEliminar, sql, "", "ID");
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
            listViewCajero.View = View.Details;
            listViewCajero.GridLines = true;
            listViewCajero.FullRowSelect = true;

            //Agregar Descripcion a las Columnas y un tamaño
            // listViewCajero.Columns.Add("id", 30, HorizontalAlignment.Left);
            listViewCajero.Columns.Add("ID", 70, HorizontalAlignment.Left);
            listViewCajero.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            listViewCajero.Columns.Add("Direccion", 120, HorizontalAlignment.Left);
            listViewCajero.Columns.Add("Telefono", 120, HorizontalAlignment.Left);
            listViewCajero.Columns.Add("Email", 120, HorizontalAlignment.Left);

            //cargar todos los comboBox con la descripcion de productos
            conexionBBD.Conectar();
            String sql = "select ID, nombre from personal";
            conexionBBD.CargarCombo(CboxCajeroConsulta, sql, "nombre", "ID");
            conexionBBD.CargarCombo(comboBoxEliminar, sql, "nombre", "ID");
            conexionBBD.CargarCombo(comboBoxConsultarEditar, sql, "nombre", "ID");
        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            addListView();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            editar();
        }
    }
}
