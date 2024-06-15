using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Distribuidora
{
    public partial class ProductoFormDBA : Form
    {
        private MySqlConnection connection;

        public Producto SelectedProduct { get; private set; }

        public ProductoFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            LoadProductos();
        }

        private void LoadProductos()
        {
            string query = "SELECT prod_id, prod_nomb, prod_prec FROM producto";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            productosDataGridView.DataSource = table;
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            if (productosDataGridView.SelectedRows.Count > 0)
            {
                int prodId = Convert.ToInt32(productosDataGridView.SelectedRows[0].Cells["prod_id"].Value);
                string prodNomb = productosDataGridView.SelectedRows[0].Cells["prod_nomb"].Value.ToString();
                decimal prodPrec = Convert.ToDecimal(productosDataGridView.SelectedRows[0].Cells["prod_prec"].Value);

                SelectedProduct = new Producto { Id = prodId, Nombre = prodNomb, Precio = prodPrec };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un producto.");
            }
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

    }
}
