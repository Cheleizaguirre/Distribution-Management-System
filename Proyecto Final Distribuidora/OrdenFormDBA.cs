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
    public partial class OrdenFormDBA : Form
    {
        private MySqlConnection connection;

        public OrdenFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            LoadProveedorData();
        }

        private void LoadProveedorData()
        {
            string query = "SELECT prov_id, prov_nom FROM proveedor";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                provComboBox.Items.Clear(); // Limpia los elementos existentes
                while (reader.Read())
                {
                    provComboBox.Items.Add(new
                    {
                        Text = reader["prov_nom"].ToString(),
                        Value = reader["prov_id"]
                    });
                }
                reader.Close();
                provComboBox.DisplayMember = "Text";
                provComboBox.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string provId = ((dynamic)provComboBox.SelectedItem).Value.ToString();
            DateTime fecha = fechaDateTimePicker.Value;

            string query = "INSERT INTO orden (ord_id, prov_id, ord_fech) VALUES (@id, @provId, @fecha)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@provId", provId);
            command.Parameters.AddWithValue("@fecha", fecha);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Orden ingresada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar orden: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT prov_id, ord_fech FROM orden WHERE ord_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int provId = Convert.ToInt32(reader["prov_id"]);
                    fechaDateTimePicker.Value = Convert.ToDateTime(reader["ord_fech"]);

                    // Selecciona el proveedor en el ComboBox
                    foreach (var item in provComboBox.Items)
                    {
                        var comboItem = (dynamic)item;
                        if (Convert.ToInt32(comboItem.Value) == provId)
                        {
                            provComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Orden no encontrada.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar orden: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string provId = ((dynamic)provComboBox.SelectedItem).Value.ToString();
            DateTime fecha = fechaDateTimePicker.Value;

            string query = "UPDATE orden SET prov_id = @provId, ord_fech = @fecha WHERE ord_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@provId", provId);
            command.Parameters.AddWithValue("@fecha", fecha);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Orden modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar orden: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM orden WHERE ord_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Orden eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar orden: " + ex.Message);
            }
        }
    }
}
