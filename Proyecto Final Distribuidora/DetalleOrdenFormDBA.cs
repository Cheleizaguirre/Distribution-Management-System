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
    public partial class DetalleOrdenFormDBA : Form
    {
        private MySqlConnection connection;

        public DetalleOrdenFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // Load prod_id ComboBox with product names and IDs
            string prodQuery = "SELECT prod_id, prod_nomb FROM producto";
            MySqlCommand prodCommand = new MySqlCommand(prodQuery, connection);
            MySqlDataReader prodReader = prodCommand.ExecuteReader();
            var prodList = new List<KeyValuePair<int, string>>();
            while (prodReader.Read())
            {
                prodList.Add(new KeyValuePair<int, string>((int)prodReader["prod_id"], (string)prodReader["prod_nomb"]));
            }
            prodReader.Close();
            prodIdComboBox.DataSource = prodList;
            prodIdComboBox.DisplayMember = "Value"; // Display product name
            prodIdComboBox.ValueMember = "Key"; // Use product ID as value

            // Load ord_id ComboBox with order IDs
            string ordQuery = "SELECT ord_id FROM orden";
            MySqlCommand ordCommand = new MySqlCommand(ordQuery, connection);
            MySqlDataReader ordReader = ordCommand.ExecuteReader();
            var ordList = new List<string>();
            while (ordReader.Read())
            {
                ordList.Add(ordReader["ord_id"].ToString());
            }
            ordReader.Close();
            ordIdComboBox.DataSource = ordList;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string detoId = detoIdTextBox.Text;
            string prodId = prodIdComboBox.SelectedValue?.ToString();
            string ordId = ordIdComboBox.SelectedItem?.ToString();
            string detoCant = detoCantTextBox.Text;

            string query = "INSERT INTO detalleorden (deto_id, prod_id, ord_id, deto_cant) VALUES (@detoId, @prodId, @ordId, @detoCant)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@detoId", detoId);
            command.Parameters.AddWithValue("@prodId", prodId);
            command.Parameters.AddWithValue("@ordId", ordId);
            command.Parameters.AddWithValue("@detoCant", detoCant);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle de orden ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar detalle de orden: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string detoId = detoIdTextBox.Text;

            string query = "SELECT prod_id, ord_id, deto_cant FROM detalleorden WHERE deto_id = @detoId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@detoId", detoId);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int prodId = Convert.ToInt32(reader["prod_id"]);
                    string ordId = reader["ord_id"].ToString();
                    string detoCant = reader["deto_cant"].ToString();

                    // Set ComboBox selections
                    prodIdComboBox.SelectedValue = prodId;
                    ordIdComboBox.SelectedItem = ordId;
                    detoCantTextBox.Text = detoCant;
                }
                else
                {
                    MessageBox.Show("Detalle de orden no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar detalle de orden: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string detoId = detoIdTextBox.Text;
            string prodId = prodIdComboBox.SelectedValue?.ToString();
            string ordId = ordIdComboBox.SelectedItem?.ToString();
            string detoCant = detoCantTextBox.Text;

            string query = "UPDATE detalleorden SET prod_id = @prodId, ord_id = @ordId, deto_cant = @detoCant WHERE deto_id = @detoId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@detoId", detoId);
            command.Parameters.AddWithValue("@prodId", prodId);
            command.Parameters.AddWithValue("@ordId", ordId);
            command.Parameters.AddWithValue("@detoCant", detoCant);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle de orden modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar detalle de orden: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string detoId = detoIdTextBox.Text;

            string query = "DELETE FROM detalleorden WHERE deto_id = @detoId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@detoId", detoId);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle de orden eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar detalle de orden: " + ex.Message);
            }
        }
    }
}
