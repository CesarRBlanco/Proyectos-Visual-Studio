using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelUsuario1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (labelUsuario1.Posicion == DI_Tema6.LabelUsuario.ePosicion.IZQUIERDA)
            {
                labelUsuario1.Posicion = DI_Tema6.LabelUsuario.ePosicion.DERECHA;
            }
            else
            {
                labelUsuario1.Posicion = DI_Tema6.LabelUsuario.ePosicion.IZQUIERDA;
            }
        }
    }
}
