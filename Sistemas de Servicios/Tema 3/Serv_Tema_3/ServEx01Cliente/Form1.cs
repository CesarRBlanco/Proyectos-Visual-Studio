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

        private void consulta(object sender, EventArgs e)
        {
            try
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
                catch (SocketException)
                {
                    _lblConsulta.Text = "Error. Check IP and Port.";
                    return;
                }
                NetworkStream ns = new NetworkStream(server);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                while (true)
                {
                    userMsg = ((Button)sender).Tag.ToString();
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
            catch (System.ArgumentOutOfRangeException)
            {
                _lblConsulta.Text = "Error. Check IP and Port.";

            }
            catch (FormatException)
            {
                _lblConsulta.Text = "Error. Check IP.";
            }
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
            bool allGreen;
            try
            {
                allGreen = true;
                ip = txtIP.Text;
                port = Int32.Parse(txtPort.Text);
            }
            catch (System.FormatException)
            {
                allGreen = false;
                MessageBox.Show("Port field cannot be empty.", "Error Port", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (ip == "")
            {
                allGreen = false;
                MessageBox.Show("IP field cannot be empty.", "Error IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (allGreen)
            {
                optsForm.Close();
            }
        }

      
    }
}
// Comprobación puerto e IP y una función única para todos los botones 