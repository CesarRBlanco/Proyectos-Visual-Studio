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
            const string FORMAT = "{0,7} || {1,5} || {2,5}";
            string Info = "";
            Console.WriteLine(FORMAT, "PID", "Name", "Title");
            foreach (Process p in processes)
            {
                Info = Info + String.Format("{0,5} || {1} || {2}", p.Id, p.ProcessName, p.MainWindowTitle) + "\r\n";
            }
            textBox1.Text = Info;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int pid = Int32.Parse(textBox2.Text);
            Process p = Process.GetProcessById(pid);
            textBox1.Text = String.Format("{0} || {1} || {2} || {3} || {4}", p.ProcessName, p.Id, p.StartTime, p.Modules.Count, p.MainModule);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int pid = Int32.Parse(textBox2.Text);
            Process p = Process.GetProcessById(pid);
            p.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int pid = Int32.Parse(textBox2.Text);
            Process p = Process.GetProcessById(pid);
            p.Kill();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            Process p = Process.Start(name);
        }
    }
}
