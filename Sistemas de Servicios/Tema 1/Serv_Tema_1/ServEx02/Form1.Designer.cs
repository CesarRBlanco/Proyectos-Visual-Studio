namespace ServEx02
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
            this.show_txt = new System.Windows.Forms.TextBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.allProcess_btn = new System.Windows.Forms.Button();
            this.oneProcess_btn = new System.Windows.Forms.Button();
            this.closeProcess_btn = new System.Windows.Forms.Button();
            this.killProcess_btn = new System.Windows.Forms.Button();
            this.runApp_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // show_txt
            // 
            this.show_txt.Location = new System.Drawing.Point(12, 47);
            this.show_txt.Multiline = true;
            this.show_txt.Name = "show_txt";
            this.show_txt.ReadOnly = true;
            this.show_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.show_txt.Size = new System.Drawing.Size(654, 344);
            this.show_txt.TabIndex = 0;
            this.show_txt.WordWrap = false;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(12, 12);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(369, 20);
            this.search_txt.TabIndex = 1;
            // 
            // allProcess_btn
            // 
            this.allProcess_btn.Location = new System.Drawing.Point(12, 397);
            this.allProcess_btn.Name = "allProcess_btn";
            this.allProcess_btn.Size = new System.Drawing.Size(98, 23);
            this.allProcess_btn.TabIndex = 2;
            this.allProcess_btn.Text = "View Proccesses";
            this.allProcess_btn.UseVisualStyleBackColor = true;
            this.allProcess_btn.Click += new System.EventHandler(this.allProcess_btn_Click);
            // 
            // oneProcess_btn
            // 
            this.oneProcess_btn.Location = new System.Drawing.Point(116, 397);
            this.oneProcess_btn.Name = "oneProcess_btn";
            this.oneProcess_btn.Size = new System.Drawing.Size(75, 23);
            this.oneProcess_btn.TabIndex = 3;
            this.oneProcess_btn.Text = "Process Info";
            this.oneProcess_btn.UseVisualStyleBackColor = true;
            this.oneProcess_btn.Click += new System.EventHandler(this.oneProcess_btn_Click);
            // 
            // closeProcess_btn
            // 
            this.closeProcess_btn.Location = new System.Drawing.Point(197, 397);
            this.closeProcess_btn.Name = "closeProcess_btn";
            this.closeProcess_btn.Size = new System.Drawing.Size(87, 23);
            this.closeProcess_btn.TabIndex = 4;
            this.closeProcess_btn.Text = "Close Process";
            this.closeProcess_btn.UseVisualStyleBackColor = true;
            this.closeProcess_btn.Click += new System.EventHandler(this.closeProcess_btn_Click);
            // 
            // killProcess_btn
            // 
            this.killProcess_btn.Location = new System.Drawing.Point(290, 397);
            this.killProcess_btn.Name = "killProcess_btn";
            this.killProcess_btn.Size = new System.Drawing.Size(75, 23);
            this.killProcess_btn.TabIndex = 5;
            this.killProcess_btn.Text = "Kill Process";
            this.killProcess_btn.UseVisualStyleBackColor = true;
            this.killProcess_btn.Click += new System.EventHandler(this.killProcess_btn_Click);
            // 
            // runApp_btn
            // 
            this.runApp_btn.Location = new System.Drawing.Point(371, 396);
            this.runApp_btn.Name = "runApp_btn";
            this.runApp_btn.Size = new System.Drawing.Size(75, 23);
            this.runApp_btn.TabIndex = 6;
            this.runApp_btn.Text = "Run App";
            this.runApp_btn.UseVisualStyleBackColor = true;
            this.runApp_btn.Click += new System.EventHandler(this.runApp_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(387, 15);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(236, 13);
            this.error_lbl.TabIndex = 7;
            this.error_lbl.Text = "El nombre, ruta o ID introducidos son incorrectos";
            this.error_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 431);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.runApp_btn);
            this.Controls.Add(this.killProcess_btn);
            this.Controls.Add(this.closeProcess_btn);
            this.Controls.Add(this.oneProcess_btn);
            this.Controls.Add(this.allProcess_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.show_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox show_txt;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button allProcess_btn;
        private System.Windows.Forms.Button oneProcess_btn;
        private System.Windows.Forms.Button closeProcess_btn;
        private System.Windows.Forms.Button killProcess_btn;
        private System.Windows.Forms.Button runApp_btn;
        private System.Windows.Forms.Label error_lbl;
    }
}

