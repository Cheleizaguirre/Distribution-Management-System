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
    public partial class FacturaForm : Form
    {
        private MySqlConnection connection;
        private List<Producto> productos;
        private DataTable clientesTable;
        private DataTable empleadosTable;

        public FacturaForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            productos = new List<Producto>();

            // Opcional: Inicializar la fecha aquí si es necesario
            facFechTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");

            CargarClientes();
            CargarEmpleados();
        }

        private void CargarClientes()
        {
            string query = "SELECT cli_id, CONCAT(cli_pnom, ' ', cli_pape) AS cliente_nombre FROM cliente";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    clientesTable = new DataTable();
                    adapter.Fill(clientesTable);
                }
            }
            clienteComboBox.DataSource = clientesTable;
            clienteComboBox.ValueMember = "cli_id";
            clienteComboBox.DisplayMember = "cliente_nombre";
        }

        private void CargarEmpleados()
        {
            string query = "SELECT emp_id, CONCAT(emp_pnom, ' ', emp_pape) AS empleado_nombre FROM empleado";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    empleadosTable = new DataTable();
                    adapter.Fill(empleadosTable);
                }
            }
            empleadoComboBox.DataSource = empleadosTable;
            empleadoComboBox.ValueMember = "emp_id";
            empleadoComboBox.DisplayMember = "empleado_nombre";
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            ProductoFormDBA productoFormDBA = new ProductoFormDBA(connection);
            if (productoFormDBA.ShowDialog() == DialogResult.OK)
            {
                Producto producto = productoFormDBA.SelectedProduct;
                productos.Add(producto);
                ActualizarGrid();
                CalcularTotales();
            }
        }

        private void ActualizarGrid()
        {
            productosDataGridView.DataSource = null;
            productosDataGridView.DataSource = productos;
        }

        private void CalcularTotales()
        {
            decimal subtotal = productos.Sum(p => p.Precio);
            decimal impuesto = subtotal * 0.15m;
            decimal total = subtotal + impuesto;

            subtotalTextBox.Text = subtotal.ToString("0.00");
            impuestoTextBox.Text = impuesto.ToString("0.00");
            totalTextBox.Text = total.ToString("0.00");
        }

        private void GuardarFacturaButton_Click(object sender, EventArgs e)
        {
            // Verificar que se hayan agregado productos
            if (productos.Count == 0)
            {
                MessageBox.Show("Debes agregar al menos un producto.");
                return;
            }

            // Verificar que los ComboBox tengan valores seleccionados
            if (clienteComboBox.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.");
                return;
            }

            if (empleadoComboBox.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
                return;
            }

            // Verificar que el ID de la factura esté ingresado
            if (string.IsNullOrWhiteSpace(facIdTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID de la factura.");
                return;
            }

            // Verificar que el ID de la factura sea un número entero
            if (!int.TryParse(facIdTextBox.Text, out int facturaId))
            {
                MessageBox.Show("El ID de la factura debe ser un número entero.");
                return;
            }

            int clienteId = Convert.ToInt32(clienteComboBox.SelectedValue);
            int empleadoId = Convert.ToInt32(empleadoComboBox.SelectedValue);

            using (MySqlCommand cmd = connection.CreateCommand())
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                cmd.Transaction = transaction;

                try
                {
                    // Insertar la factura
                    cmd.CommandText = "INSERT INTO factura (fac_id, cli_id, emp_id, fac_subt, fac_impu, fac_tota, fac_fech) VALUES (@fac_id, @cli_id, @emp_id, @fac_subt, @fac_impu, @fac_tota, @fac_fech)";
                    cmd.Parameters.AddWithValue("@fac_id", facturaId);
                    cmd.Parameters.AddWithValue("@cli_id", clienteId);
                    cmd.Parameters.AddWithValue("@emp_id", empleadoId);
                    cmd.Parameters.AddWithValue("@fac_subt", decimal.Parse(subtotalTextBox.Text));
                    cmd.Parameters.AddWithValue("@fac_impu", decimal.Parse(impuestoTextBox.Text));
                    cmd.Parameters.AddWithValue("@fac_tota", decimal.Parse(totalTextBox.Text));
                    cmd.Parameters.AddWithValue("@fac_fech", DateTime.Parse(facFechTextBox.Text));

                    cmd.ExecuteNonQuery();

                    // Insertar detalles de la factura
                    foreach (Producto producto in productos)
                    {
                        cmd.CommandText = "INSERT INTO detallefactura (fac_id, prod_id, detf_cant) VALUES (@fac_id, @prod_id, @detf_cant)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@fac_id", facturaId);
                        cmd.Parameters.AddWithValue("@prod_id", producto.Id);
                        cmd.Parameters.AddWithValue("@detf_cant", 1); // Cantidad fija por defecto, ajustar si es necesario
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Factura guardada exitosamente.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar la factura: " + ex.Message);
                }
            }
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            OpenFacturaFormv2();
        }

        private void OpenFacturaFormv2()
        {
            FacturaFormv2 facturaFormv2 = new FacturaFormv2(connection);
            facturaFormv2.ShowDialog();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
