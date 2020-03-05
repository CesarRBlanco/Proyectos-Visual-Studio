using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void userControl11_DetectText_1(object sender, EventArgs e)
        {
            Console.WriteLine("llega " + userControl11.Texto);
            //if (userControl11.Texto.Length > 5)
            //{
            //    userControl11.Texto = "";
            //}

          
        }
    }
}
