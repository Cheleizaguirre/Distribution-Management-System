namespace Proyecto_Final_Distribuidora
{
    partial class FacturaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button agregarProductoButton;
        private System.Windows.Forms.Button guardarFacturaButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label impuestoLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox empleadoComboBox;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label empleadoLabel;
        private System.Windows.Forms.TextBox facIdTextBox;
        private System.Windows.Forms.TextBox facFechTextBox;
        private System.Windows.Forms.Label facIdLabel;
        private System.Windows.Forms.Label facFechLabel;
        private System.Windows.Forms.Button consultaButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.agregarProductoButton = new System.Windows.Forms.Button();
            this.guardarFacturaButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.impuestoLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoComboBox = new System.Windows.Forms.ComboBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.empleadoLabel = new System.Windows.Forms.Label();
            this.facIdTextBox = new System.Windows.Forms.TextBox();
            this.facFechTextBox = new System.Windows.Forms.TextBox();
            this.facIdLabel = new System.Windows.Forms.Label();
            this.facFechLabel = new System.Windows.Forms.Label();
            this.consultaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Location = new System.Drawing.Point(53, 148);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.Size = new System.Drawing.Size(500, 200);
            this.productosDataGridView.TabIndex = 0;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(450, 352);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 1;
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.Location = new System.Drawing.Point(450, 376);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.ReadOnly = true;
            this.impuestoTextBox.Size = new System.Drawing.Size(100, 20);
            this.impuestoTextBox.TabIndex = 2;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(450, 402);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 3;
            // 
            // agregarProductoButton
            // 
            this.agregarProductoButton.Location = new System.Drawing.Point(53, 358);
            this.agregarProductoButton.Name = "agregarProductoButton";
            this.agregarProductoButton.Size = new System.Drawing.Size(150, 30);
            this.agregarProductoButton.TabIndex = 4;
            this.agregarProductoButton.Text = "Agregar Producto";
            this.agregarProductoButton.UseVisualStyleBackColor = true;
            this.agregarProductoButton.Click += new System.EventHandler(this.AgregarProductoButton_Click);
            // 
            // guardarFacturaButton
            // 
            this.guardarFacturaButton.Location = new System.Drawing.Point(400, 450);
            this.guardarFacturaButton.Name = "guardarFacturaButton";
            this.guardarFacturaButton.Size = new System.Drawing.Size(150, 30);
            this.guardarFacturaButton.TabIndex = 5;
            this.guardarFacturaButton.Text = "Guardar Factura";
            this.guardarFacturaButton.UseVisualStyleBackColor = true;
            this.guardarFacturaButton.Click += new System.EventHandler(this.GuardarFacturaButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(400, 355);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 6;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // impuestoLabel
            // 
            this.impuestoLabel.AutoSize = true;
            this.impuestoLabel.Location = new System.Drawing.Point(400, 379);
            this.impuestoLabel.Name = "impuestoLabel";
            this.impuestoLabel.Size = new System.Drawing.Size(50, 13);
            this.impuestoLabel.TabIndex = 7;
            this.impuestoLabel.Text = "Impuesto";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(400, 405);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(150, 30);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(150, 21);
            this.clienteComboBox.TabIndex = 9;
            // 
            // empleadoComboBox
            // 
            this.empleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empleadoComboBox.FormattingEnabled = true;
            this.empleadoComboBox.Location = new System.Drawing.Point(150, 60);
            this.empleadoComboBox.Name = "empleadoComboBox";
            this.empleadoComboBox.Size = new System.Drawing.Size(150, 21);
            this.empleadoComboBox.TabIndex = 10;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(50, 33);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(53, 13);
            this.clienteLabel.TabIndex = 11;
            this.clienteLabel.Text = "ID Cliente";
            // 
            // empleadoLabel
            // 
            this.empleadoLabel.AutoSize = true;
            this.empleadoLabel.Location = new System.Drawing.Point(50, 63);
            this.empleadoLabel.Name = "empleadoLabel";
            this.empleadoLabel.Size = new System.Drawing.Size(68, 13);
            this.empleadoLabel.TabIndex = 12;
            this.empleadoLabel.Text = "ID Empleado";
            // 
            // facIdTextBox
            // 
            this.facIdTextBox.Location = new System.Drawing.Point(150, 90);
            this.facIdTextBox.Name = "facIdTextBox";
            this.facIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.facIdTextBox.TabIndex = 13;
            // 
            // facFechTextBox
            // 
            this.facFechTextBox.Location = new System.Drawing.Point(150, 120);
            this.facFechTextBox.Name = "facFechTextBox";
            this.facFechTextBox.Size = new System.Drawing.Size(100, 20);
            this.facFechTextBox.TabIndex = 14;
            // 
            // facIdLabel
            // 
            this.facIdLabel.Location = new System.Drawing.Point(50, 93);
            this.facIdLabel.Name = "facIdLabel";
            this.facIdLabel.Size = new System.Drawing.Size(100, 23);
            this.facIdLabel.TabIndex = 18;
            // 
            // facFechLabel
            // 
            this.facFechLabel.AutoSize = true;
            this.facFechLabel.Location = new System.Drawing.Point(50, 123);
            this.facFechLabel.Name = "facFechLabel";
            this.facFechLabel.Size = new System.Drawing.Size(58, 13);
            this.facFechLabel.TabIndex = 16;
            this.facFechLabel.Text = "Fecha Fac";
            // 
            // consultaButton
            // 
            this.consultaButton.Location = new System.Drawing.Point(244, 450);
            this.consultaButton.Name = "consultaButton";
            this.consultaButton.Size = new System.Drawing.Size(150, 30);
            this.consultaButton.TabIndex = 17;
            this.consultaButton.Text = "Consultar Factura";
            this.consultaButton.UseVisualStyleBackColor = true;
            this.consultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Factura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FacturaForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultaButton);
            this.Controls.Add(this.facFechLabel);
            this.Controls.Add(this.facIdLabel);
            this.Controls.Add(this.facFechTextBox);
            this.Controls.Add(this.facIdTextBox);
            this.Controls.Add(this.empleadoLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.empleadoComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.impuestoLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.guardarFacturaButton);
            this.Controls.Add(this.agregarProductoButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.productosDataGridView);
            this.Name = "FacturaForm";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}