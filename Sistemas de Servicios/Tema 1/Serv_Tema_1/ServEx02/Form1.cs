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

        string accesError = "Not enough permissions for this action.";
        string typoError = "The name, route or ID are incorrect.";

        public Form1()
        {
            InitializeComponent();
        }

        private void allProcess_btn_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            const string FORMAT = "{0,7} || {1,5} || {2,5}";
            string Info = "";
            Console.WriteLine(FORMAT, "PID", "Name", "Title");
            foreach (Process p in processes)
            {
                Info = Info + String.Format("{0,5} || {1} || {2}", p.Id, p.ProcessName, p.MainWindowTitle) + "\r\n";
            }
            show_txt.Text = Info;
        }

        private void oneProcess_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Int32.Parse(search_txt.Text.Trim());
                Process p = Process.GetProcessById(pid);
                ProcessModuleCollection pM = p.Modules;
                string Info = String.Format("{0} || {1} || {2} || {3} || {4}", p.ProcessName, p.Id, p.StartTime, p.Modules.Count, p.MainModule);

                foreach (ProcessModule pMm in pM)
                {
                    Info = Info + String.Format("{0,5} ", pMm) + "\r\n";
                }
                error_lbl.Visible = false;

                show_txt.Text = Info;
            }
            catch (System.ComponentModel.Win32Exception)
            {
                error_lbl.Text = accesError;
                error_lbl.Visible = true;
            }
            catch (System.FormatException)
            {
                error_lbl.Text = typoError;
                error_lbl.Visible = true;
            }
        }

        private void closeProcess_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Int32.Parse(search_txt.Text);
                Process p = Process.GetProcessById(pid);
                p.Close();
                error_lbl.Visible = false;
            }
            catch (System.FormatException)
            {
                error_lbl.Text = typoError;
                error_lbl.Visible = true;
            }
            if (show_txt.Text != "")
            {
                allProcess_btn_Click(sender, e);
            }
        }

        private void killProcess_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Int32.Parse(search_txt.Text);
                Process p = Process.GetProcessById(pid);
                p.Kill();
                error_lbl.Visible = false;
            }
            catch (System.ComponentModel.Win32Exception)
            {
                error_lbl.Text =accesError;
                error_lbl.Visible = true;
            }
            catch (System.FormatException)
            {
                error_lbl.Text = typoError;
                error_lbl.Visible = true;
            }
            if (show_txt.Text != "")
            {
                allProcess_btn_Click(sender, e);
            }
        }

        private void runApp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = search_txt.Text;
                Process p = Process.Start(name);
                error_lbl.Visible = false;
            }catch (SystemException ex)
            {
                if (ex is System.ComponentModel.Win32Exception || ex is FormatException)
                {
                    error_lbl.Text = typoError;
                    error_lbl.Visible = true;
                }
            }
        }
    }
}
