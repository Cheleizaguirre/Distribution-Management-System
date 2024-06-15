namespace Proyecto_Final_Distribuidora
{
    partial class MenuFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clienteButton;
        private System.Windows.Forms.Button facturaButton;
        private System.Windows.Forms.Button empleadoButton;
        private System.Windows.Forms.Button productoButton;
        private System.Windows.Forms.Button bodegaButton;
        private System.Windows.Forms.Button cajeroButton;
        private System.Windows.Forms.Button detalleFacturaButton;
        private System.Windows.Forms.Button proveedorButton;
        private System.Windows.Forms.Button ordenDeEntregaButton;
        private System.Windows.Forms.Button detalleOrdenButton;
        private System.Windows.Forms.TextBox textBox1;

        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.clienteButton = new System.Windows.Forms.Button();
            this.facturaButton = new System.Windows.Forms.Button();
            this.empleadoButton = new System.Windows.Forms.Button();
            this.productoButton = new System.Windows.Forms.Button();
            this.bodegaButton = new System.Windows.Forms.Button();
            this.cajeroButton = new System.Windows.Forms.Button();
            this.detalleFacturaButton = new System.Windows.Forms.Button();
            this.proveedorButton = new System.Windows.Forms.Button();
            this.ordenDeEntregaButton = new System.Windows.Forms.Button();
            this.detalleOrdenButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(354, 51);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 30);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Conectar";
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // clienteButton
            // 
            this.clienteButton.Location = new System.Drawing.Point(50, 114);
            this.clienteButton.Name = "clienteButton";
            this.clienteButton.Size = new System.Drawing.Size(100, 30);
            this.clienteButton.TabIndex = 1;
            this.clienteButton.Text = "Clientes";
            this.clienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // facturaButton
            // 
            this.facturaButton.Location = new System.Drawing.Point(354, 114);
            this.facturaButton.Name = "facturaButton";
            this.facturaButton.Size = new System.Drawing.Size(100, 30);
            this.facturaButton.TabIndex = 2;
            this.facturaButton.Text = "Facturas";
            this.facturaButton.Click += new System.EventHandler(this.FacturaButton_Click);
            // 
            // empleadoButton
            // 
            this.empleadoButton.Location = new System.Drawing.Point(197, 114);
            this.empleadoButton.Name = "empleadoButton";
            this.empleadoButton.Size = new System.Drawing.Size(100, 30);
            this.empleadoButton.TabIndex = 3;
            this.empleadoButton.Text = "Empleados";
            this.empleadoButton.Click += new System.EventHandler(this.EmpleadoButton_Click);
            // 
            // productoButton
            // 
            this.productoButton.Location = new System.Drawing.Point(513, 114);
            this.productoButton.Name = "productoButton";
            this.productoButton.Size = new System.Drawing.Size(100, 30);
            this.productoButton.TabIndex = 4;
            this.productoButton.Text = "Productos";
            this.productoButton.Click += new System.EventHandler(this.ProductoButton_Click);
            // 
            // bodegaButton
            // 
            this.bodegaButton.Location = new System.Drawing.Point(657, 114);
            this.bodegaButton.Name = "bodegaButton";
            this.bodegaButton.Size = new System.Drawing.Size(100, 30);
            this.bodegaButton.TabIndex = 5;
            this.bodegaButton.Text = "Bodega";
            this.bodegaButton.Click += new System.EventHandler(this.BodegaButton_Click);
            // 
            // cajeroButton
            // 
            this.cajeroButton.Location = new System.Drawing.Point(197, 186);
            this.cajeroButton.Name = "cajeroButton";
            this.cajeroButton.Size = new System.Drawing.Size(100, 30);
            this.cajeroButton.TabIndex = 6;
            this.cajeroButton.Text = "Cajeros";
            this.cajeroButton.Click += new System.EventHandler(this.CajeroButton_Click);
            // 
            // detalleFacturaButton
            // 
            this.detalleFacturaButton.Location = new System.Drawing.Point(345, 186);
            this.detalleFacturaButton.Name = "detalleFacturaButton";
            this.detalleFacturaButton.Size = new System.Drawing.Size(120, 30);
            this.detalleFacturaButton.TabIndex = 5;
            this.detalleFacturaButton.Text = "Detalle Factura";
            this.detalleFacturaButton.Click += new System.EventHandler(this.DetalleFacturaButton_Click);
            // 
            // proveedorButton
            // 
            this.proveedorButton.Location = new System.Drawing.Point(50, 186);
            this.proveedorButton.Name = "proveedorButton";
            this.proveedorButton.Size = new System.Drawing.Size(100, 30);
            this.proveedorButton.TabIndex = 8;
            this.proveedorButton.Text = "Proveedores";
            this.proveedorButton.Click += new System.EventHandler(this.ProveedorButton_Click);
            // 
            // ordenDeEntregaButton
            // 
            this.ordenDeEntregaButton.Location = new System.Drawing.Point(503, 186);
            this.ordenDeEntregaButton.Name = "ordenDeEntregaButton";
            this.ordenDeEntregaButton.Size = new System.Drawing.Size(120, 30);
            this.ordenDeEntregaButton.TabIndex = 8;
            this.ordenDeEntregaButton.Text = "Orden de Entrega";
            this.ordenDeEntregaButton.Click += new System.EventHandler(this.OrdenDeEntregaButton_Click);
            // 
            // detalleOrdenButton
            // 
            this.detalleOrdenButton.Location = new System.Drawing.Point(647, 186);
            this.detalleOrdenButton.Name = "detalleOrdenButton";
            this.detalleOrdenButton.Size = new System.Drawing.Size(120, 30);
            this.detalleOrdenButton.TabIndex = 9;
            this.detalleOrdenButton.Text = "Detalle Orden";
            this.detalleOrdenButton.Click += new System.EventHandler(this.DetalleOrdenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "DBA";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MenuFormDBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detalleOrdenButton);
            this.Controls.Add(this.ordenDeEntregaButton);
            this.Controls.Add(this.proveedorButton);
            this.Controls.Add(this.detalleFacturaButton);
            this.Controls.Add(this.cajeroButton);
            this.Controls.Add(this.bodegaButton);
            this.Controls.Add(this.productoButton);
            this.Controls.Add(this.empleadoButton);
            this.Controls.Add(this.facturaButton);
            this.Controls.Add(this.clienteButton);
            this.Controls.Add(this.connectButton);
            this.Name = "MenuFormDBA";
            this.Text = "MenuFormDBA";
            this.ResumeLayout(false);
            this.PerformLayout();

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