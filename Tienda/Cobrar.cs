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
    public partial class Cobrar : Form
    {
        //instancia la clase conexion
        Conexion conexionBBD = new Conexion();
        public Cobrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CobrarTotal();
            this.Close();
        }

        public void CobrarTotal()
        {

            Ventas ventas = Application.OpenForms.OfType<Ventas>().SingleOrDefault();


            String sql = String.Format("insert into factura (fecha,idCliente,valorTotal,idUsuario)" +
                          " values('{0}','{1}','{2}','{3}')",
                          DateTime.Now.ToString("yyyy-MM-dd"), "0", label1.Text, "User");//falta asignar cliente relacional
            Console.WriteLine(sql);
            try
            {
                if (conexionBBD.Query(sql) == 1)
                {
                    MessageBox.Show("!!!... Compra éxitoso ...!!!");

                    if (ventas != null)
                    {
                        ventas.Clean();
                    }
                }
                else
                {
                    MessageBox.Show("!!!... ERROR Compra ...!!!");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void Cobrar_Load(object sender, EventArgs e)
        {
            textBox1.Text = label1.Text;
            Cambio();
        }

        public void Cambio()
        {
            double pagaCon = Double.Parse(textBox1.Text);
            double paga = Double.Parse(label1.Text);
            if ((pagaCon - paga) > 0)
            {
                double cambio = (pagaCon - paga);
                label4.Text = cambio.ToString();
            }
            else
            {
                double cambio = 0;
                label4.Text = cambio.ToString();
            }
        }
    }
}
