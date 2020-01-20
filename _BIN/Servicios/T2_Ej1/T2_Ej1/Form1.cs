using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo d;
            FileInfo f;
            StreamReader sr;
            string ruta;
            String[] directoris;
            ruta = textBox1.Text;
            f = new FileInfo(ruta);
            Directory.SetCurrentDirectory(ruta);
            d =new DirectoryInfo(Directory.GetCurrentDirectory());
            for (int i = 0; i< d.GetDirectories().Length; i++)
            {
                listBox1.Items.Add(d.GetDirectories()[i]);

            }
            listBox1.Items.Add("------");

            for (int i = 0; i < d.GetFiles().Length; i++)
            {
                listBox2.Items.Add(d.GetFiles()[i]);
            }
        }
    }
}
