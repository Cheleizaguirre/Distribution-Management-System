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
    public partial class EmpleadoFormDBA : Form
    {
        private MySqlConnection connection;

        public EmpleadoFormDBA(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pnom = pnomTextBox.Text;
            string pape = papeTextBox.Text;
            string telf = telfTextBox.Text;

            string query = "INSERT INTO empleado (emp_id, emp_pnom, emp_pape, emp_telf) VALUES (@id, @pnom, @pape, @telf)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pnom", pnom);
            command.Parameters.AddWithValue("@pape", pape);
            command.Parameters.AddWithValue("@telf", telf);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar empleado: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT emp_pnom, emp_pape, emp_telf FROM empleado WHERE emp_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    pnomTextBox.Text = reader["emp_pnom"].ToString();
                    papeTextBox.Text = reader["emp_pape"].ToString();
                    telfTextBox.Text = reader["emp_telf"].ToString();
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar empleado: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pnom = pnomTextBox.Text;
            string pape = papeTextBox.Text;
            string telf = telfTextBox.Text;

            string query = "UPDATE empleado SET emp_pnom = @pnom, emp_pape = @pape, emp_telf = @telf WHERE emp_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@pnom", pnom);
            command.Parameters.AddWithValue("@pape", pape);
            command.Parameters.AddWithValue("@telf", telf);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar empleado: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM empleado WHERE emp_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar empleado: " + ex.Message);
            }
        }
    }
}