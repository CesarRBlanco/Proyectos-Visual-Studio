using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario02
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo
    }

    public partial class CustomControl1 : Control
    {
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //Esta propiedad provoca mejoras en la apariencia o en la eficiencia a la hora de dibujar
            //Dependiendo del valor de la propiedad marca dibujamos una Cruz o un Círculo
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height,
                    this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor,
                    this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY
            * 2);
            b.Dispose();


            //Traslación
            g.TranslateTransform(100, 100);
            g.DrawLine(Pens.Red, 0, 0, 100, 0);
            g.ResetTransform();
            //Rotación de 30º en sentido horario
            g.RotateTransform(30);
            g.DrawLine(Pens.Blue, 0, 0, 100, 0);
            g.ResetTransform();
            //Traslación + rotación
            g.TranslateTransform(100, 100);
            g.RotateTransform(30);
            g.DrawLine(Pens.Green, 0, 0, 100, 0);
            g.ResetTransform();
        }
    


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private eMarca marca = eMarca.Nada;
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get { return marca; }
        }
    }
}
