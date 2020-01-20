using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private void Button1_Click(object sender, EventArgs e)
        {
           

            Process[] processes = Process.GetProcesses();

            //@TODO tamaño fijo para el PID y el Name para que no descuadre nada al mostrar en el textbox. Nombre de ventana.


            const string FORMAT = "{0,7} || {1,20}";
                string Info="";
            Console.WriteLine(FORMAT, "PID", "Name");
                foreach (Process p in processes)
                {
                    Info = Info + String.Format(FORMAT, p.Id, p.ProcessName)+"\r\n";
                }
            textBox1.Text = Info;
        }
    }
}
