using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServEx01Cliente
{
    public partial class Form1 : Form
    {

        //Global variables
        Form optsForm = new Form();
        TextBox txtIP = new TextBox();
        TextBox txtPort = new TextBox();
        string ip = "127.0.0.1";
        int port = 31416;




        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ie);
            }
            catch (SocketException er)
            {
                _lblConsulta.Text = "Error. Check IP and Port.";
                return;
            }
            NetworkStream ns = new NetworkStream(server);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            while (true)
            {
                userMsg = "HORA";
                sw.WriteLine(userMsg);
                sw.Flush();
                msg = sr.ReadLine();
                _lblConsulta.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ie);
            }
            catch (SocketException er)
            {
                _lblConsulta.Text = "Error. Check IP and Port.";
                return;
            }
            NetworkStream ns = new NetworkStream(server);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            while (true)
            {
                userMsg = "FECHA";
                sw.WriteLine(userMsg);
                sw.Flush();
                msg = sr.ReadLine();
                _lblConsulta.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ie);
            }
            catch (SocketException er)
            {
                return;
            }
            NetworkStream ns = new NetworkStream(server);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            while (true)
            {
                userMsg = "TODO";
                sw.WriteLine(userMsg);
                sw.Flush();
                msg = sr.ReadLine();
                _lblConsulta.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ie);
            }
            catch (SocketException er)
            {
                _lblConsulta.Text = "Error. Check IP and Port.";
                return;
            }
            NetworkStream ns = new NetworkStream(server);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            while (true)
            {
                userMsg = "APAGAR";
                sw.WriteLine(userMsg);
                sw.Flush();
                msg = sr.ReadLine();
                _lblConsulta.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
            this.Close();
        }


        private void _btnOptions_Click(object sender, EventArgs e)
        {

            Label lblIP = new Label();
            Label lblPort = new Label();
            Button applyOpts = new Button();

            lblIP.Text = "IP: ";
            lblPort.Text = "Port: ";
            applyOpts.Text = "Apply";
            lblIP.Width = 30;
            lblPort.Width = 30;
            lblPort.Location = new Point(0, 25);
            txtIP.Location = new Point(30, 0);
            txtPort.Location = new Point(30, 25);
            applyOpts.Location = new Point(10, 50);
            optsForm.Controls.Add(lblIP);
            optsForm.Controls.Add(txtIP);
            optsForm.Controls.Add(lblPort);
            optsForm.Controls.Add(txtPort);
            optsForm.Controls.Add(applyOpts);

            applyOpts.Click += new EventHandler(this.applyConfig);

            optsForm.ShowDialog();
        }

        public void applyConfig(object sender, EventArgs e)
        {

            ip = txtIP.Text;
            port = Int32.Parse(txtPort.Text);
            optsForm.Close();
        }

    }
}
