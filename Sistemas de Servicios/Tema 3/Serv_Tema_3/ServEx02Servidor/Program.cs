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
        private static readonly object l = new object();
        static List<StreamWriter> swArray = new List<StreamWriter>();

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
            string nombre;


          

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



                nombre = sr.ReadLine();

                swArray.Add(sw);
           
          
                while (true)
                {
                    try
                    {
                        mensaje = sr.ReadLine();
                        lock (l)
                        {
                            lee(sw, mensaje, nombre);
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

        //static void escribe(StreamReader sr,StreamWriter sw)
        //{
        //     lee(sw,sr.ReadLine());
        //    //El mensaje es null en el Shutdown

        //}

        static void lee(StreamWriter sw, string mensaje, string nombre)
        {
            foreach (var destino in swArray)
            {
                if (mensaje != null)
                {

                    if (destino != sw)
                    {
                        destino.WriteLine(nombre + "" + mensaje);
                        destino.Flush();
                    }

                }
            }

        }

    }
}
