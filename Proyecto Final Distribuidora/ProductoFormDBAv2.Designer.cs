namespace Proyecto_Final_Distribuidora
{
    partial class ProductoFormDBAv2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombTextBox;
        private System.Windows.Forms.TextBox precTextBox;
        private System.Windows.Forms.ComboBox bodIdComboBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nombLabel;
        private System.Windows.Forms.Label precLabel;
        private System.Windows.Forms.Label bodIdLabel;

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
            this.nombTextBox = new System.Windows.Forms.TextBox();
            this.precTextBox = new System.Windows.Forms.TextBox();
            this.bodIdComboBox = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nombLabel = new System.Windows.Forms.Label();
            this.precLabel = new System.Windows.Forms.Label();
            this.bodIdLabel = new System.Windows.Forms.Label();
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
            // nombTextBox
            // 
            this.nombTextBox.Location = new System.Drawing.Point(150, 100);
            this.nombTextBox.Name = "nombTextBox";
            this.nombTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombTextBox.TabIndex = 5;

            // 
            // precTextBox
            // 
            this.precTextBox.Location = new System.Drawing.Point(150, 150);
            this.precTextBox.Name = "precTextBox";
            this.precTextBox.Size = new System.Drawing.Size(200, 20);
            this.precTextBox.TabIndex = 6;

            // 
            // bodIdComboBox
            // 
            this.bodIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodIdComboBox.FormattingEnabled = true;
            this.bodIdComboBox.Location = new System.Drawing.Point(150, 200);
            this.bodIdComboBox.Name = "bodIdComboBox";
            this.bodIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.bodIdComboBox.TabIndex = 7;

            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(50, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";

            // 
            // nombLabel
            // 
            this.nombLabel.AutoSize = true;
            this.nombLabel.Location = new System.Drawing.Point(50, 100);
            this.nombLabel.Name = "nombLabel";
            this.nombLabel.Size = new System.Drawing.Size(79, 13);
            this.nombLabel.TabIndex = 9;
            this.nombLabel.Text = "Nombre Prod:";

            // 
            // precLabel
            // 
            this.precLabel.AutoSize = true;
            this.precLabel.Location = new System.Drawing.Point(50, 150);
            this.precLabel.Name = "precLabel";
            this.precLabel.Size = new System.Drawing.Size(38, 13);
            this.precLabel.TabIndex = 10;
            this.precLabel.Text = "Precio:";

            // 
            // bodIdLabel
            // 
            this.bodIdLabel.AutoSize = true;
            this.bodIdLabel.Location = new System.Drawing.Point(50, 200);
            this.bodIdLabel.Name = "bodIdLabel";
            this.bodIdLabel.Size = new System.Drawing.Size(48, 13);
            this.bodIdLabel.TabIndex = 11;
            this.bodIdLabel.Text = "Bodega:";

            // 
            // ProductoFormDBAv2
            // 
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.bodIdLabel);
            this.Controls.Add(this.precLabel);
            this.Controls.Add(this.nombLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.bodIdComboBox);
            this.Controls.Add(this.precTextBox);
            this.Controls.Add(this.nombTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ingresarButton);
            this.Name = "ProductoFormDBAv2";
            this.Text = "Gestión de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}