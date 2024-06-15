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
    public partial class FacturaFormv2 : Form
    {
        private MySqlConnection connection;

        public FacturaFormv2(MySqlConnection connection)
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
    }
}
