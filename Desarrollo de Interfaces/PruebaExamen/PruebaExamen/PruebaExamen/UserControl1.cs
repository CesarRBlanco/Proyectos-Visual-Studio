using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaExamen
{



    public partial class UserControl1 : UserControl
    {
        public enum eTipo
        {
            Numerico,
            Textual
        }

        public Color colorCuadro = new Color();


        public UserControl1()
        {
            InitializeComponent();
            textBox1.Location = new Point(10, 10);
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;
            colorCuadro = Color.Red;


        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush sB = new SolidBrush(colorCuadro);
            Graphics pe = e.Graphics;
            pe.FillRectangle(sB, 5, 5, this.Width - 10, this.Height - 10);
        }




        [Category("Apariencia")]
        [Description("Texto")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }

        private Boolean multilinea;
        public Boolean Multilinea
        {
            set
            {
                multilinea = value;
                textBox1.Multiline = multilinea;
            }
            get
            {
                return multilinea;
            }
        }

        private eTipo tipo;
        [Category("Appearance")]
        [Description("Indica si el Textbox admitira solo valores numericos o texto")]
        public eTipo Tipo
        {
            set
            {
                if (Enum.IsDefined(typeof(eTipo), value))
                {
                    tipo = value;
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return tipo;
            }
        }

        public event EventHandler DetectText;




        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void comprobar()
        {
            foreach (char character in textBox1.Text)
            {
                if (tipo == eTipo.Textual)
                {


                    if (Char.IsDigit(character))
                    {
                        colorCuadro = Color.Red;
                        this.Refresh();
                        return;
                    }
                    else
                    {
                        colorCuadro = Color.Green;
                        this.Refresh();
                    }
                }
            }
        }
    }
}
