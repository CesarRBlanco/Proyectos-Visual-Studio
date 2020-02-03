namespace ServEx01
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
            this.directory_txt = new System.Windows.Forms.TextBox();
            this.directory_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // directory_txt
            // 
            this.directory_txt.Location = new System.Drawing.Point(12, 12);
            this.directory_txt.Name = "directory_txt";
            this.directory_txt.Size = new System.Drawing.Size(254, 20);
            this.directory_txt.TabIndex = 0;
            // 
            // directory_btn
            // 
            this.directory_btn.Location = new System.Drawing.Point(272, 10);
            this.directory_btn.Name = "directory_btn";
            this.directory_btn.Size = new System.Drawing.Size(75, 23);
            this.directory_btn.TabIndex = 1;
            this.directory_btn.Text = "Go";
            this.directory_btn.UseVisualStyleBackColor = true;
            this.directory_btn.Click += new System.EventHandler(this.Directory_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 277);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(353, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(315, 277);
            this.listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.directory_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 324);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.directory_btn);
            this.Controls.Add(this.directory_txt);
            this.Name = "Form1";
            this.Text = "ServEx01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directory_txt;
        private System.Windows.Forms.Button directory_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

