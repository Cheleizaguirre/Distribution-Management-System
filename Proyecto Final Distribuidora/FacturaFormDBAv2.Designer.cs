namespace Proyecto_Final_Distribuidora
{
    partial class FacturaFormDBAv2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox facIdTextBox;
        private System.Windows.Forms.ComboBox cliComboBox;
        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.TextBox subtTextBox;
        private System.Windows.Forms.TextBox impuTextBox;
        private System.Windows.Forms.TextBox totaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label facIdLabel;
        private System.Windows.Forms.Label cliLabel;
        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.Label subtLabel;
        private System.Windows.Forms.Label impuLabel;
        private System.Windows.Forms.Label totaLabel;
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
            this.consultarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.facIdTextBox = new System.Windows.Forms.TextBox();
            this.cliComboBox = new System.Windows.Forms.ComboBox();
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.subtTextBox = new System.Windows.Forms.TextBox();
            this.impuTextBox = new System.Windows.Forms.TextBox();
            this.totaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.facIdLabel = new System.Windows.Forms.Label();
            this.cliLabel = new System.Windows.Forms.Label();
            this.empLabel = new System.Windows.Forms.Label();
            this.subtLabel = new System.Windows.Forms.Label();
            this.impuLabel = new System.Windows.Forms.Label();
            this.totaLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(150, 376);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(100, 30);
            this.consultarButton.TabIndex = 0;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(299, 376);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(100, 30);
            this.modificarButton.TabIndex = 1;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(445, 376);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(100, 30);
            this.eliminarButton.TabIndex = 2;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // facIdTextBox
            // 
            this.facIdTextBox.Location = new System.Drawing.Point(150, 50);
            this.facIdTextBox.Name = "facIdTextBox";
            this.facIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.facIdTextBox.TabIndex = 3;
            // 
            // cliComboBox
            // 
            this.cliComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cliComboBox.FormattingEnabled = true;
            this.cliComboBox.Location = new System.Drawing.Point(150, 100);
            this.cliComboBox.Name = "cliComboBox";
            this.cliComboBox.Size = new System.Drawing.Size(200, 21);
            this.cliComboBox.TabIndex = 4;
            // 
            // empComboBox
            // 
            this.empComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empComboBox.FormattingEnabled = true;
            this.empComboBox.Location = new System.Drawing.Point(150, 150);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(200, 21);
            this.empComboBox.TabIndex = 5;
            // 
            // subtTextBox
            // 
            this.subtTextBox.Location = new System.Drawing.Point(150, 200);
            this.subtTextBox.Name = "subtTextBox";
            this.subtTextBox.Size = new System.Drawing.Size(200, 20);
            this.subtTextBox.TabIndex = 6;
            // 
            // impuTextBox
            // 
            this.impuTextBox.Location = new System.Drawing.Point(150, 250);
            this.impuTextBox.Name = "impuTextBox";
            this.impuTextBox.Size = new System.Drawing.Size(200, 20);
            this.impuTextBox.TabIndex = 7;
            // 
            // totaTextBox
            // 
            this.totaTextBox.Location = new System.Drawing.Point(150, 300);
            this.totaTextBox.Name = "totaTextBox";
            this.totaTextBox.Size = new System.Drawing.Size(200, 20);
            this.totaTextBox.TabIndex = 8;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(150, 350);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 9;
            // 
            // facIdLabel
            // 
            this.facIdLabel.AutoSize = true;
            this.facIdLabel.Location = new System.Drawing.Point(50, 53);
            this.facIdLabel.Name = "facIdLabel";
            this.facIdLabel.Size = new System.Drawing.Size(21, 13);
            this.facIdLabel.TabIndex = 10;
            this.facIdLabel.Text = "ID:";
            // 
            // cliLabel
            // 
            this.cliLabel.AutoSize = true;
            this.cliLabel.Location = new System.Drawing.Point(50, 103);
            this.cliLabel.Name = "cliLabel";
            this.cliLabel.Size = new System.Drawing.Size(56, 13);
            this.cliLabel.TabIndex = 11;
            this.cliLabel.Text = "ID Cliente:";
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Location = new System.Drawing.Point(50, 153);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(71, 13);
            this.empLabel.TabIndex = 12;
            this.empLabel.Text = "ID Empleado:";
            // 
            // subtLabel
            // 
            this.subtLabel.AutoSize = true;
            this.subtLabel.Location = new System.Drawing.Point(50, 203);
            this.subtLabel.Name = "subtLabel";
            this.subtLabel.Size = new System.Drawing.Size(49, 13);
            this.subtLabel.TabIndex = 13;
            this.subtLabel.Text = "Subtotal:";
            // 
            // impuLabel
            // 
            this.impuLabel.AutoSize = true;
            this.impuLabel.Location = new System.Drawing.Point(50, 253);
            this.impuLabel.Name = "impuLabel";
            this.impuLabel.Size = new System.Drawing.Size(53, 13);
            this.impuLabel.TabIndex = 14;
            this.impuLabel.Text = "Impuesto:";
            // 
            // totaLabel
            // 
            this.totaLabel.AutoSize = true;
            this.totaLabel.Location = new System.Drawing.Point(50, 303);
            this.totaLabel.Name = "totaLabel";
            this.totaLabel.Size = new System.Drawing.Size(34, 13);
            this.totaLabel.TabIndex = 15;
            this.totaLabel.Text = "Total:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(50, 356);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(40, 13);
            this.fechaLabel.TabIndex = 16;
            this.fechaLabel.Text = "Fecha:";
            // 
            // FacturaFormDBAv2
            // 
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.totaLabel);
            this.Controls.Add(this.impuLabel);
            this.Controls.Add(this.subtLabel);
            this.Controls.Add(this.empLabel);
            this.Controls.Add(this.cliLabel);
            this.Controls.Add(this.facIdLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.totaTextBox);
            this.Controls.Add(this.impuTextBox);
            this.Controls.Add(this.subtTextBox);
            this.Controls.Add(this.empComboBox);
            this.Controls.Add(this.cliComboBox);
            this.Controls.Add(this.facIdTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultarButton);
            this.Name = "FacturaFormDBAv2";
            this.Text = "Formulario de Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}