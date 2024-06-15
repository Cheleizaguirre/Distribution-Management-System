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
    public partial class BodegaFormDBA : Form
    {
        private MySqlConnection connection;

        public BodegaFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nomb = nombTextBox.Text;
            string dire = direTextBox.Text;

            string query = "INSERT INTO bodega (bod_id, bod_nomb, bod_dire) VALUES (@id, @nomb, @dire)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nomb", nomb);
            command.Parameters.AddWithValue("@dire", dire);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bodega ingresada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar bodega: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT bod_nomb, bod_dire FROM bodega WHERE bod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nombTextBox.Text = reader["bod_nomb"].ToString();
                    direTextBox.Text = reader["bod_dire"].ToString();
                }
                else
                {
                    MessageBox.Show("Bodega no encontrada.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar bodega: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nomb = nombTextBox.Text;
            string dire = direTextBox.Text;

            string query = "UPDATE bodega SET bod_nomb = @nomb, bod_dire = @dire WHERE bod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nomb", nomb);
            command.Parameters.AddWithValue("@dire", dire);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bodega modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar bodega: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM bodega WHERE bod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bodega eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar bodega: " + ex.Message);
            }
        }
    }
}

