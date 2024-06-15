namespace Proyecto_Final_Distribuidora
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clienteButton;
        private System.Windows.Forms.Button facturaButton;
        private System.Windows.Forms.Button productoButton;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MenuForm";

            // Botón connectButton
            this.connectButton = new System.Windows.Forms.Button();
            this.connectButton.Location = new System.Drawing.Point(50, 50);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 30);
            this.connectButton.Text = "Conectar";
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            this.Controls.Add(this.connectButton);

            // Botón clienteButton
            this.clienteButton = new System.Windows.Forms.Button();
            this.clienteButton.Location = new System.Drawing.Point(50, 100);
            this.clienteButton.Name = "clienteButton";
            this.clienteButton.Size = new System.Drawing.Size(100, 30);
            this.clienteButton.Text = "Clientes";
            this.clienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            this.Controls.Add(this.clienteButton);

            // Botón facturaButton
            this.facturaButton = new System.Windows.Forms.Button();
            this.facturaButton.Location = new System.Drawing.Point(50, 150);
            this.facturaButton.Name = "facturaButton";
            this.facturaButton.Size = new System.Drawing.Size(100, 30);
            this.facturaButton.Text = "Facturas";
            this.facturaButton.Click += new System.EventHandler(this.FacturaButton_Click);
            this.Controls.Add(this.facturaButton);

            // Botón productoButton
            this.productoButton = new System.Windows.Forms.Button();
            this.productoButton.Location = new System.Drawing.Point(50, 200);
            this.productoButton.Name = "productoButton";
            this.productoButton.Size = new System.Drawing.Size(100, 30);
            this.productoButton.Text = "Productos";
            this.productoButton.Click += new System.EventHandler(this.ProductoButton_Click);
            this.Controls.Add(this.productoButton);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}