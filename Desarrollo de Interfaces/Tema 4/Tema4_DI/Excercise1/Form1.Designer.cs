namespace Excercise1
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
            this.txtBxRGB1 = new System.Windows.Forms.TextBox();
            this.txtBxRGB2 = new System.Windows.Forms.TextBox();
            this.txtBxRGB3 = new System.Windows.Forms.TextBox();
            this.btnColorChange = new System.Windows.Forms.Button();
            this.txtBxImgPath = new System.Windows.Forms.TextBox();
            this.btnImgPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBxRGB1
            // 
            this.txtBxRGB1.Location = new System.Drawing.Point(12, 51);
            this.txtBxRGB1.Name = "txtBxRGB1";
            this.txtBxRGB1.Size = new System.Drawing.Size(54, 20);
            this.txtBxRGB1.TabIndex = 1;
            // 
            // txtBxRGB2
            // 
            this.txtBxRGB2.Location = new System.Drawing.Point(72, 51);
            this.txtBxRGB2.Name = "txtBxRGB2";
            this.txtBxRGB2.Size = new System.Drawing.Size(54, 20);
            this.txtBxRGB2.TabIndex = 2;
            // 
            // txtBxRGB3
            // 
            this.txtBxRGB3.Location = new System.Drawing.Point(132, 51);
            this.txtBxRGB3.Name = "txtBxRGB3";
            this.txtBxRGB3.Size = new System.Drawing.Size(54, 20);
            this.txtBxRGB3.TabIndex = 3;
            // 
            // btnColorChange
            // 
            this.btnColorChange.Location = new System.Drawing.Point(192, 49);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(75, 23);
            this.btnColorChange.TabIndex = 4;
            this.btnColorChange.Text = "Apply Color";
            this.btnColorChange.UseVisualStyleBackColor = true;
            this.btnColorChange.Click += new System.EventHandler(this.BtnColorChange_Click);
            // 
            // txtBxImgPath
            // 
            this.txtBxImgPath.Location = new System.Drawing.Point(372, 51);
            this.txtBxImgPath.Name = "txtBxImgPath";
            this.txtBxImgPath.Size = new System.Drawing.Size(335, 20);
            this.txtBxImgPath.TabIndex = 5;
            // 
            // btnImgPath
            // 
            this.btnImgPath.Location = new System.Drawing.Point(713, 49);
            this.btnImgPath.Name = "btnImgPath";
            this.btnImgPath.Size = new System.Drawing.Size(75, 23);
            this.btnImgPath.TabIndex = 6;
            this.btnImgPath.Text = "Apply Image";
            this.btnImgPath.UseVisualStyleBackColor = true;
            this.btnImgPath.Click += new System.EventHandler(this.BtnImgPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColorChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImgPath);
            this.Controls.Add(this.txtBxImgPath);
            this.Controls.Add(this.btnColorChange);
            this.Controls.Add(this.txtBxRGB3);
            this.Controls.Add(this.txtBxRGB2);
            this.Controls.Add(this.txtBxRGB1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxRGB1;
        private System.Windows.Forms.TextBox txtBxRGB2;
        private System.Windows.Forms.TextBox txtBxRGB3;
        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.TextBox txtBxImgPath;
        private System.Windows.Forms.Button btnImgPath;
        private System.Windows.Forms.Label label1;
    }
}

