namespace Proyecto_Final_Distribuidora
{
    partial class EmpleadoFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pnomTextBox;
        private System.Windows.Forms.TextBox papeTextBox;
        private System.Windows.Forms.TextBox telfTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pnomLabel;
        private System.Windows.Forms.Label papeLabel;
        private System.Windows.Forms.Label telfLabel;

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
            this.pnomTextBox = new System.Windows.Forms.TextBox();
            this.papeTextBox = new System.Windows.Forms.TextBox();
            this.telfTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pnomLabel = new System.Windows.Forms.Label();
            this.papeLabel = new System.Windows.Forms.Label();
            this.telfLabel = new System.Windows.Forms.Label();
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
            // pnomTextBox
            // 
            this.pnomTextBox.Location = new System.Drawing.Point(150, 100);
            this.pnomTextBox.Name = "pnomTextBox";
            this.pnomTextBox.Size = new System.Drawing.Size(200, 20);
            this.pnomTextBox.TabIndex = 5;

            // 
            // papeTextBox
            // 
            this.papeTextBox.Location = new System.Drawing.Point(150, 150);
            this.papeTextBox.Name = "papeTextBox";
            this.papeTextBox.Size = new System.Drawing.Size(200, 20);
            this.papeTextBox.TabIndex = 6;

            // 
            // telfTextBox
            // 
            this.telfTextBox.Location = new System.Drawing.Point(150, 200);
            this.telfTextBox.Name = "telfTextBox";
            this.telfTextBox.Size = new System.Drawing.Size(200, 20);
            this.telfTextBox.TabIndex = 7;

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
            // pnomLabel
            // 
            this.pnomLabel.AutoSize = true;
            this.pnomLabel.Location = new System.Drawing.Point(50, 100);
            this.pnomLabel.Name = "pnomLabel";
            this.pnomLabel.Size = new System.Drawing.Size(44, 13);
            this.pnomLabel.TabIndex = 9;
            this.pnomLabel.Text = "Nombre:";

            // 
            // papeLabel
            // 
            this.papeLabel.AutoSize = true;
            this.papeLabel.Location = new System.Drawing.Point(50, 150);
            this.papeLabel.Name = "papeLabel";
            this.papeLabel.Size = new System.Drawing.Size(44, 13);
            this.papeLabel.TabIndex = 10;
            this.papeLabel.Text = "Apellido:";

            // 
            // telfLabel
            // 
            this.telfLabel.AutoSize = true;
            this.telfLabel.Location = new System.Drawing.Point(50, 200);
            this.telfLabel.Name = "telfLabel";
            this.telfLabel.Size = new System.Drawing.Size(52, 13);
            this.telfLabel.TabIndex = 11;
            this.telfLabel.Text = "Teléfono:";

            // 
            // EmpleadoFormDBA
            // 
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pnomTextBox);
            this.Controls.Add(this.papeTextBox);
            this.Controls.Add(this.telfTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.pnomLabel);
            this.Controls.Add(this.papeLabel);
            this.Controls.Add(this.telfLabel);
            this.Name = "EmpleadoFormDBA";
            this.Text = "Formulario de Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}