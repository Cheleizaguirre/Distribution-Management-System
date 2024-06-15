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
    public partial class DetalleFacturaFormDBA : Form
    {
        private MySqlConnection connection;

        public DetalleFacturaFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            CargarProductos();
        }

        private void CargarProductos()
        {
            string query = "SELECT prod_id, prod_nomb FROM producto";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                prodComboBox.Items.Clear();

                while (reader.Read())
                {
                    string prodId = reader["prod_id"].ToString();
                    string prodNomb = reader["prod_nomb"].ToString();
                    prodComboBox.Items.Add(new { Text = prodNomb, Value = prodId });
                }

                prodComboBox.DisplayMember = "Text";
                prodComboBox.ValueMember = "Value";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string facId = facIdTextBox.Text;
            string prodId = (prodComboBox.SelectedItem as dynamic)?.Value.ToString(); // Obtén el ID del producto seleccionado
            string cant = cantTextBox.Text;

            string query = "INSERT INTO detallefactura (detf_id, fac_id, prod_id, detf_cant) VALUES (@id, @facId, @prodId, @cant)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@facId", facId);
            command.Parameters.AddWithValue("@prodId", prodId);
            command.Parameters.AddWithValue("@cant", cant);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle de factura ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar detalle de factura: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT fac_id, prod_id, detf_cant FROM detallefactura WHERE detf_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    facIdTextBox.Text = reader["fac_id"].ToString();
                    string prodId = reader["prod_id"].ToString();
                    cantTextBox.Text = reader["detf_cant"].ToString();
                    // Establece el ComboBox al producto seleccionado
                    foreach (var item in prodComboBox.Items)
                    {
                        if ((item as dynamic).Value == prodId)
                        {
                            prodComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Detalle de factura no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar detalle de factura: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string facId = facIdTextBox.Text;
            string prodId = (prodComboBox.SelectedItem as dynamic)?.Value.ToString(); // Obtén el ID del producto seleccionado
            string cant = cantTextBox.Text;

            string query = "UPDATE detallefactura SET fac_id = @facId, prod_id = @prodId, detf_cant = @cant WHERE detf_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@facId", facId);
            command.Parameters.AddWithValue("@prodId", prodId);
            command.Parameters.AddWithValue("@cant", cant);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle de factura modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar detalle de factura: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM detallefactura WHERE detf_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle de factura eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar detalle de factura: " + ex.Message);
            }
        }
    }
}
