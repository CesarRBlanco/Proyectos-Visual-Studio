using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Tag = Color.Aqua;
            button2.Tag = Color.Cornsilk;
            button3.Tag = Color.ForestGreen;
        }

        void BotonesClick(object sender, System.EventArgs e)
        {
            ((Button) sender).Text = ((Button) sender).Text.ToUpper();
            this.BackColor = (Color) ((Button) sender).Tag;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            DialogResult res;
            res = f.ShowDialog(); //Aquí se para la ejecución del programa
            switch (res)
            {
                case DialogResult.OK:
                    if (f.textBox1.Text.ToUpper() == "AAA")
                        MessageBox.Show("Contraseña Aceptada", "Mi Aplicación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("Contraseña Invalida", "Mi Aplicación",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.Close();
                    }

                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Operación Cancelada", "Mi Aplicación",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    break;
            }
        }
    }
}