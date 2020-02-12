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

            //ajusteDeLineaToolStripMenuItem.Checked = !ajusteDeLineaToolStripMenuItem.Checked;
            if (ajusteDeLineaToolStripMenuItem.Checked)
            {
                _txtbox.WordWrap = true;
            }
            else
            {
                _txtbox.WordWrap = false;
            }
        }

        private void NuevoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (_txtbox.Text != "")
            {

                dr = MessageBox.Show("Deseas guardar antes de abrir un nuevo archivo?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (saveFile(sender, e) == true)
                    {
                        _txtbox.Text = "";
                    }

                }
                else if (dr == DialogResult.No)
                {
                    _txtbox.Text = "";
                }
                else
                {

                }

            }
            else
            {
                _txtbox.Text = "";
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
            _txtbox.Text = fileContent;
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
            _txtbox.Clear();
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
            _txtbox.LoadFile(sender.ToString(), RichTextBoxStreamType.PlainText); //same as open menu
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _txtbox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
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

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(sender, e);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (_txtbox.SelectedText != "")
            {
                Clipboard.SetText(_txtbox.SelectedText);
                _txtbox.SelectedText = "";
            }
        }

        private void CopiarToolStripButton_Click(object sender, EventArgs e)
        {
            if (_txtbox.SelectedText != "")
            {
                Clipboard.SetText(_txtbox.SelectedText);
            }
        }

        private void PegarToolStripButton_Click(object sender, EventArgs e)
        {
            int selectionIndex = _txtbox.SelectionStart;
            _txtbox.Text = _txtbox.Text.Insert(selectionIndex, Clipboard.GetText());
            _txtbox.SelectionStart = selectionIndex + Clipboard.GetText().Length;
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtbox.Undo();
            _txtbox.ClearUndo();
        }

        private void SeleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtbox.Select(0, _txtbox.Text.Length);
        }


        TextBox selectTxtBox = new TextBox();
        private void InformaciónDeSelecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSelec = new Form();
            Button applyBtn = new Button();

            if (_txtbox.SelectedText != "")
            {

                selectTxtBox.Multiline = true;
                selectTxtBox.Size = new Size(200, 100);
                selectTxtBox.ReadOnly = true;
                selectTxtBox.Text = String.Format("Punto de inicio: " + _txtbox.SelectionStart + "\r\nLongitud: " + _txtbox.SelectedText.Length);

                applyBtn.Location = new Point(50, 200);
                applyBtn.Text = "Aplicar";
                applyBtn.Click += new EventHandler(this.buttonOk_Click);

                formSelec.Controls.Add(selectTxtBox);
                formSelec.Controls.Add(applyBtn);

                formSelec.Show();
            }
        }

        void buttonOk_Click(object sender, EventArgs e)
        {
            selectTxtBox.Text = String.Format("Punto de inicio: " + _txtbox.SelectionStart + "\r\nLongitud: " + _txtbox.SelectedText.Length);
        }

        private void MayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (minusculasToolStripMenuItem.Checked == true || normalToolStripMenuItem.Checked == true)
            {
                mayusculasToolStripMenuItem.Checked = true;
                minusculasToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = false;
                _txtbox.Text = _txtbox.Text.ToUpper();
            }
        }

        private void MinusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mayusculasToolStripMenuItem.Checked == true || normalToolStripMenuItem.Checked == true)
            {
                minusculasToolStripMenuItem.Checked = true;
                mayusculasToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = false;
                _txtbox.Text = _txtbox.Text.ToLower();
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (minusculasToolStripMenuItem.Checked == true || mayusculasToolStripMenuItem.Checked == true)
            {
                normalToolStripMenuItem.Checked = true;
                mayusculasToolStripMenuItem.Checked = false;
                minusculasToolStripMenuItem.Checked = false;
                _txtbox.Text = _txtbox.Text.ToLowerInvariant();
            }
        }




        private void _txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            normalToolStripMenuItem.Checked = true;
            mayusculasToolStripMenuItem.Checked = false;
            minusculasToolStripMenuItem.Checked = false;
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _txtbox.ForeColor = colorDialog.Color;

            }
        }



        private void FuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                _txtbox.Font = fontDialog.Font;

            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInfo = new Form(() => formInfo.Text = "Acerca de ...");
        }
    }
}




