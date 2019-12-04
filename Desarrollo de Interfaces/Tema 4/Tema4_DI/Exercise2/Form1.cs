using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Cursor.Position.ToString();
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Cursor.Position.ToString();
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Cursor.Position.ToString();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                btnLeft.BackColor = Color.Blue;
                btnRight.BackColor = Color.Blue;
            }
            if (e.Button == MouseButtons.Left)
            {
                btnLeft.BackColor = Color.Red;
            }
            if (e.Button == MouseButtons.Right)
            {
                btnRight.BackColor = Color.Red;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                btnLeft.BackColor = DefaultBackColor;
                btnRight.BackColor = DefaultBackColor;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    btnLeft.BackColor = DefaultBackColor;
                }
                if (e.Button == MouseButtons.Right)
                {
                    btnRight.BackColor = DefaultBackColor;
                }
            }

        }

 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals("esc"))
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyChar + "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {

        }
    }
}
