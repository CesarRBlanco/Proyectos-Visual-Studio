using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DI_Ex_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog FD = new OpenFileDialog();
        Form form2 = new Form();
        FileInfo[] files;
        string strFilePath;



        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (FD.ShowDialog() == DialogResult.OK)
                {
                    string fileToOpen = FD.FileName;
                    FileInfo File = new FileInfo(fileToOpen);
                    form2.BackgroundImage = Image.FromFile(fileToOpen);
                }


                FileInfo fInfo = new FileInfo(FD.FileName);
                strFilePath = fInfo.DirectoryName;
                files = fInfo.Directory.GetFiles();
                _lblDirectorio.Text = strFilePath;
                _lblInfoImagen.Text = String.Format("Nombre: " + fInfo.Name + "\nExtesion: " + fInfo.Extension + "\nTemaño" + fInfo.Length);

                form2.Size = new Size(form2.BackgroundImage.Width, form2.BackgroundImage.Height);
                form2.FormBorderStyle = FormBorderStyle.FixedSingle;
                form2.Show();
            }
            catch (System.ObjectDisposedException)
            {
                form2.Show();
            }

        }



        private void form2_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void _btnAnterior_Click(object sender, EventArgs e)
        {
            form2.BackgroundImage = Image.FromFile(strFilePath + "\\" + files[2].ToString());
        }

    }
}
