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

namespace DI_Ex_07
{
    public partial class Form1 : Form
    {
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
            if (txtbox.Text != "")
            {

                dr = MessageBox.Show("Deseas guardar antes de abrir un nuevo archivo?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    if (GuardarToolStripMenuItem_Click(sender, e) == true)
                    {
                        txtbox.Text = "";
                    }

                }
                else if (dr == DialogResult.No)
                {
                    txtbox.Text = "";
                }
                else
                {

                }

            }
            else
            {
                txtbox.Text = "";
            }
        }

        private bool GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult drS;

                SaveFileDialog saveDialog = new SaveFileDialog();

                saveDialog.Title = "Selección de directorio para almacenar datos";
                saveDialog.InitialDirectory = "C:\\";
                saveDialog.Filter = "texto (*.txt)|*.txt|pascal (*.pas) |*.pas|visualbasic(*.vb) | *.vb | Todos los archivos| *.* ";
                saveDialog.ValidateNames = true;
                drS = saveDialog.ShowDialog();
                if (drS == DialogResult.OK)
                {
                    return true;
                }
                StreamWriter s;
                s = new StreamWriter(saveDialog.FileName);
                s.Write(txtbox.Text);
                s.Close();
            }
            catch (System.ArgumentException)
            {


            }
            return false;
        }
    }
}
