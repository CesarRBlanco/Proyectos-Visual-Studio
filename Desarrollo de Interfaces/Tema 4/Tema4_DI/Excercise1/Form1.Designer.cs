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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBxRGB1 = new System.Windows.Forms.TextBox();
            this.txtBxRGB2 = new System.Windows.Forms.TextBox();
            this.txtBxRGB3 = new System.Windows.Forms.TextBox();
            this.btnColorChange = new System.Windows.Forms.Button();
            this.txtBxImgPath = new System.Windows.Forms.TextBox();
            this.btnImgPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtBxRGB1
            // 
            this.txtBxRGB1.Location = new System.Drawing.Point(12, 51);
            this.txtBxRGB1.Name = "txtBxRGB1";
            this.txtBxRGB1.Size = new System.Drawing.Size(54, 20);
            this.txtBxRGB1.TabIndex = 1;
            this.txtBxRGB1.Enter += new System.EventHandler(this.TxtBxRGB1_Enter);
            // 
            // txtBxRGB2
            // 
            this.txtBxRGB2.Location = new System.Drawing.Point(72, 51);
            this.txtBxRGB2.Name = "txtBxRGB2";
            this.txtBxRGB2.Size = new System.Drawing.Size(54, 20);
            this.txtBxRGB2.TabIndex = 2;
            this.txtBxRGB2.Enter += new System.EventHandler(this.TxtBxRGB1_Enter);
            // 
            // txtBxRGB3
            // 
            this.txtBxRGB3.Location = new System.Drawing.Point(132, 51);
            this.txtBxRGB3.Name = "txtBxRGB3";
            this.txtBxRGB3.Size = new System.Drawing.Size(54, 20);
            this.txtBxRGB3.TabIndex = 3;
            this.txtBxRGB3.Enter += new System.EventHandler(this.TxtBxRGB1_Enter);
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
            this.btnColorChange.MouseEnter += new System.EventHandler(this.BtnColorChange_MouseEnter);
            this.btnColorChange.MouseLeave += new System.EventHandler(this.BtnColorChange_MouseLeave);
            // 
            // txtBxImgPath
            // 
            this.txtBxImgPath.Location = new System.Drawing.Point(372, 51);
            this.txtBxImgPath.Name = "txtBxImgPath";
            this.txtBxImgPath.Size = new System.Drawing.Size(335, 20);
            this.txtBxImgPath.TabIndex = 5;
            this.txtBxImgPath.Enter += new System.EventHandler(this.TxtBxImgPath_Enter);
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
            this.btnImgPath.MouseEnter += new System.EventHandler(this.BtnImgPath_MouseEnter);
            this.btnImgPath.MouseLeave += new System.EventHandler(this.BtnImgPath_MouseLeave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColorChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImgPath);
            this.Controls.Add(this.txtBxImgPath);
            this.Controls.Add(this.btnColorChange);
            this.Controls.Add(this.txtBxRGB3);
            this.Controls.Add(this.txtBxRGB2);
            this.Controls.Add(this.txtBxRGB1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBxRGB1;
        private System.Windows.Forms.TextBox txtBxRGB2;
        private System.Windows.Forms.TextBox txtBxRGB3;
        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.TextBox txtBxImgPath;
        private System.Windows.Forms.Button btnImgPath;
        private System.Windows.Forms.Label label1;
    }
}

