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
    public partial class ProveedorFormDBA : Form
    {
        private MySqlConnection connection;

        public ProveedorFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nom = nomTextBox.Text;
            string tel = telTextBox.Text;
            string emai = emaiTextBox.Text;

            string query = "INSERT INTO proveedor (prov_id, prov_nom, prov_tel, prov_emai) VALUES (@id, @nom, @tel, @emai)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@emai", emai);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar proveedor: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT prov_nom, prov_tel, prov_emai FROM proveedor WHERE prov_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nomTextBox.Text = reader["prov_nom"].ToString();
                    telTextBox.Text = reader["prov_tel"].ToString();
                    emaiTextBox.Text = reader["prov_emai"].ToString();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar proveedor: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nom = nomTextBox.Text;
            string tel = telTextBox.Text;
            string emai = emaiTextBox.Text;

            string query = "UPDATE proveedor SET prov_nom = @nom, prov_tel = @tel, prov_emai = @emai WHERE prov_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@emai", emai);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar proveedor: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM proveedor WHERE prov_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
            }
        }
    }
}
