namespace Formulario02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customControl11 = new Formulario02.CustomControl1();
            this.SuspendLayout();
            // 
            // customControl11
            // 
            this.customControl11.ColorFinal = System.Drawing.Color.Black;
            this.customControl11.ColorInicial = System.Drawing.Color.Yellow;
            this.customControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customControl11.Gradient = true;
            this.customControl11.Image = ((System.Drawing.Image)(resources.GetObject("customControl11.Image")));
            this.customControl11.Location = new System.Drawing.Point(85, 111);
            this.customControl11.Marca = Formulario02.eMarca.Imagen;
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(263, 120);
            this.customControl11.TabIndex = 0;
            this.customControl11.Text = "illo";
            this.customControl11.ClickEnMarca += new System.EventHandler(this.customControl11_ClickEnMarca);
            this.customControl11.Click += new System.EventHandler(this.customControl11_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl1 customControl11;
    }
}

