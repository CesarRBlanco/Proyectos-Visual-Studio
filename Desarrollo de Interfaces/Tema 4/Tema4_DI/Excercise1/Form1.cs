using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cambio color
        private void BtnColorChange_Click(object sender, EventArgs e)
        {
            // Variables
            int color1, color2, color3;
            try
            {
                // Recogida valores
                color1 = Int32.Parse(txtBxRGB1.Text);
                color2 = Int32.Parse(txtBxRGB2.Text);
                color3 = Int32.Parse(txtBxRGB3.Text);

                //Comprobaciones
                this.BackColor = Color.FromArgb(color1, color2, color3);
            }
            catch (System.ArgumentException)
            {

            }
            catch (System.FormatException)
            {

            }
        }

        private void BtnImgPath_Click(object sender, EventArgs e)
        {
            label1.Image = new Bitmap(txtBxImgPath.Text);
            label1.Width = new Bitmap(txtBxImgPath.Text).Width;
            label1.Height = new Bitmap(txtBxImgPath.Text).Height;
        }
    }
}