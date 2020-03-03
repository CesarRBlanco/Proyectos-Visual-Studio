using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._2
{
    [
        DefaultProperty("TextLbl"),
        DefaultEvent("Load")
    ]

    public partial class LaebelTextBox : UserControl
    {
        public LaebelTextBox()
        {
            InitializeComponent();
            recolocar();
        }

        //Atributos personalizados
        public enum ePosicion
        {
            IZQUIERDA, DERECHA
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;

        [Category("Apariencia")]
        [Description("Indica si la Label se sitúa a la Izquierda o Derecha del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                    CambiarPosicion?.Invoke(this, new EventArgs());
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        private Char pswChr;

        [Category("Apariencia")]
        [Description("Contraseña")]
        public Char PswChr
        {
            set
            {
                pswChr = value;
                textBox1.PasswordChar = pswChr;
            }
            get
            {
                return pswChr;
            }
        }

        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    textBox1.Location = new Point(0, 0);
                    textBox1.Width = this.Width - label1.Width - separacion;
                    label1.Location = new Point(textBox1.Width + separacion, 0);
                    this.Height = Math.Max(textBox1.Height, label1.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    label1.Location = new Point(0, 0);
                    label1.Width = this.Width - textBox1.Width - separacion;
                    textBox1.Location = new Point(label1.Width + separacion, 0);
                    this.Height = Math.Max(textBox1.Height, label1.Height);
                    break;
            }
        }

        private int separacion = 0;

        [Category("Diseño")]
        [Description("Pixeles de separacion entre Label y Textobox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    //CambiaSeparacion?.Invoke(this, new EventArgs());
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        //Get y Set de Elementos privados
        [Category("Apariencia")]
        [Description("Texto asociado a Label")]
        public String TextLbl
        {
            set
            {
                label1.Text = value;
            }
            get
            {
                return label1.Text;
            }
        }

        [Category("Apariencia")]
        [Description("Texto asociado a TextBox")]
        public String TextTextBox
        {
            set
            {
                textBox1.Text = value;
                //CambiarTexto?.Invoke(this, new EventArgs());
            }
            get { return textBox1.Text; }
        }

        //Eventos
        private void LaebelTextBox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aqui dentro sólo referencias al control
            this.OnKeyPress(e);
        }

        //Crear Eventos
        [Category("Cambio")]
        [Description("Se lanza cuando la propiedad Posicion se cambia")]
        public event System.EventHandler CambiarPosicion;

        [Category("Cambio")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler CambiaSeparacion;

        [Category("Cambio")]
        [Description("Se lanza cuando cambia el texto del TextBox")]
        public event System.EventHandler CambiarTexto;

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //this.OnKeyUp(e);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //CambiarTexto?.Invoke(this, e);
        }

     
    }
}
