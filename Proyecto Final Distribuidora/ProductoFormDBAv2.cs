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
    public partial class ProductoFormDBAv2 : Form
    {
        private MySqlConnection connection;
        private DataTable bodegasTable;

        public ProductoFormDBAv2(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            LoadBodegas();
        }

        private void LoadBodegas()
        {
            string query = "SELECT bod_id, bod_nomb FROM bodega";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            bodegasTable = new DataTable();
            adapter.Fill(bodegasTable);
            bodIdComboBox.DisplayMember = "bod_nomb";
            bodIdComboBox.ValueMember = "bod_id";
            bodIdComboBox.DataSource = bodegasTable;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nomb = nombTextBox.Text;
            string prec = precTextBox.Text;
            string bodId = bodIdComboBox.SelectedValue.ToString();

            string query = "INSERT INTO producto (prod_id, prod_nomb, prod_prec, bod_id) VALUES (@id, @nomb, @prec, @bodId)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nomb", nomb);
            command.Parameters.AddWithValue("@prec", prec);
            command.Parameters.AddWithValue("@bodId", bodId);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Producto ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar producto: " + ex.Message);
            }
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "SELECT prod_nomb, prod_prec, bod_id FROM producto WHERE prod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nombTextBox.Text = reader["prod_nomb"].ToString();
                    precTextBox.Text = reader["prod_prec"].ToString();
                    bodIdComboBox.SelectedValue = reader["bod_id"];
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar producto: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nomb = nombTextBox.Text;
            string prec = precTextBox.Text;
            string bodId = bodIdComboBox.SelectedValue.ToString();

            string query = "UPDATE producto SET prod_nomb = @nomb, prod_prec = @prec, bod_id = @bodId WHERE prod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nomb", nomb);
            command.Parameters.AddWithValue("@prec", prec);
            command.Parameters.AddWithValue("@bodId", bodId);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Producto modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;

            string query = "DELETE FROM producto WHERE prod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }
    }
}