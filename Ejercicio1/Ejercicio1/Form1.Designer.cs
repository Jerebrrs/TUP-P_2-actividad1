namespace Ejercicio1
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
            this.btnConstruir = new System.Windows.Forms.Button();
            this.tbDescribir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConstruir
            // 
            this.btnConstruir.Location = new System.Drawing.Point(623, 155);
            this.btnConstruir.Name = "btnConstruir";
            this.btnConstruir.Size = new System.Drawing.Size(104, 54);
            this.btnConstruir.TabIndex = 1;
            this.btnConstruir.Text = "Construir y Definir Objetos";
            this.btnConstruir.UseVisualStyleBackColor = true;
            this.btnConstruir.Click += new System.EventHandler(this.btnConstruir_Click);
            // 
            // tbDescribir
            // 
            this.tbDescribir.Location = new System.Drawing.Point(49, 66);
            this.tbDescribir.Multiline = true;
            this.tbDescribir.Name = "tbDescribir";
            this.tbDescribir.Size = new System.Drawing.Size(475, 222);
            this.tbDescribir.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDescribir);
            this.Controls.Add(this.btnConstruir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConstruir;
        private System.Windows.Forms.TextBox tbDescribir;
    }
}

