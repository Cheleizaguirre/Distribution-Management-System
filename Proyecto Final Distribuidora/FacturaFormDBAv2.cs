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
    public partial class FacturaFormDBAv2 : Form
    {
        private MySqlConnection connection;

        public FacturaFormDBAv2(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // Cargar IDs de clientes en el ComboBox
            string queryCliente = "SELECT cli_id FROM cliente";
            MySqlCommand commandCliente = new MySqlCommand(queryCliente, connection);
            MySqlDataReader readerCliente = commandCliente.ExecuteReader();
            while (readerCliente.Read())
            {
                cliComboBox.Items.Add(readerCliente["cli_id"].ToString());
            }
            readerCliente.Close();

            // Cargar IDs de empleados en el ComboBox
            string queryEmpleado = "SELECT emp_id FROM empleado";
            MySqlCommand commandEmpleado = new MySqlCommand(queryEmpleado, connection);
            MySqlDataReader readerEmpleado = commandEmpleado.ExecuteReader();
            while (readerEmpleado.Read())
            {
                empComboBox.Items.Add(readerEmpleado["emp_id"].ToString());
            }
            readerEmpleado.Close();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = facIdTextBox.Text;

            string query = "SELECT cli_id, emp_id, fac_subt, fac_impu, fac_tota, fac_fech FROM factura WHERE fac_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    cliComboBox.SelectedItem = reader["cli_id"].ToString();
                    empComboBox.SelectedItem = reader["emp_id"].ToString();
                    subtTextBox.Text = reader["fac_subt"].ToString();
                    impuTextBox.Text = reader["fac_impu"].ToString();
                    totaTextBox.Text = reader["fac_tota"].ToString();
                    fechaDateTimePicker.Value = Convert.ToDateTime(reader["fac_fech"]);
                }
                else
                {
                    MessageBox.Show("Factura no encontrada.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar factura: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = facIdTextBox.Text;
            string clienteId = cliComboBox.SelectedItem.ToString();
            string empleadoId = empComboBox.SelectedItem.ToString();
            string subtotal = subtTextBox.Text;
            string impuesto = impuTextBox.Text;
            string total = totaTextBox.Text;
            string fecha = fechaDateTimePicker.Value.ToString("yyyy-MM-dd");

            string query = "UPDATE factura SET cli_id = @cli_id, emp_id = @emp_id, fac_subt = @fac_subt, fac_impu = @fac_impu, fac_tota = @fac_tota, fac_fech = @fac_fech WHERE fac_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@cli_id", clienteId);
            command.Parameters.AddWithValue("@emp_id", empleadoId);
            command.Parameters.AddWithValue("@fac_subt", subtotal);
            command.Parameters.AddWithValue("@fac_impu", impuesto);
            command.Parameters.AddWithValue("@fac_tota", total);
            command.Parameters.AddWithValue("@fac_fech", fecha);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Factura modificada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar factura: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = facIdTextBox.Text;

            // Iniciar una transacción para asegurar que ambas operaciones sean atómicas
            MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Primero eliminar los registros correspondientes en la tabla detallefactura
                string deleteDetalleQuery = "DELETE FROM detallefactura WHERE fac_id = @id";
                MySqlCommand deleteDetalleCommand = new MySqlCommand(deleteDetalleQuery, connection, transaction);
                deleteDetalleCommand.Parameters.AddWithValue("@id", id);
                deleteDetalleCommand.ExecuteNonQuery();

                // Luego eliminar el registro en la tabla factura
                string deleteFacturaQuery = "DELETE FROM factura WHERE fac_id = @id";
                MySqlCommand deleteFacturaCommand = new MySqlCommand(deleteFacturaQuery, connection, transaction);
                deleteFacturaCommand.Parameters.AddWithValue("@id", id);
                deleteFacturaCommand.ExecuteNonQuery();

                // Confirmar la transacción
                transaction.Commit();
                MessageBox.Show("Factura eliminada correctamente.");
            }
            catch (Exception ex)
            {
                // Revertir la transacción en caso de error
                transaction.Rollback();
                MessageBox.Show("Error al eliminar factura: " + ex.Message);
            }
        }
    }
}