using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tienda
{
    public partial class Corte : Form
    {
        //instancia la clase conexion
        Conexion conexionBBD = new Conexion();
        public Corte()
        {
            InitializeComponent();
        }

        private void Corte_Load(object sender, EventArgs e)
        {
            string sql = "select sum(valorTotal) from factura WHERE `fecha` = '"+ DateTime.Now.ToString("yyyy-MM-dd") + "'";
            //SELECT * FROM `factura` WHERE `fecha` = '2022-05-28' AND `valorTotal` > 0
            try
            {
                MySqlCommand commandDatabase = conexionBBD.Command(sql);
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label2.Text = reader.GetString(0);
                    }
                }
            }catch(System.Data.SqlTypes.SqlNullValueException ex)
            {
                MessageBox.Show("No hay ventas el dia de hoy");
            }
        }
    }
}
