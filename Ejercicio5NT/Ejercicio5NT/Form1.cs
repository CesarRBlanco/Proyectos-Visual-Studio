using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5NT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dial;
            dial = MessageBox.Show("Do you want to change the title to "+textBox1.Text+"?", "Change the title", MessageBoxButtons.YesNo);
            switch (dial)
            {
                case DialogResult.Yes:
                    this.Text = textBox1.Text;
                    break;
                  
            }
        }

    }
}
