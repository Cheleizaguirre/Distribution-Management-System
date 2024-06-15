namespace Proyecto_Final_Distribuidora
{
    partial class ProductoFormDBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.Button seleccionarButton;

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
            this.seleccionarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.Size = new System.Drawing.Size(776, 350);
            this.productosDataGridView.TabIndex = 0;
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Location = new System.Drawing.Point(713, 368);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.seleccionarButton.TabIndex = 1;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.seleccionarButton_Click);
            // 
            // ProductoFormDBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seleccionarButton);
            this.Controls.Add(this.productosDataGridView);
            this.Name = "ProductoFormDBA";
            this.Text = "ProductoFormDBA";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}