namespace Proyecto_Final_Distribuidora
{
    partial class DetalleOrdenFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox detoIdTextBox;
        private System.Windows.Forms.ComboBox prodIdComboBox;
        private System.Windows.Forms.ComboBox ordIdComboBox;
        private System.Windows.Forms.TextBox detoCantTextBox;
        private System.Windows.Forms.Label detoIdLabel;
        private System.Windows.Forms.Label prodIdLabel;
        private System.Windows.Forms.Label ordIdLabel;
        private System.Windows.Forms.Label detoCantLabel;

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
            this.ingresarButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.detoIdTextBox = new System.Windows.Forms.TextBox();
            this.prodIdComboBox = new System.Windows.Forms.ComboBox();
            this.ordIdComboBox = new System.Windows.Forms.ComboBox();
            this.detoCantTextBox = new System.Windows.Forms.TextBox();
            this.detoIdLabel = new System.Windows.Forms.Label();
            this.prodIdLabel = new System.Windows.Forms.Label();
            this.ordIdLabel = new System.Windows.Forms.Label();
            this.detoCantLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(50, 250);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(100, 30);
            this.ingresarButton.TabIndex = 0;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.IngresarButton_Click);

            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(200, 250);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(100, 30);
            this.consultarButton.TabIndex = 1;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);

            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(350, 250);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(100, 30);
            this.modificarButton.TabIndex = 2;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.ModificarButton_Click);

            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(500, 250);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(100, 30);
            this.eliminarButton.TabIndex = 3;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);

            // 
            // detoIdTextBox
            // 
            this.detoIdTextBox.Location = new System.Drawing.Point(150, 50);
            this.detoIdTextBox.Name = "detoIdTextBox";
            this.detoIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.detoIdTextBox.TabIndex = 4;

            // 
            // prodIdComboBox
            // 
            this.prodIdComboBox.FormattingEnabled = true;
            this.prodIdComboBox.Location = new System.Drawing.Point(150, 90);
            this.prodIdComboBox.Name = "prodIdComboBox";
            this.prodIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.prodIdComboBox.TabIndex = 5;

            // 
            // ordIdComboBox
            // 
            this.ordIdComboBox.FormattingEnabled = true;
            this.ordIdComboBox.Location = new System.Drawing.Point(150, 130);
            this.ordIdComboBox.Name = "ordIdComboBox";
            this.ordIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.ordIdComboBox.TabIndex = 6;

            // 
            // detoCantTextBox
            // 
            this.detoCantTextBox.Location = new System.Drawing.Point(150, 170);
            this.detoCantTextBox.Name = "detoCantTextBox";
            this.detoCantTextBox.Size = new System.Drawing.Size(200, 20);
            this.detoCantTextBox.TabIndex = 7;

            // 
            // detoIdLabel
            // 
            this.detoIdLabel.AutoSize = true;
            this.detoIdLabel.Location = new System.Drawing.Point(50, 53);
            this.detoIdLabel.Name = "detoIdLabel";
            this.detoIdLabel.Size = new System.Drawing.Size(48, 13);
            this.detoIdLabel.TabIndex = 8;
            this.detoIdLabel.Text = "ID Detalle";

            // 
            // prodIdLabel
            // 
            this.prodIdLabel.AutoSize = true;
            this.prodIdLabel.Location = new System.Drawing.Point(50, 93);
            this.prodIdLabel.Name = "prodIdLabel";
            this.prodIdLabel.Size = new System.Drawing.Size(43, 13);
            this.prodIdLabel.TabIndex = 9;
            this.prodIdLabel.Text = "ID Producto";

            // 
            // ordIdLabel
            // 
            this.ordIdLabel.AutoSize = true;
            this.ordIdLabel.Location = new System.Drawing.Point(50, 133);
            this.ordIdLabel.Name = "ordIdLabel";
            this.ordIdLabel.Size = new System.Drawing.Size(54, 13);
            this.ordIdLabel.TabIndex = 10;
            this.ordIdLabel.Text = "ID Orden";

            // 
            // detoCantLabel
            // 
            this.detoCantLabel.AutoSize = true;
            this.detoCantLabel.Location = new System.Drawing.Point(50, 173);
            this.detoCantLabel.Name = "detoCantLabel";
            this.detoCantLabel.Size = new System.Drawing.Size(70, 13);
            this.detoCantLabel.TabIndex = 11;
            this.detoCantLabel.Text = "Cantidad";

            // 
            // DetalleOrdenFormDBA
            // 
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.detoCantLabel);
            this.Controls.Add(this.ordIdLabel);
            this.Controls.Add(this.prodIdLabel);
            this.Controls.Add(this.detoIdLabel);
            this.Controls.Add(this.detoCantTextBox);
            this.Controls.Add(this.ordIdComboBox);
            this.Controls.Add(this.prodIdComboBox);
            this.Controls.Add(this.detoIdTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ingresarButton);
            this.Name = "DetalleOrdenFormDBA";
            this.Text = "Detalle de Orden";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}