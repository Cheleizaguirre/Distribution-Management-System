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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Distribuidora
{
    public partial class ProductoFormV2 : Form
    {
        private MySqlConnection connection;

        public ProductoFormV2(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            LoadBodegas();
        }

        private void LoadBodegas()
        {
            try
            {
                string query = "SELECT bod_id, bod_nomb FROM bodega";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                bodIdComboBox.DataSource = dataTable;
                bodIdComboBox.DisplayMember = "bod_nomb";
                bodIdComboBox.ValueMember = "bod_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bodegas: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT prod_nomb, prod_prec, bod_id FROM producto WHERE prod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nombTextBox.Text = reader["prod_nomb"].ToString();
                    precTextBox.Text = reader["prod_prec"].ToString();
                    bodIdComboBox.SelectedValue = reader["bod_id"];
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar producto: " + ex.Message);
            }
        }
    }
}
