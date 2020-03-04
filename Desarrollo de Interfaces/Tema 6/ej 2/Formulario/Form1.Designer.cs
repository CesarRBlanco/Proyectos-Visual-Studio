namespace Formulario
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
            this.etiquetaAviso2 = new Formulario.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.ColorFinal = System.Drawing.Color.Red;
            this.etiquetaAviso2.ColorInicial = System.Drawing.Color.Aqua;
            this.etiquetaAviso2.Gradiente = true;
            this.etiquetaAviso2.Image = global::Formulario.Properties.Resources._1;
            this.etiquetaAviso2.Location = new System.Drawing.Point(233, 36);
            this.etiquetaAviso2.Marca = Formulario.eMarca.Imagen;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(91, 13);
            this.etiquetaAviso2.TabIndex = 0;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            this.etiquetaAviso2.ClickEnMarca += new System.EventHandler(this.EtiquetaAviso1_ClickEnMarca_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 304);
            this.Controls.Add(this.etiquetaAviso2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "HOLA";
            this.ResumeLayout(false);

        }

        #endregion

        private EtiquetaAviso etiquetaAviso1;
        private EtiquetaAviso etiquetaAviso2;
    }
}

