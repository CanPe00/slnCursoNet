namespace WindowsApp
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
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnClienteIndividuo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.RosyBrown;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Location = new System.Drawing.Point(92, 75);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(303, 35);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Crear Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnClienteIndividuo
            // 
            this.btnClienteIndividuo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClienteIndividuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteIndividuo.Location = new System.Drawing.Point(92, 177);
            this.btnClienteIndividuo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClienteIndividuo.Name = "btnClienteIndividuo";
            this.btnClienteIndividuo.Size = new System.Drawing.Size(303, 35);
            this.btnClienteIndividuo.TabIndex = 1;
            this.btnClienteIndividuo.Text = "Crear Cliente Individuo";
            this.btnClienteIndividuo.UseVisualStyleBackColor = false;
            this.btnClienteIndividuo.Click += new System.EventHandler(this.btnClienteIndividuo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 298);
            this.Controls.Add(this.btnClienteIndividuo);
            this.Controls.Add(this.btnProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candela Perez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnClienteIndividuo;
    }
}

