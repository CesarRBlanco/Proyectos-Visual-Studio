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
            this._btnBuscar = new System.Windows.Forms.Button();
            this._chkboxMayusMin = new System.Windows.Forms.CheckBox();
            this._lblDirectorio = new System.Windows.Forms.Label();
            this._lblPatron = new System.Windows.Forms.Label();
            this._lblError = new System.Windows.Forms.Label();
            this._lblErrorPatron = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtboxPatron
            // 
            this._txtboxPatron.Location = new System.Drawing.Point(203, 61);
            this._txtboxPatron.Name = "_txtboxPatron";
            this._txtboxPatron.Size = new System.Drawing.Size(100, 20);
            this._txtboxPatron.TabIndex = 0;
            // 
            // _txtboxDirectory
            // 
            this._txtboxDirectory.Location = new System.Drawing.Point(39, 61);
            this._txtboxDirectory.Name = "_txtboxDirectory";
            this._txtboxDirectory.Size = new System.Drawing.Size(121, 20);
            this._txtboxDirectory.TabIndex = 1;
            // 
            // _txtboxResult
            // 
            this._txtboxResult.Location = new System.Drawing.Point(39, 119);
            this._txtboxResult.Multiline = true;
            this._txtboxResult.Name = "_txtboxResult";
            this._txtboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtboxResult.Size = new System.Drawing.Size(313, 199);
            this._txtboxResult.TabIndex = 2;
            // 
            // _btnBuscar
            // 
            this._btnBuscar.Location = new System.Drawing.Point(350, 59);
            this._btnBuscar.Name = "_btnBuscar";
            this._btnBuscar.Size = new System.Drawing.Size(75, 23);
            this._btnBuscar.TabIndex = 3;
            this._btnBuscar.Text = "Buscar";
            this._btnBuscar.UseVisualStyleBackColor = true;
            this._btnBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // _chkboxMayusMin
            // 
            this._chkboxMayusMin.AutoSize = true;
            this._chkboxMayusMin.Location = new System.Drawing.Point(368, 121);
            this._chkboxMayusMin.Name = "_chkboxMayusMin";
            this._chkboxMayusMin.Size = new System.Drawing.Size(118, 17);
            this._chkboxMayusMin.TabIndex = 4;
            this._chkboxMayusMin.Text = "Ignorar Mayus/Min ";
            this._chkboxMayusMin.UseVisualStyleBackColor = true;
            // 
            // _lblDirectorio
            // 
            this._lblDirectorio.AutoSize = true;
            this._lblDirectorio.Location = new System.Drawing.Point(36, 45);
            this._lblDirectorio.Name = "_lblDirectorio";
            this._lblDirectorio.Size = new System.Drawing.Size(52, 13);
            this._lblDirectorio.TabIndex = 5;
            this._lblDirectorio.Text = "Directorio";
            // 
            // _lblPatron
            // 
            this._lblPatron.AutoSize = true;
            this._lblPatron.Location = new System.Drawing.Point(200, 45);
            this._lblPatron.Name = "_lblPatron";
            this._lblPatron.Size = new System.Drawing.Size(38, 13);
            this._lblPatron.TabIndex = 6;
            this._lblPatron.Text = "Patron";
            // 
            // _lblError
            // 
            this._lblError.AutoSize = true;
            this._lblError.ForeColor = System.Drawing.Color.Red;
            this._lblError.Location = new System.Drawing.Point(36, 84);
            this._lblError.Name = "_lblError";
            this._lblError.Size = new System.Drawing.Size(124, 13);
            this._lblError.TabIndex = 7;
            this._lblError.Text = "Directorio no encontrado";
            this._lblError.Visible = false;
            // 
            // _lblErrorPatron
            // 
            this._lblErrorPatron.AutoSize = true;
            this._lblErrorPatron.ForeColor = System.Drawing.Color.Red;
            this._lblErrorPatron.Location = new System.Drawing.Point(200, 84);
            this._lblErrorPatron.Name = "_lblErrorPatron";
            this._lblErrorPatron.Size = new System.Drawing.Size(128, 13);
            this._lblErrorPatron.TabIndex = 8;
            this._lblErrorPatron.Text = "Introduzca una busqueda";
            this._lblErrorPatron.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this._btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblErrorPatron);
            this.Controls.Add(this._lblError);
            this.Controls.Add(this._lblPatron);
            this.Controls.Add(this._lblDirectorio);
            this.Controls.Add(this._chkboxMayusMin);
            this.Controls.Add(this._btnBuscar);
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
        private System.Windows.Forms.Button _btnBuscar;
        private System.Windows.Forms.CheckBox _chkboxMayusMin;
        private System.Windows.Forms.Label _lblDirectorio;
        private System.Windows.Forms.Label _lblPatron;
        private System.Windows.Forms.Label _lblError;
        private System.Windows.Forms.Label _lblErrorPatron;
    }
}

