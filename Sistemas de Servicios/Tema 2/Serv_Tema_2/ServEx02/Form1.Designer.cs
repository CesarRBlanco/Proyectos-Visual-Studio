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
            this._txtbox = new System.Windows.Forms.TextBox();
            this._btnNew = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtbox
            // 
            this._txtbox.Location = new System.Drawing.Point(12, 0);
            this._txtbox.Multiline = true;
            this._txtbox.Name = "_txtbox";
            this._txtbox.Size = new System.Drawing.Size(776, 409);
            this._txtbox.TabIndex = 0;
            this._txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtbox_KeyDown);
            // 
            // _btnNew
            // 
            this._btnNew.Location = new System.Drawing.Point(12, 415);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Size = new System.Drawing.Size(75, 23);
            this._btnNew.TabIndex = 1;
            this._btnNew.Text = "New";
            this._btnNew.UseVisualStyleBackColor = true;
            this._btnNew.Click += new System.EventHandler(this._btnNew_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(93, 416);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnOpen
            // 
            this._btnOpen.Location = new System.Drawing.Point(176, 416);
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.Size = new System.Drawing.Size(75, 23);
            this._btnOpen.TabIndex = 3;
            this._btnOpen.Text = "Open";
            this._btnOpen.UseVisualStyleBackColor = true;
            this._btnOpen.Click += new System.EventHandler(this._btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnOpen);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnNew);
            this.Controls.Add(this._txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtbox;
        private System.Windows.Forms.Button _btnNew;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnOpen;
    }
}

