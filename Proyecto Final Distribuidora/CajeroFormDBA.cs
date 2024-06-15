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
    public partial class CajeroFormDBA : Form
    {
        private MySqlConnection connection;

        public CajeroFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string edad = edadTextBox.Text;

            string query = "INSERT INTO cajero (emp_id, caj_edad) VALUES (@id, @edad)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@edad", edad);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cajero ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar cajero: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT caj_edad, emp_pnom, emp_pape FROM cajero INNER JOIN empleado ON cajero.emp_id = empleado.emp_id WHERE cajero.emp_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    edadTextBox.Text = reader["caj_edad"].ToString();
                    nombreEmpleadoTextBox.Text = reader["emp_pnom"].ToString() + " " + reader["emp_pape"].ToString();
                }
                else
                {
                    MessageBox.Show("Cajero no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar cajero: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string edad = edadTextBox.Text;

            string query = "UPDATE cajero SET caj_edad = @edad WHERE emp_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@edad", edad);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cajero modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cajero: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM cajero WHERE emp_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cajero eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cajero: " + ex.Message);
            }
        }
    }
}
