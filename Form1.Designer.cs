namespace por_ciento_de_descuento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTotal = new System.Windows.Forms.Button();
            this.cboDescuento = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMiMetodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.Red;
            this.btnTotal.Location = new System.Drawing.Point(365, 99);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 34);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.Text = "=";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cboDescuento
            // 
            this.cboDescuento.FormattingEnabled = true;
            this.cboDescuento.Items.AddRange(new object[] {
            "0.05",
            "0.15",
            "0.3",
            "0.5",
            "0.7"});
            this.cboDescuento.Location = new System.Drawing.Point(258, 108);
            this.cboDescuento.Name = "cboDescuento";
            this.cboDescuento.Size = new System.Drawing.Size(82, 21);
            this.cboDescuento.TabIndex = 2;
            // 
            // numPrecio
            // 
            this.numPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecio.Location = new System.Drawing.Point(85, 94);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(97, 38);
            this.numPrecio.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(455, 108);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = ".";
            // 
            // btnMiMetodo
            // 
            this.btnMiMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiMetodo.Location = new System.Drawing.Point(188, 100);
            this.btnMiMetodo.Name = "btnMiMetodo";
            this.btnMiMetodo.Size = new System.Drawing.Size(53, 33);
            this.btnMiMetodo.TabIndex = 13;
            this.btnMiMetodo.Text = "-";
            this.btnMiMetodo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMiMetodo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.cboDescuento);
            this.Controls.Add(this.btnTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ComboBox cboDescuento;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMiMetodo;
    }
}

