namespace Proyecto_Final_Distribuidora
{
    partial class BodegaFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombTextBox;
        private System.Windows.Forms.TextBox direTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nombLabel;
        private System.Windows.Forms.Label direLabel;

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
            this.direTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nombLabel = new System.Windows.Forms.Label();
            this.direLabel = new System.Windows.Forms.Label();
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
            // nombTextBox
            // 
            this.nombTextBox.Location = new System.Drawing.Point(150, 100);
            this.nombTextBox.Name = "nombTextBox";
            this.nombTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombTextBox.TabIndex = 5;

            // 
            // direTextBox
            // 
            this.direTextBox.Location = new System.Drawing.Point(150, 150);
            this.direTextBox.Name = "direTextBox";
            this.direTextBox.Size = new System.Drawing.Size(200, 20);
            this.direTextBox.TabIndex = 6;

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
            // nombLabel
            // 
            this.nombLabel.AutoSize = true;
            this.nombLabel.Location = new System.Drawing.Point(50, 100);
            this.nombLabel.Name = "nombLabel";
            this.nombLabel.Size = new System.Drawing.Size(47, 13);
            this.nombLabel.TabIndex = 8;
            this.nombLabel.Text = "Nombre:";

            // 
            // direLabel
            // 
            this.direLabel.AutoSize = true;
            this.direLabel.Location = new System.Drawing.Point(50, 150);
            this.direLabel.Name = "direLabel";
            this.direLabel.Size = new System.Drawing.Size(55, 13);
            this.direLabel.TabIndex = 9;
            this.direLabel.Text = "Dirección:";

            // 
            // BodegaFormDBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.direLabel);
            this.Controls.Add(this.nombLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.direTextBox);
            this.Controls.Add(this.nombTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ingresarButton);
            this.Name = "BodegaFormDBA";
            this.Text = "Gestión de Bodega";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}