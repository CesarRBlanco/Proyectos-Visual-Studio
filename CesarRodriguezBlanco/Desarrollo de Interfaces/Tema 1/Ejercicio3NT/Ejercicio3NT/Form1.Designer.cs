namespace Ejercicio3NT
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
            this.Spin1 = new System.Windows.Forms.TextBox();
            this.Spin2 = new System.Windows.Forms.TextBox();
            this.Spin3 = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnMoreCredit = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Spin1
            // 
            this.Spin1.Location = new System.Drawing.Point(81, 39);
            this.Spin1.Name = "Spin1";
            this.Spin1.ReadOnly = true;
            this.Spin1.Size = new System.Drawing.Size(22, 20);
            this.Spin1.TabIndex = 0;
            // 
            // Spin2
            // 
            this.Spin2.Location = new System.Drawing.Point(109, 39);
            this.Spin2.Name = "Spin2";
            this.Spin2.ReadOnly = true;
            this.Spin2.Size = new System.Drawing.Size(22, 20);
            this.Spin2.TabIndex = 1;
            // 
            // Spin3
            // 
            this.Spin3.Location = new System.Drawing.Point(137, 39);
            this.Spin3.Name = "Spin3";
            this.Spin3.ReadOnly = true;
            this.Spin3.Size = new System.Drawing.Size(22, 20);
            this.Spin3.TabIndex = 2;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(82, 65);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "SPIN!";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(12, 9);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(72, 13);
            this.lblCredit.TabIndex = 4;
            this.lblCredit.Text = "Creditos: 50 $";
            // 
            // btnMoreCredit
            // 
            this.btnMoreCredit.Location = new System.Drawing.Point(176, 126);
            this.btnMoreCredit.Name = "btnMoreCredit";
            this.btnMoreCredit.Size = new System.Drawing.Size(59, 23);
            this.btnMoreCredit.TabIndex = 5;
            this.btnMoreCredit.Text = "Add 10 $ ";
            this.btnMoreCredit.UseVisualStyleBackColor = true;
            this.btnMoreCredit.Click += new System.EventHandler(this.BtnMoreCredit_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Location = new System.Drawing.Point(13, 112);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(54, 13);
            this.lblPrize.TabIndex = 7;
            this.lblPrize.Text = "Prize: - - $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 161);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnMoreCredit);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.Spin3);
            this.Controls.Add(this.Spin2);
            this.Controls.Add(this.Spin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Spin1;
        private System.Windows.Forms.TextBox Spin2;
        private System.Windows.Forms.TextBox Spin3;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnMoreCredit;
        private System.Windows.Forms.Label lblPrize;
    }
}

