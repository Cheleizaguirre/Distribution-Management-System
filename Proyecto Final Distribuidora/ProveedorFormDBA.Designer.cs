namespace Proyecto_Final_Distribuidora
{
    partial class ProveedorFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox emaiTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label emaiLabel;

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
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.emaiTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.emaiLabel = new System.Windows.Forms.Label();
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
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(150, 100);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 5;

            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(150, 150);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(200, 20);
            this.telTextBox.TabIndex = 6;

            // 
            // emaiTextBox
            // 
            this.emaiTextBox.Location = new System.Drawing.Point(150, 200);
            this.emaiTextBox.Name = "emaiTextBox";
            this.emaiTextBox.Size = new System.Drawing.Size(200, 20);
            this.emaiTextBox.TabIndex = 7;

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
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(50, 100);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(50, 13);
            this.nomLabel.TabIndex = 9;
            this.nomLabel.Text = "Nombre:";

            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(50, 150);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(39, 13);
            this.telLabel.TabIndex = 10;
            this.telLabel.Text = "Teléfono:";

            // 
            // emaiLabel
            // 
            this.emaiLabel.AutoSize = true;
            this.emaiLabel.Location = new System.Drawing.Point(50, 200);
            this.emaiLabel.Name = "emaiLabel";
            this.emaiLabel.Size = new System.Drawing.Size(41, 13);
            this.emaiLabel.TabIndex = 11;
            this.emaiLabel.Text = "Email:";

            // 
            // ProveedorFormDBA
            // 
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.emaiLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.emaiTextBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ingresarButton);
            this.Name = "ProveedorFormDBA";
            this.Text = "Proveedor Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}