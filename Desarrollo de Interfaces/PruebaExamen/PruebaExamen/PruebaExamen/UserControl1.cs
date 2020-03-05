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



        public UserControl1()
        {
            InitializeComponent();
            textBox1.Location = new Point(10, 10);
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;
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
            DetectText?.Invoke(this, new EventArgs()) ;
        }
    }
}
