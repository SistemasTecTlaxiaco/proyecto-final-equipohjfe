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

        void CloseAll()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        public void VerProductos()
        {
            CloseAll();
            Productos productos = new Productos();
            productos.MdiParent = this; //especificar que el formulario es un formulario secundario.
            productos.WindowState = FormWindowState.Maximized;//Maximizar formulario al iniciar
            productos.Show();// Abrir el Foirmulario Productos
        }

        public void VerInventario()
        {
            CloseAll();
            Inventario inventario = new Inventario();
            inventario.MdiParent = this; //especificar que el formulario es un formulario secundario.
            inventario.WindowState = FormWindowState.Maximized;//Maximizar formulario al iniciar
            inventario.Show();// Abrir el Foirmulario Productos
        }

        public void VerClientes()
        {
            CloseAll();
            Clientes clientes = new Clientes();
            clientes.MdiParent = this; //especificar que el formulario es un formulario secundario.
            clientes.WindowState = FormWindowState.Maximized;//Maximizar formulario al iniciar
            clientes.Show();// Abrir el Foirmulario Productos
        }

        public void VerFacturas()
        {
            CloseAll();
            Factura factura = new Factura();
            factura.MdiParent = this; //especificar que el formulario es un formulario secundario.
            factura.WindowState = FormWindowState.Maximized;//Maximizar formulario al iniciar
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
