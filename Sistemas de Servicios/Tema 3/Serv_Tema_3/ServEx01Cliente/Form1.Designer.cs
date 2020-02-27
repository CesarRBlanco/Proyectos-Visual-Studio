namespace ServEx01Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._btnHour = new System.Windows.Forms.Button();
            this._btnDate = new System.Windows.Forms.Button();
            this._btnHourDate = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._lblConsulta = new System.Windows.Forms.Label();
            this._btnOptions = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // _btnHour
            // 
            this._btnHour.Location = new System.Drawing.Point(47, 95);
            this._btnHour.Name = "_btnHour";
            this._btnHour.Size = new System.Drawing.Size(75, 23);
            this._btnHour.TabIndex = 0;
            this._btnHour.Tag = "HORA";
            this._btnHour.Text = "Hour";
            this._btnHour.UseVisualStyleBackColor = true;
            this._btnHour.Click += new System.EventHandler(this.consulta);
            // 
            // _btnDate
            // 
            this._btnDate.Location = new System.Drawing.Point(128, 95);
            this._btnDate.Name = "_btnDate";
            this._btnDate.Size = new System.Drawing.Size(75, 23);
            this._btnDate.TabIndex = 1;
            this._btnDate.Tag = "FECHA";
            this._btnDate.Text = "Date";
            this._btnDate.UseVisualStyleBackColor = true;
            this._btnDate.Click += new System.EventHandler(this.consulta);
            // 
            // _btnHourDate
            // 
            this._btnHourDate.Location = new System.Drawing.Point(209, 95);
            this._btnHourDate.Name = "_btnHourDate";
            this._btnHourDate.Size = new System.Drawing.Size(75, 23);
            this._btnHourDate.TabIndex = 2;
            this._btnHourDate.Tag = "TODO";
            this._btnHourDate.Text = "Full Date";
            this._btnHourDate.UseVisualStyleBackColor = true;
            this._btnHourDate.Click += new System.EventHandler(this.consulta);
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(290, 95);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 3;
            this._btnExit.Tag = "APAGAR";
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.consulta);
            // 
            // _lblConsulta
            // 
            this._lblConsulta.AutoSize = true;
            this._lblConsulta.Location = new System.Drawing.Point(172, 45);
            this._lblConsulta.Name = "_lblConsulta";
            this._lblConsulta.Size = new System.Drawing.Size(31, 13);
            this._lblConsulta.TabIndex = 4;
            this._lblConsulta.Text = "Hello";
            // 
            // _btnOptions
            // 
            this._btnOptions.Location = new System.Drawing.Point(334, 13);
            this._btnOptions.Name = "_btnOptions";
            this._btnOptions.Size = new System.Drawing.Size(75, 23);
            this._btnOptions.TabIndex = 5;
            this._btnOptions.Text = "Options";
            this._btnOptions.UseVisualStyleBackColor = true;
            this._btnOptions.Click += new System.EventHandler(this._btnOptions_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 168);
            this.Controls.Add(this._btnOptions);
            this.Controls.Add(this._lblConsulta);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnHourDate);
            this.Controls.Add(this._btnDate);
            this.Controls.Add(this._btnHour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock \'N\' Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnHour;
        private System.Windows.Forms.Button _btnDate;
        private System.Windows.Forms.Button _btnHourDate;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Label _lblConsulta;
        private System.Windows.Forms.Button _btnOptions;
        private System.Windows.Forms.ImageList imageList1;
    }
}

