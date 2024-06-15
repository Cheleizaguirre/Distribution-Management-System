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
    public partial class ClienteFormDBA : Form
    {
        private MySqlConnection connection;

        public ClienteFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pnom = pnomTextBox.Text;
            string pape = papeTextBox.Text;
            string dire = direTextBox.Text;
            string telf = telfTextBox.Text;
            string emai = emaiTextBox.Text;

            string query = "INSERT INTO cliente (cli_id, cli_pnom, cli_pape, cli_dire, cli_telf, cli_emai) VALUES (@id, @pnom, @pape, @dire, @telf, @emai)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pnom", pnom);
            command.Parameters.AddWithValue("@pape", pape);
            command.Parameters.AddWithValue("@dire", dire);
            command.Parameters.AddWithValue("@telf", telf);
            command.Parameters.AddWithValue("@emai", emai);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cliente ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar cliente: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT cli_pnom, cli_pape, cli_dire, cli_telf, cli_emai FROM cliente WHERE cli_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    pnomTextBox.Text = reader["cli_pnom"].ToString();
                    papeTextBox.Text = reader["cli_pape"].ToString();
                    direTextBox.Text = reader["cli_dire"].ToString();
                    telfTextBox.Text = reader["cli_telf"].ToString();
                    emaiTextBox.Text = reader["cli_emai"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar cliente: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pnom = pnomTextBox.Text;
            string pape = papeTextBox.Text;
            string dire = direTextBox.Text;
            string telf = telfTextBox.Text;
            string emai = emaiTextBox.Text;

            string query = "UPDATE cliente SET cli_pnom = @pnom, cli_pape = @pape, cli_dire = @dire, cli_telf = @telf, cli_emai = @emai WHERE cli_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pnom", pnom);
            command.Parameters.AddWithValue("@pape", pape);
            command.Parameters.AddWithValue("@dire", dire);
            command.Parameters.AddWithValue("@telf", telf);
            command.Parameters.AddWithValue("@emai", emai);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM cliente WHERE cli_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
        }
    }
}