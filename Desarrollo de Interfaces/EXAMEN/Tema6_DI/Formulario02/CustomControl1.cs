using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        Circulo,
        Imagen
    }

    public partial class CustomControl1 : Control
    {


        int medida;

        public CustomControl1()
        {
            InitializeComponent();
        }

        private Color colorInicial = Color.Red;
        public Color ColorInicial
        {
            set
            {
                colorInicial = value;
                this.Refresh();
            }
            get
            {
                return colorInicial;
            }
        }

        private Color colorFinal = Color.Blue;
        public Color ColorFinal
        {
            set
            {
                colorFinal = value;
                this.Refresh();
            }
            get
            {
                return colorFinal;
            }
        }

        private Boolean gradient;
        public Boolean Gradient
        {
            set
            {
                gradient = value;
                this.Refresh();
            }
            get
            {
                return gradient;
            }
        }

        private Image image;
        public Image Image
        {
            set
            {
                image = value;
                this.Refresh();
            }
            get
            {
                return image;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto

            LinearGradientBrush gradientBrush = new LinearGradientBrush(new Point(0, this.Height), new Point(this.Width, this.Height), ColorInicial, ColorFinal);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //Esta propiedad provoca mejoras en la apariencia o en la eficiencia a la hora de dibujar
                                                                                 //Dependiendo del valor de la propiedad marca dibujamos una Cruz o un Círculo


            if (gradient)
            {
                g.FillRectangle(gradientBrush, 0, 0, this.Width, this.Height);
            }
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
                case eMarca.Imagen:
                    if (image != null)
                    {
                        g.DrawImage(image, grosor, grosor + 5, this.Font.Height, this.Font.Height);
                    }
                    else
                    {
                        marca = eMarca.Nada;
                    }
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    medida = offsetX + offsetY;
                    break;
            }
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();

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




        [Category("Click en Marca")]
        [Description("Evento que se lanza al picnhar en el elemnto determinado")]
        public event System.EventHandler ClickEnMarca;

        private void CustomControl1_ClickEnMarca(object sender, MouseEventArgs e)
        {
            if (Marca != eMarca.Nada)
            {
                if (e.X < medida)
                {
                    ClickEnMarca?.Invoke(this,new EventArgs());
                }
            }
        }
    }
}
