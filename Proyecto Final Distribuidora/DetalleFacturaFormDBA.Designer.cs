namespace Proyecto_Final_Distribuidora
{
    partial class DetalleFacturaFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox facIdTextBox;
        private System.Windows.Forms.ComboBox prodComboBox;
        private System.Windows.Forms.TextBox cantTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label facIdLabel;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.Label cantLabel;

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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.facIdTextBox = new System.Windows.Forms.TextBox();
            this.prodComboBox = new System.Windows.Forms.ComboBox();
            this.cantTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.facIdLabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.cantLabel = new System.Windows.Forms.Label();
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
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(150, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // facIdTextBox
            // 
            this.facIdTextBox.Location = new System.Drawing.Point(150, 100);
            this.facIdTextBox.Name = "facIdTextBox";
            this.facIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.facIdTextBox.TabIndex = 5;
            // 
            // prodComboBox
            // 
            this.prodComboBox.FormattingEnabled = true;
            this.prodComboBox.Location = new System.Drawing.Point(150, 150);
            this.prodComboBox.Name = "prodComboBox";
            this.prodComboBox.Size = new System.Drawing.Size(200, 21);
            this.prodComboBox.TabIndex = 6;
            // 
            // cantTextBox
            // 
            this.cantTextBox.Location = new System.Drawing.Point(150, 200);
            this.cantTextBox.Name = "cantTextBox";
            this.cantTextBox.Size = new System.Drawing.Size(200, 20);
            this.cantTextBox.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(50, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID Detalle:";
            // 
            // facIdLabel
            // 
            this.facIdLabel.AutoSize = true;
            this.facIdLabel.Location = new System.Drawing.Point(50, 100);
            this.facIdLabel.Name = "facIdLabel";
            this.facIdLabel.Size = new System.Drawing.Size(60, 13);
            this.facIdLabel.TabIndex = 9;
            this.facIdLabel.Text = "ID Factura:";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Location = new System.Drawing.Point(50, 150);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(67, 13);
            this.prodLabel.TabIndex = 10;
            this.prodLabel.Text = "ID Producto:";
            // 
            // cantLabel
            // 
            this.cantLabel.AutoSize = true;
            this.cantLabel.Location = new System.Drawing.Point(50, 200);
            this.cantLabel.Name = "cantLabel";
            this.cantLabel.Size = new System.Drawing.Size(52, 13);
            this.cantLabel.TabIndex = 11;
            this.cantLabel.Text = "Cantidad:";
            // 
            // DetalleFacturaFormDBA
            // 
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.facIdLabel);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.cantLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.facIdTextBox);
            this.Controls.Add(this.prodComboBox);
            this.Controls.Add(this.cantTextBox);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.eliminarButton);
            this.Name = "DetalleFacturaFormDBA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}