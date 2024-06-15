using MySqlConnector;
using System.Windows.Forms;
using System;

namespace Proyecto_Final_Distribuidora
{
    public partial class MenuFormDBA : Form
    {
        private MySqlConnection connection;

        public MenuFormDBA()
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
                ClienteFormDBA clienteFormDBA = new ClienteFormDBA(connection);
                clienteFormDBA.Show();
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
                FacturaFormDBA facturaFormDBA = new FacturaFormDBA(connection);
                facturaFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void EmpleadoButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                EmpleadoFormDBA empleadoFormDBA = new EmpleadoFormDBA(connection);
                empleadoFormDBA.Show();
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
                ProductoFormDBAv2 productoFormDBAv2 = new ProductoFormDBAv2(connection);
                productoFormDBAv2.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void BodegaButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                BodegaFormDBA bodegaFormDBA = new BodegaFormDBA(connection);
                bodegaFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void CajeroButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                CajeroFormDBA cajeroFormDBA = new CajeroFormDBA(connection);
                cajeroFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void DetalleFacturaButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                DetalleFacturaFormDBA detalleFacturaFormDBA = new DetalleFacturaFormDBA(connection);
                detalleFacturaFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void ProveedorButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                ProveedorFormDBA proveedorFormDBA = new ProveedorFormDBA(connection);
                proveedorFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void OrdenDeEntregaButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                OrdenFormDBA ordenFormDBA = new OrdenFormDBA(connection);
                ordenFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void DetalleOrdenButton_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                DetalleOrdenFormDBA detalleOrdenFormDBA = new DetalleOrdenFormDBA(connection);
                detalleOrdenFormDBA.Show();
            }
            else
            {
                MessageBox.Show("Primero debes conectarte a la base de datos.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}