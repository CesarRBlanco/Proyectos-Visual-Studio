namespace Ex_01_DI
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelTextbox = new Ex_01_DI.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTextbox
            // 
            this.labelTextbox.Location = new System.Drawing.Point(53, 54);
            this.labelTextbox.Name = "labelTextbox";
            this.labelTextbox.Posicion = Ex_01_DI.UserControl1.ePosicion.IZQUIERDA;
            this.labelTextbox.Separacion = 0;
            this.labelTextbox.Size = new System.Drawing.Size(266, 20);
            this.labelTextbox.TabIndex = 0;
            this.labelTextbox.TextLbl = "UserControl1";
            this.labelTextbox.TextTxt = "";
            this.labelTextbox.CambioPosicion += new System.EventHandler(this.LabelTextbox_CambioPosicion);
            this.labelTextbox.CambioSeparacion += new System.EventHandler(this.labelTextbox_CambioSeparacion);
            this.labelTextbox.TxtChanged += new System.EventHandler(this.labelTextbox_TxtChanged);
            this.labelTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextbox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ex_01_DI.UserControl1 labelTextbox;
        private System.Windows.Forms.Button button1;
    }
}

