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
            string[] words = actualPath.Split('\\');
            string subStr;
            string newWord;
            string realPath = "";
            bool firstTime = true;
            foreach (var word in words)
            {
                newWord = word;
                if (word.StartsWith("%") && word.EndsWith("%"))
                {
                    subStr = word.Substring(1, word.Length - 2);
                    newWord = Environment.GetEnvironmentVariable(subStr);
                }
                if (firstTime)
                {
                    realPath = realPath + newWord;
                    firstTime = false;
                }
                else
                {
                    realPath = realPath + "\\" + newWord;
                }
            }
            LoadDirectories(realPath);
            LoadFiles(realPath);
        }

        public void LoadDirectories(String path)
        {
            try
            {
                listBox1.Items.Clear();
                string[] directories = Directory.GetDirectories(path);

                listBox1.Items.Add("...");
                for (int i = 0; i < directories.Length; i++)
                {
                    listBox1.Items.Add(directories[i]);
                }
            }
            catch (System.ArgumentException)
            {

            }
            catch (System.IO.DirectoryNotFoundException)
            {

            }
        }

        public void LoadFiles(String path)
        {
            try
            {
                listBox2.Items.Clear();
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < files.Length; i++)
                {
                    listBox2.Items.Add(files[i]);
                }
                actualPath = path;
                label1.Visible = false;
            }
            catch (System.ArgumentException)
            {

            }
            catch (System.IO.DirectoryNotFoundException)
            {
                label1.Visible = true;
            }
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
                string contain = File.ReadAllText(file);
                if (Path.GetExtension(file).Equals(".txt"))
                {
                    Form form2 = new Form();
                    TextBox fileText_txtbox = new TextBox();
                    fileText_txtbox.Multiline = true;
                    fileText_txtbox.ReadOnly = true;
                    fileText_txtbox.Size = form2.Size;
                    fileText_txtbox.Location = new Point(0, 0);
                    fileText_txtbox.Text = contain;
            
                    form2.Controls.Add(fileText_txtbox);
                    form2.Show();
                }
            }

        }
    }
}
