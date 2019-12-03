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
            this.Icon = new Icon("F:\\Wallpapers\\favicon.ico");
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
            try
            {

                label1.Size = new Size(new Bitmap(txtBxImgPath.Text).Width, new Bitmap(txtBxImgPath.Text).Height);
                label1.Image = new Bitmap(txtBxImgPath.Text);
          
            }
            catch (System.ArgumentException)
            {

            }
        }

        private void TxtBxImgPath_Enter(object sender, EventArgs e)
        {
            if (this.AcceptButton == btnColorChange)
            {
                this.AcceptButton = btnImgPath;
            }
        }
        private void TxtBxRGB1_Enter(object sender, EventArgs e)
        {
            if (this.AcceptButton == btnImgPath)
            {
                this.AcceptButton = btnColorChange;
            }
        }

        private void BtnColorChange_MouseEnter(object sender, EventArgs e)
        {
            btnColorChange.BackColor = Color.Red;
        }

        private void BtnColorChange_MouseLeave(object sender, EventArgs e)
        {
            btnColorChange.BackColor = default(Color);
        }

        private void BtnImgPath_MouseEnter(object sender, EventArgs e)
        {
            btnImgPath.BackColor = Color.Red;
        }

        private void BtnImgPath_MouseLeave(object sender, EventArgs e)
        {
            btnImgPath.BackColor = default(Color);
        }
    }
}