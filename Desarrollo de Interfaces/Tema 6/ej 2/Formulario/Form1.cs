using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            //this.OnClick(e);
        }
        private void EtiquetaAviso1_Click_2(object sender, EventArgs e)
        {

        }

        private void EtiquetaAviso1_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

   

        private void EtiquetaAviso1_ClickEnMarca_1(object sender, EventArgs e)
        {
            MessageBox.Show("SE SUPONE QUE FUNCIONA");

        }
    }
}
