using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_DI_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserControl11_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.Text = "Letra: " + e.KeyChar;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (userControl11.Posicion == UserControl1.ePosicion.IZQUIERDA)
            {
                userControl11.Posicion = UserControl1.ePosicion.DERECHA;
            }
            else
            {
                userControl11.Posicion = UserControl1.ePosicion.IZQUIERDA;
            }
            this.Text = userControl11.Posicion.ToString();
            
        }

        private void UserControl11_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "hola";
        }
    }
}
