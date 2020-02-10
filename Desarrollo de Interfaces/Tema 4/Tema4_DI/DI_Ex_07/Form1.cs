using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Ex_07
{
    public partial class Form1 : Form
    {

        const int MRUnumber = 6;
        Collection<string> MRUlist = new Collection<string>();
        public static OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void AjusteDeLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ajusteDeLineaToolStripMenuItem.Checked = false;
        }

        private void NuevoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (richTextBox1.Text != "")
            {

                dr = MessageBox.Show("Deseas guardar antes de abrir un nuevo archivo?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (saveFile(sender, e) == true)
                    {
                        richTextBox1.Text = "";
                    }

                }
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Text = "";
                }
                else
                {

                }

            }
            else
            {
                richTextBox1.Text = "";
            }
        }
  
        private void AbrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileContent = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.InitialDirectory = "c:\\";
                openFile.Filter = "Archivos de texto (*.txt)|*.txt|Archivos .ini files (*.ini)|*.ini|Clases java (*.java)|*.java|Clases de C# (*.cs)|*.cs|Clases de Phyton (*.py)|*.py|Webs HTML (*.html)|*.html|" +
                    "Archivos Component Style Sheet (*.css)|*.css|Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                openFile.FilterIndex = 9;
                openFile.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Stream fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            richTextBox1.Text = fileContent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecentList();
            foreach (string item in MRUlist)
            {
                ToolStripMenuItem fileRecent = new ToolStripMenuItem(item, null, RecentFile_click);  //create new menu for each item in list
                archivosRecientesToolStripMenuItem.DropDownItems.Add(fileRecent); //add the menu to "recent" menu
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        /// <summary>
        /// store a list to file and refresh list
        /// </summary>
        /// <param name="path"></param>
        private void SaveRecentFile(string path)
        {
            archivosRecientesToolStripMenuItem.DropDownItems.Clear(); //clear all recent list from menu
            LoadRecentList(); //load list from file
            if (!(MRUlist.Contains(path))) //prevent duplication on recent list
                MRUlist.Add(path); //insert given path into list
            while (MRUlist.Count >= MRUnumber) //keep list number not exceeded given value
            {
                MRUlist.RemoveAt(0);
            }
            foreach (string item in MRUlist)
            {
                ToolStripMenuItem fileRecent = new ToolStripMenuItem(item, null, RecentFile_click);  //create new menu for each item in list
                archivosRecientesToolStripMenuItem.DropDownItems.Add(fileRecent); //add the menu to "recent" menu
            }
            //writing menu list to file
            StreamWriter stringToWrite = new StreamWriter(System.Environment.CurrentDirectory + "\\Recent.txt"); //create file called "Recent.txt" located on app folder
            foreach (string item in MRUlist)
            {
                stringToWrite.WriteLine(item); //write list to stream
            }
            stringToWrite.Flush(); //write stream to file
            stringToWrite.Close(); //close the stream and reclaim memory
        }
        /// <summary>
        /// load recent file list from file
        /// </summary>
        private void LoadRecentList()
        {//try to load file. If file isn't found, do nothing
            MRUlist.Clear();
            try
            {
                StreamReader listToRead = new StreamReader(System.Environment.CurrentDirectory + "\\Recent.txt"); //read file stream
                string line;
                while ((line = listToRead.ReadLine()) != null) //read each line until end of file
                    MRUlist.Add(line); //insert to list
                listToRead.Close(); //close the stream
            }
            catch (Exception)
            {

                //throw;
            }

        }
        /// <summary>
        /// click menu handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecentFile_click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(sender.ToString(), RichTextBoxStreamType.PlainText); //same as open menu
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); 
                SaveRecentFile(openFileDialog1.FileName);
            }
        }

        private bool saveFile(object sender, EventArgs e)
        {
            try
            {
                DialogResult drS;

                SaveFileDialog saveDialog = new SaveFileDialog();

                saveDialog.Title = "Selección de directorio para almacenar datos";
                saveDialog.InitialDirectory = "C:\\";
                saveDialog.Filter = "Archivos de texto (*.txt)|*.txt| Todos los archivos| *.* ";
                saveDialog.ValidateNames = true;
                drS = saveDialog.ShowDialog();
                if (drS == DialogResult.OK)
                {
                    return true;
                }
                StreamWriter s;
                s = new StreamWriter(saveDialog.FileName);
                s.Write(richTextBox1.Text);
                s.Close();
            }
            catch (System.ArgumentException)
            {
            }
            return false;
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(sender,e);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
