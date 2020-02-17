namespace ServEx05
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
            this._txtboxPatron = new System.Windows.Forms.TextBox();
            this._txtboxDirectory = new System.Windows.Forms.TextBox();
            this._txtboxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtboxPatron
            // 
            this._txtboxPatron.Location = new System.Drawing.Point(323, 63);
            this._txtboxPatron.Name = "_txtboxPatron";
            this._txtboxPatron.Size = new System.Drawing.Size(100, 20);
            this._txtboxPatron.TabIndex = 0;
            // 
            // _txtboxDirectory
            // 
            this._txtboxDirectory.Location = new System.Drawing.Point(39, 63);
            this._txtboxDirectory.Name = "_txtboxDirectory";
            this._txtboxDirectory.Size = new System.Drawing.Size(100, 20);
            this._txtboxDirectory.TabIndex = 1;
            // 
            // _txtboxResult
            // 
            this._txtboxResult.Location = new System.Drawing.Point(50, 153);
            this._txtboxResult.Multiline = true;
            this._txtboxResult.Name = "_txtboxResult";
            this._txtboxResult.Size = new System.Drawing.Size(313, 199);
            this._txtboxResult.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._txtboxResult);
            this.Controls.Add(this._txtboxDirectory);
            this.Controls.Add(this._txtboxPatron);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtboxPatron;
        private System.Windows.Forms.TextBox _txtboxDirectory;
        private System.Windows.Forms.TextBox _txtboxResult;
        private System.Windows.Forms.Button button1;
    }
}

