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
    public partial class MenuForm : Form
    {
        private MySqlConnection connection;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=distribuidora;User ID=root;Password=yourpassword;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Conexión exitosa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                ClienteForm clienteForm = new ClienteForm(connection);
                clienteForm.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void FacturaButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                FacturaForm facturaForm = new FacturaForm(connection);
                facturaForm.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void ProductoButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                ProductoFormV2 productoForm = new ProductoFormV2(connection);
                productoForm.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }
    }
}
