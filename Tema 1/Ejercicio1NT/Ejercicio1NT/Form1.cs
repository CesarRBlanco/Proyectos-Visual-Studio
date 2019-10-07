using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1NT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            try
            {
                num1 = Double.Parse(textBox1.Text);
            }
            catch
            {
                num1 = 0;
            }
            try
            { 
                num2 = Double.Parse(textBox2.Text);
            }
            catch
            {
                num2 = 0;
            }

            double suma = num1 + num2;
            equal.Text = suma.ToString();

        }

    }
}
