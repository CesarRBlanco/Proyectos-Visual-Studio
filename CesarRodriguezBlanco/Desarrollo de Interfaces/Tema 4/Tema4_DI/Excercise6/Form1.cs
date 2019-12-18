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

namespace Excercise6
{
    public partial class Form1 : Form
    {
        int contFail = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            DialogResult res;
         
            res = f.ShowDialog(); //Aquí se para la ejecución del programa

            switch (res)
            {
                case DialogResult.OK:
                    if (f.textBox1.Text.ToUpper() == "AAAA")
                    {
                        MessageBox.Show("Contraseña Aceptada", "Mi Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Invalida", "Mi Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        contFail++;
                        if (contFail == 3)
                        {
                            this.Close();
                        }
                   this.Form1_Load(sender,e);
                    }
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Operación Cancelada", "Mi Aplicación",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    break;
                default:
                    break;
            }

            // Botones
            string[] valores = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "#", "0", "*" };
            int aumentoX = 50;
            int aumentoY = 122;
            int aux = 0;
            Button[] botones = new Button[12];
            for (int i = 0; i < valores.Length; i++)
            {
                aux++;
                botones[i] = new Button();
                botones[i].Name = $"button{i}";
                botones[i].Location = new System.Drawing.Point(114 + (aux * aumentoX), aumentoY);
                botones[i].Size = new System.Drawing.Size(46, 48);
                botones[i].Text = valores[i];
                this.Controls.Add(botones[i]);
                botones[i].Click += new System.EventHandler(this.Button1_Click);
                botones[i].MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
                botones[i].MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
                if (aux % 3 == 0)
                {
                    aux = 0;
                    aumentoY += 50;
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            txtNumbers.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Aqua;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = DefaultBackColor;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtNumbers.Text = "";
        }

        private void GrabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text == "")
            {
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Selección de directorio para almacenar datos";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "texto (*.txt)|*.txt| Todos los archivos| *.* ";
            saveFileDialog1.ValidateNames = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter s;
                s = new StreamWriter(saveFileDialog1.FileName);
                s.Write(txtNumbers.Text);
                s.Close();
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
