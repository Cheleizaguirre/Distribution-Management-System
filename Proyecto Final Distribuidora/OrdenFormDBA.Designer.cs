namespace Proyecto_Final_Distribuidora
{
    partial class OrdenFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox provComboBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label provLabel;
        private System.Windows.Forms.Label fechaLabel;

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
            this.provComboBox = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idLabel = new System.Windows.Forms.Label();
            this.provLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(50, 350);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(100, 30);
            this.ingresarButton.TabIndex = 0;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.IngresarButton_Click);

            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(200, 350);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(100, 30);
            this.consultarButton.TabIndex = 1;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);

            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(350, 350);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(100, 30);
            this.modificarButton.TabIndex = 2;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.ModificarButton_Click);

            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(500, 350);
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
            // provComboBox
            // 
            this.provComboBox.FormattingEnabled = true;
            this.provComboBox.Location = new System.Drawing.Point(150, 100);
            this.provComboBox.Name = "provComboBox";
            this.provComboBox.Size = new System.Drawing.Size(200, 21);
            this.provComboBox.TabIndex = 5;

            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(150, 150);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 6;

            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(50, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";

            // 
            // provLabel
            // 
            this.provLabel.AutoSize = true;
            this.provLabel.Location = new System.Drawing.Point(50, 100);
            this.provLabel.Name = "provLabel";
            this.provLabel.Size = new System.Drawing.Size(55, 13);
            this.provLabel.TabIndex = 8;
            this.provLabel.Text = "Proveedor:";

            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(50, 150);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(41, 13);
            this.fechaLabel.TabIndex = 9;
            this.fechaLabel.Text = "Fecha:";

            // 
            // OrdenFormDBA
            // 
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.provLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.provComboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ingresarButton);
            this.Name = "OrdenFormDBA";
            this.Text = "Gestión de Ordenes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}