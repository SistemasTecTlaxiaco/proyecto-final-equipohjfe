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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public void VerProductos()
        {
            Productos productos = new Productos();
            //productos.MdiParent = this; //especificar que el formulario es un formulario secundario.
            productos.Show();// Abrir el Foirmulario Productos
        }

        public void VerInventario()
        {
            Inventario inventario = new Inventario();
            //productos.MdiParent = this; //especificar que el formulario es un formulario secundario.
            inventario.Show();// Abrir el Foirmulario Productos
        }

        public void VerClientes()
        {
            Clientes clientes = new Clientes();
            //productos.MdiParent = this; //especificar que el formulario es un formulario secundario.
            clientes.Show();// Abrir el Foirmulario Productos
        }

        public void VerFacturas()
        {
            Factura factura = new Factura();
            //productos.MdiParent = this; //especificar que el formulario es un formulario secundario.
            factura.Show();// Abrir el Foirmulario Productos
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductos();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerClientes();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerInventario();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerFacturas();
        }
    }
}
