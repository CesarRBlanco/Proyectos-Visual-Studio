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

namespace Formulario
{

    //VARIABLE ESTATICO E IMAGEN NULA y degradado
    public enum eMarca
    {
        Nada, Cruz, Circulo, Imagen

    }
    [DefaultProperty("etiquetaAviso1"), DefaultEvent("OnPaint")]
    public partial class EtiquetaAviso : Control
    {
        int medida;

        [Category("Click en Marca")]
        [Description("Evento que se lanza al picnhar en el elemnto determinado")]
        public event System.EventHandler ClickEnMarca;

        //Color inicial
        private Color colorinicial = Color.Aqua;
        [Category("Appareance")]
        [Description("Establece Color Inicial")]
        public Color ColorInicial
        {
            set
            {
                colorinicial = value;
                this.Refresh();
            }
            get
            {
                return colorinicial;
            }
        }
        private Color colorfinal = Color.Red;
        [Category("Appareance")]
        [Description("Establecer Color Final")]
        public Color ColorFinal
        {
            set
            {
                colorfinal = value;
                this.Refresh();
            }
            get
            {
                return colorfinal;
            }
        }

        private Image image;
        [Category("Appareance")]
        [Description("Establecer Imagen")]
        public Image Image
        {
            set
            {
                image = value;
            }
            get
            {
                return image;
            }
        }


        private Boolean gradiente = true;
        [Category("Appareance")]
        [Description("Activa el gradiente")]

        public Boolean Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }
        private eMarca marca = eMarca.Nada;
        [Category("Appareance")]
        [Description("Marcaaa")]

        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }
        public EtiquetaAviso()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            LinearGradientBrush gradiente = new LinearGradientBrush(new Point(1, 0), new Point(50, 100), ColorInicial, ColorFinal);

            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (Gradiente)
            {
                g.FillRectangle(gradiente, 0, 0, this.Width, this.Height);

            }
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                   this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;

                    medida = offsetX + offsetY;
                    break;
                case eMarca.Cruz:
                    grosor = 20;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height,
                   this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor,
                   this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;


                    medida = offsetX + offsetY;
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:

                    if (image!=null)
                    {
                        g.DrawImage(image, grosor, grosor, this.Font.Height, this.Font.Height);
                      
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

        private void EtiquetaAviso_MouseClick(object sender, MouseEventArgs e)
        {
            if (Marca != eMarca.Nada)
            {
                if (e.X < medida)
                {
                    ClickEnMarca?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
