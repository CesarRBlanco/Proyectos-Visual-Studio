using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._2
{
    public partial class Form1 : Form
    {
        bool flag;
        public Form1()
        {
            InitializeComponent();
            flag = false;
        }

        //Apartado a)
        private void Button1_Click(object sender, EventArgs e)
        {
            //flag = !flag;

            if (!flag)
            {
                laebelTextBox1.Posicion = LaebelTextBox.ePosicion.DERECHA;
                laebelTextBox1.Separacion += 5;
                flag = true;
            }
            else
            {
                laebelTextBox1.Posicion = LaebelTextBox.ePosicion.IZQUIERDA;
                laebelTextBox1.Separacion += 5;
                flag = false;
            }
        }

        private void LaebelTextBox1_CambiarPosicion(object sender, EventArgs e)
        {
            if (!flag)
            {
                this.Text = LaebelTextBox.ePosicion.DERECHA + "";
            }
            else
            {
                this.Text = LaebelTextBox.ePosicion.IZQUIERDA + "";
            }

        }

        //Apartado b)
        private void LaebelTextBox1_CambiaSeparacion(object sender, EventArgs e)
        {
            //MessageBox.Show("Separacion: " + laebelTextBox1.Separacion);
            Console.WriteLine("Separacion: " + laebelTextBox1.Separacion);
        }

        //Apartado c)
        private void LaebelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Tecla: "+e.KeyCode);
            Console.WriteLine("Tecla: " + e.KeyCode);
        }

        //Aprtado d)
        private void LaebelTextBox1_CambiarTexto(object sender, EventArgs e)
        {
            Console.WriteLine("Texto Cambiado");
        }

   
    }
}
