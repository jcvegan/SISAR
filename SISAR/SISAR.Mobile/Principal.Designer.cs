namespace SISAR.Mobile
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.btnTomarOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarStock
            // 
            this.btnConsultarStock.Location = new System.Drawing.Point(66, 66);
            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.Size = new System.Drawing.Size(108, 55);
            this.btnConsultarStock.TabIndex = 0;
            this.btnConsultarStock.Text = "Consultar Stock";
            this.btnConsultarStock.Click += new System.EventHandler(this.btnConsultarStock_Click);
            // 
            // btnTomarOrden
            // 
            this.btnTomarOrden.Location = new System.Drawing.Point(66, 148);
            this.btnTomarOrden.Name = "btnTomarOrden";
            this.btnTomarOrden.Size = new System.Drawing.Size(108, 55);
            this.btnTomarOrden.TabIndex = 1;
            this.btnTomarOrden.Text = "Tomar Orden";
            this.btnTomarOrden.Click += new System.EventHandler(this.btnTomarOrden_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnTomarOrden);
            this.Controls.Add(this.btnConsultarStock);
            this.Menu = this.mainMenu1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.Button btnTomarOrden;
    }
}