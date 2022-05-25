using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Buscar : Form
    {
        //instancia la clase conexion
        static Conexion conexionBBD = new Conexion();

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public string id;
        public Buscar()
        {
            InitializeComponent();
        }

        public void SearchData(string valueToSearch)
        {
            string query = "SELECT * FROM productos WHERE CONCAT(`CodigoBarra`, `descripcionProducto`) like '%" + valueToSearch + "%'";
            command = conexionBBD.Command(query);
            adapter = new MySqlDataAdapter(command);
            table  = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Ventas ventas = Application.OpenForms.OfType<Ventas>().SingleOrDefault();

            if (ventas != null)
            {
                ventas.codigoBarraText.Text = id;
                ventas.addListView();
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            SearchData(valueToSearch);
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            SearchData("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //                                        e.ColumnIndex
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Console.WriteLine(id);
            }
            /*
            //obtienes el valor reservado
            //string id = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //nombre columna
            string nombrecolumna = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            //obtienes el valor de la primer columna
            string valorPrimerCelda = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();*/
        }
    }
}
