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

namespace ServEx01
{
    public partial class Form1 : Form
    {

        String actualPath;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Directory_btn_Click(object sender, EventArgs e)
        {
            actualPath = directory_txt.Text;
            LoadDirectories(actualPath);
            LoadFiles(actualPath);
        }

        public void LoadDirectories(String path)
        {
            listBox1.Items.Clear();
            string[] directories = Directory.GetDirectories(path);

            listBox1.Items.Add("...");
            for (int i = 0; i < directories.Length; i++)
            {
                listBox1.Items.Add(directories[i]);
            }

        }

        public void LoadFiles(String path)
        {
            listBox2.Items.Clear();
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                listBox2.Items.Add(files[i]);
            }
            actualPath = path;
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox lb = sender as ListBox;
                if (lb != null)
                {
                    if (lb.SelectedIndex == 0)
                    {
                        LoadDirectories(Directory.GetParent(actualPath).ToString());
                        LoadFiles(Directory.GetParent(actualPath).ToString());

                    }
                }
            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                String file = listBox2.SelectedItem.ToString();
                if (Path.GetExtension(file).Equals(".txt"))
                {
                    MessageBox.Show("No se como lo hace");
                }
            }

        }
    }
}
