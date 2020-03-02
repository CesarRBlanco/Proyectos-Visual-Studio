using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServEx01Servidor
{
    class Program
    {

        static bool running = true;
        static int port = 135;
        static void Main(string[] args)
        {
            tryConnection();
        }

        public static void tryConnection()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, port);// fixme PUERTO OCUPADO e ip valida
            Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Bind(ie);
                s.Listen(10);
            }
            catch (System.Net.Sockets.SocketException)
            {
                port++;
                tryConnection();
            }

            Console.WriteLine("Server waiting at port {0}", ie.Port);
            while (running)
            {
                clienteConecction(s);
            }
        }

        static void clienteConecction(Socket s)
        {

            Socket cliente = s.Accept();
            string peticion;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}",
            ieCliente.Address, ieCliente.Port);

            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                peticion = sr.ReadLine();
                DateTime now = DateTime.Now;
                switch (peticion)
                {
                    case "HORA":
                        sw.WriteLine(String.Format("{0}:{1,2:D2}:{2,2:D2}", now.Hour, now.Minute, now.Second));
                        break;

                    case "FECHA":
                        sw.WriteLine(String.Format("{0,2:D2}/{1,2:D2}/{2,2:D2}", now.Day, now.Month, now.Year));
                        break;

                    case "TODO":
                        sw.WriteLine(DateTime.Now.ToString());
                        break;

                    case "APAGAR":
                        sr.Close();
                        sw.Close();
                        ns.Close();
                        cliente.Close();
                        s.Close();
                        running = false;
                        return;
                }
                sw.Flush();
                sr.Close();
                sw.Close();
                ns.Close();
                cliente.Close();
            }
        }



    }
}

