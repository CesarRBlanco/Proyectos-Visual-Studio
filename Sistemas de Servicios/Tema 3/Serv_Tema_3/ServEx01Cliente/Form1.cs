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
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            const string IP_SERVER = "127.0.0.1";
            string msg;
            string userMsg;
            // Indicamos servidor al que nos queremos conectar y puerto
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), 31416);
            //Console.WriteLine("Starting client. Press a key to init connection");
            //Console.ReadKey();
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // El cliente inicia la conexión haciendo petición con Connect
                server.Connect(ie);
            }
            catch (SocketException er)
            {
                //Console.WriteLine("Error connection: {0}\nError code: {1}({2})",
                //er.Message, (SocketError)er.ErrorCode, er.ErrorCode);
                //Console.ReadKey();
                return;
            }
            // Si la conexión se ha establecido se crean los Streams
            // y se inicial la comunicación siguiendo el protocolo
            // establecido en el servidor
            NetworkStream ns = new NetworkStream(server);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            // Leemos mensaje de bienvenida ya que es lo primero que envía el servidor
            //msg = sr.ReadLine();
            //Console.WriteLine(msg);
            while (true)
            {
                // Lo siguiente es pedir un mensaje al usuario
                userMsg = "HORA";
                // Establecemos como "comando" de protocolo
                // la palabra "exit". Si se escribe, se finaliza.
                //if (userMsg == "exit")
                //{
                //    break;
                //}
                //Enviamos el mensaje de usuario al servidor
                // que que el servidor está esperando que le envíen algo
                sw.WriteLine(userMsg);
                sw.Flush();
                //Recibimos el mensaje del servidor
                msg = sr.ReadLine();
                label1.Text = msg;
                //Console.WriteLine(msg);
                break;
            }
            //Console.WriteLine("Ending connection");
            sr.Close();
            sw.Close();
            ns.Close();
            //Indicamos fin de transmisión.
            server.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            const string IP_SERVER = "127.0.0.1";
            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), 31416);
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
                userMsg = "FECHA";
                sw.WriteLine(userMsg);
                sw.Flush();
                msg = sr.ReadLine();
                label1.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            const string IP_SERVER = "127.0.0.1";
            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), 31416);
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
                label1.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            const string IP_SERVER = "127.0.0.1";
            string msg;
            string userMsg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), 31416);
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
                userMsg = "APAGAR";
                sw.WriteLine(userMsg);
                sw.Flush();
                msg = sr.ReadLine();
                label1.Text = msg;
                break;
            }
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
            this.Close();
        }
    }
}
