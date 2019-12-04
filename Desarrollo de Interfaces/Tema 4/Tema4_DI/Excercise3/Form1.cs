using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise3
{
    public partial class Form1 : Form
    {
        static string title = " Excercise5";
        static int cont = title.Length - 1;
        static int cont2 = 0;
        static bool key;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text.Trim());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = listBox1.SelectedItems.Count + 1;
                for (int i = 0; i < cant; i++)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }

            }
            catch (System.ArgumentException)
            {

            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> indexNumbers = new List<string>();
            string cadena = "";

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                indexNumbers.Add(listBox1.Items.IndexOf(i).ToString());
            }
            for (int i = 0; i < indexNumbers.Count; i++)
            {
                cadena += "," + listBox1.SelectedIndex.ToString();

            }
            label2.Text = "Selected index: " + cadena;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            cont2++;
            if (cont2 >= 2)
            {
                key = !key;
                if (key)
                {
                    //this.Icon = new Icon(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\favicon (2).ico");
                }
                else
                {
                    //this.Icon = new Icon(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads\\nomo.ico");
                }
                cont2 = 0;
            }

            cont--;
            if (cont < 0)
            {

                cont = title.Length - 1;
            }
            this.Text = title.Substring(cont);
        }

        private void ListBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(listBox2, listBox2.Items.Count.ToString());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = listBox2.SelectedItems.Count + 1;
                for (int i = 0; i < cant; i++)
                {
                    listBox1.Items.Insert(0,listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }

            }
            catch (System.ArgumentException)
            {

            }
        }


    }
}
