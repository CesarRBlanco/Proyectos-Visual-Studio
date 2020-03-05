using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_01_DI
{
    public partial class Form1 : Form
    {

        bool flag;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                labelTextbox.Posicion = UserControl1.ePosicion.IZQUIERDA;
                labelTextbox.Separacion += 5;
                flag = false;

            }
            else
            {
                labelTextbox.Posicion = UserControl1.ePosicion.DERECHA;
                labelTextbox.Separacion += 5;
                flag = true;
            }
        }

        private void LabelTextbox_CambioPosicion(object sender, EventArgs e)
        {
            Text = labelTextbox.Posicion.ToString();
        }

        private void labelTextbox_CambioSeparacion(object sender, EventArgs e)
        {
            Console.WriteLine("Separacion "+labelTextbox.Separacion);
        }

        private void labelTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Telcla" + e.KeyCode);
        }

        private void labelTextbox_TxtChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Tesxto changing"+labelTextbox.TextTxt);
        }
    }
}
