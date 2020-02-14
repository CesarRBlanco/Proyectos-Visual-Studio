namespace DI_Ex_08
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
            this._btnAbrir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._btnAnterior = new System.Windows.Forms.Button();
            this._btnSiguiente = new System.Windows.Forms.Button();
            this._lblDirectorio = new System.Windows.Forms.Label();
            this._lblInfoImagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnAbrir
            // 
            this._btnAbrir.Location = new System.Drawing.Point(62, 12);
            this._btnAbrir.Name = "_btnAbrir";
            this._btnAbrir.Size = new System.Drawing.Size(75, 23);
            this._btnAbrir.TabIndex = 0;
            this._btnAbrir.Text = "Abrir";
            this._btnAbrir.UseVisualStyleBackColor = true;
            this._btnAbrir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _btnAnterior
            // 
            this._btnAnterior.Location = new System.Drawing.Point(12, 68);
            this._btnAnterior.Name = "_btnAnterior";
            this._btnAnterior.Size = new System.Drawing.Size(75, 23);
            this._btnAnterior.TabIndex = 1;
            this._btnAnterior.Text = "Anterior";
            this._btnAnterior.UseVisualStyleBackColor = true;
            this._btnAnterior.Click += new System.EventHandler(this._btnAnterior_Click);
            // 
            // _btnSiguiente
            // 
            this._btnSiguiente.Location = new System.Drawing.Point(108, 68);
            this._btnSiguiente.Name = "_btnSiguiente";
            this._btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this._btnSiguiente.TabIndex = 2;
            this._btnSiguiente.Text = "Siguiente";
            this._btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // _lblDirectorio
            // 
            this._lblDirectorio.AutoSize = true;
            this._lblDirectorio.Location = new System.Drawing.Point(148, 17);
            this._lblDirectorio.Name = "_lblDirectorio";
            this._lblDirectorio.Size = new System.Drawing.Size(85, 13);
            this._lblDirectorio.TabIndex = 3;
            this._lblDirectorio.Text = "Directorio Actual";
            // 
            // _lblInfoImagen
            // 
            this._lblInfoImagen.AutoSize = true;
            this._lblInfoImagen.Location = new System.Drawing.Point(208, 68);
            this._lblInfoImagen.Name = "_lblInfoImagen";
            this._lblInfoImagen.Size = new System.Drawing.Size(63, 13);
            this._lblInfoImagen.TabIndex = 4;
            this._lblInfoImagen.Text = "Info Imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 163);
            this.Controls.Add(this._lblInfoImagen);
            this.Controls.Add(this._lblDirectorio);
            this.Controls.Add(this._btnSiguiente);
            this.Controls.Add(this._btnAnterior);
            this.Controls.Add(this._btnAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAbrir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button _btnAnterior;
        private System.Windows.Forms.Button _btnSiguiente;
        private System.Windows.Forms.Label _lblDirectorio;
        private System.Windows.Forms.Label _lblInfoImagen;
    }
}

