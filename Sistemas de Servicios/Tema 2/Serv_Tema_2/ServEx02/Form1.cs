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

namespace ServEx02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void _btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (_txtbox.Text != "")
            {
                dr = MessageBox.Show("Would you like to save before opening another file?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (saveFile() == true)
                    {
                        _txtbox.Text = "";
                    }
                }
                else if (dr == DialogResult.No)
                {
                    _txtbox.Text = "";
                }
            }
            else
            {
                _txtbox.Text = "";
            }
        }


        private bool saveFile()
        {
            try
            {
                DialogResult drS;
                SaveFileDialog saveDialog = new SaveFileDialog();

                saveDialog.Title = "Directory selection for saving";
                saveDialog.InitialDirectory = "C:\\";
                saveDialog.Filter = "Text files (*.txt)|*.txt| All files| *.* ";
                saveDialog.ValidateNames = true;
                drS = saveDialog.ShowDialog();
                if (drS == DialogResult.OK)
                {
                    StreamWriter s;
                    s = new StreamWriter(saveDialog.FileName);
                    s.Write(_txtbox.Text);
                    s.Close();
                }
                else
                {
                    return false;
                }
            }
            catch (System.ArgumentException)
            {
            }
            return false;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void _btnOpen_Click(object sender, EventArgs e)
        {

            DialogResult dr;
            if (_txtbox.Text != "")
            {
                dr = MessageBox.Show("Would you like to save before opening another file?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (saveFile() == true)
                    {
                        openFile();
                    }
                }
                else if (dr == DialogResult.No)
                {
                    openFile();
                }
            }
            else
            {
                openFile();
            }
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string fileText = File.ReadAllText(file);
                _txtbox.Text = fileText;
            }
        }


        private void _txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult dr;

            if (e.Control && e.KeyCode == Keys.R)
            {
                dr = colorDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    _txtbox.ForeColor = colorDialog.Color;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryWriter bW;
            bW = new BinaryWriter(new FileStream("C:\\Users\\Zer0\\Documents\\temps\\config.bin", FileMode.OpenOrCreate));
            int colorin = _txtbox.ForeColor.ToArgb();
            bW.Write(colorin);
            bW.Close();

            StreamWriter sW = new StreamWriter(new FileStream("C:\\Users\\Zer0\\Documents\\temps\\tempText.txt",FileMode.OpenOrCreate));
            sW.WriteLine(_txtbox.Text);
            sW.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sR = new StreamReader(new FileStream("C:\\Users\\Zer0\\Documents\\temps\\tempText.txt", FileMode.Open));
                _txtbox.Text = sR.ReadToEnd();
                sR.Close();

                BinaryReader bR;
                bR = new BinaryReader(new FileStream("C:\\Users\\Zer0\\Documents\\temps\\config.bin", FileMode.Open));
                if (bR != null)
                {
                    Color texto = Color.FromArgb(bR.ReadInt32());
                    _txtbox.ForeColor = texto;
                }
                bR.Close();
            }
            catch (System.IO.FileNotFoundException)
            {

            }
        }
    }
}