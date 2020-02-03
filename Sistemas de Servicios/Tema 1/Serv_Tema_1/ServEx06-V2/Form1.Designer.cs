namespace ServEx06_V2
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
            this.components = new System.ComponentModel.Container();
            this.display_lbl = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.finish_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display_lbl
            // 
            this.display_lbl.AutoSize = true;
            this.display_lbl.Location = new System.Drawing.Point(122, 32);
            this.display_lbl.Name = "display_lbl";
            this.display_lbl.Size = new System.Drawing.Size(13, 13);
            this.display_lbl.TabIndex = 0;
            this.display_lbl.Text = "0";
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(84, 76);
            this.player1.Name = "player1";
            this.player1.ReadOnly = true;
            this.player1.Size = new System.Drawing.Size(30, 20);
            this.player1.TabIndex = 1;
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(145, 76);
            this.player2.Name = "player2";
            this.player2.ReadOnly = true;
            this.player2.Size = new System.Drawing.Size(32, 20);
            this.player2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // finish_lbl
            // 
            this.finish_lbl.AutoSize = true;
            this.finish_lbl.Location = new System.Drawing.Point(13, 32);
            this.finish_lbl.Name = "finish_lbl";
            this.finish_lbl.Size = new System.Drawing.Size(108, 13);
            this.finish_lbl.TabIndex = 3;
            this.finish_lbl.Text = "The game has ended";
            this.finish_lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.finish_lbl);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.display_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display_lbl;
        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label finish_lbl;
    }
}

