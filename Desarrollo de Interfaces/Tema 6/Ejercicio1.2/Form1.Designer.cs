namespace Ejercicio1._2
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
            this.laebelTextBox1 = new Ejercicio1._2.LaebelTextBox();
            this.laebelTextBox2 = new Ejercicio1._2.LaebelTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // laebelTextBox1
            // 
            this.laebelTextBox1.Location = new System.Drawing.Point(87, 93);
            this.laebelTextBox1.Name = "laebelTextBox1";
            this.laebelTextBox1.Posicion = Ejercicio1._2.LaebelTextBox.ePosicion.IZQUIERDA;
            this.laebelTextBox1.PswChr = '\0';
            this.laebelTextBox1.Separacion = 0;
            this.laebelTextBox1.Size = new System.Drawing.Size(150, 20);
            this.laebelTextBox1.TabIndex = 2;
            this.laebelTextBox1.TextLbl = "label1";
            this.laebelTextBox1.TextTextBox = "";
            this.laebelTextBox1.CambiarPosicion += new System.EventHandler(this.LaebelTextBox1_CambiarPosicion);
            this.laebelTextBox1.CambiaSeparacion += new System.EventHandler(this.LaebelTextBox1_CambiaSeparacion);
            this.laebelTextBox1.CambiarTexto += new System.EventHandler(this.LaebelTextBox1_CambiarTexto);
            this.laebelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LaebelTextBox1_KeyUp);
            // 
            // laebelTextBox2
            // 
            this.laebelTextBox2.Location = new System.Drawing.Point(265, 93);
            this.laebelTextBox2.Name = "laebelTextBox2";
            this.laebelTextBox2.Posicion = Ejercicio1._2.LaebelTextBox.ePosicion.IZQUIERDA;
            this.laebelTextBox2.PswChr = 'O';
            this.laebelTextBox2.Separacion = 0;
            this.laebelTextBox2.Size = new System.Drawing.Size(150, 20);
            this.laebelTextBox2.TabIndex = 3;
            this.laebelTextBox2.TextLbl = "label1";
            this.laebelTextBox2.TextTextBox = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laebelTextBox2);
            this.Controls.Add(this.laebelTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private LaebelTextBox laebelTextBox1;
        private LaebelTextBox laebelTextBox2;
    }
}

