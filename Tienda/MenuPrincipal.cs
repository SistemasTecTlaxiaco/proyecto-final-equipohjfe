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

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            VerProductos();
        }
    }
}
