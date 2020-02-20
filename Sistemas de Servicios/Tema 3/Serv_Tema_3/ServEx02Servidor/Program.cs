using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServEx02Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie);
            s.Listen(10);
            Console.WriteLine("Server waiting at port {0}", ie.Port);
            while (true)
            {
                Socket cliente = s.Accept();
                Thread hilo = new Thread(hiloCliente);
                hilo.Start(cliente);
            }
        }


        static void hiloCliente(object socket)
        {
            string mensaje;
            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}",
            ieCliente.Address, ieCliente.Port);
            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                string welcome = "Wellcome to this great Server";
                sw.WriteLine(welcome);
                sw.Flush();
                while (true)
                {
                    try
                    {
                        
                        mensaje = sr.ReadLine();
                        //El mensaje es null en el Shutdown
                        if (mensaje != null)
                        {
                            sw.WriteLine("{0} says: {1}",
                            ieCliente.Address, mensaje);
                            sw.Flush();
                        }
                    }
                    catch (IOException)
                    {
                        //Salta al acceder al socket
                        //y no estar permitido
                        break;
                    }
                }
                Console.WriteLine("Finished connection with {0}:{1}",
                ieCliente.Address, ieCliente.Port);
            }
            cliente.Close();
        }

    }
}
