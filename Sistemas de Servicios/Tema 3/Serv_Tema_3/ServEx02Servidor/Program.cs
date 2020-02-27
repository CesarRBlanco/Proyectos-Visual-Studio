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
        static List<string> names = new List<string>();
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

            bool safeClose = false;


            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}",
            ieCliente.Address, ieCliente.Port);
            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                string welcome = "Welcome, please insert your username:";
                sw.WriteLine(welcome);
                sw.Flush();



                nombre = sr.ReadLine();
                names.Add(nombre);
                nombre = String.Format("{0}@{1}", nombre, ieCliente.Address);
                swArray.Add(sw);
                userConnected(sw, nombre);
                while (true)
                {
                    try
                    {
                        mensaje = sr.ReadLine();
                        lock (l)
                        {
                            safeClose = false;
                            if (mensaje == "#salir")
                            {
                                safeClose = true;
                                for (int i = 0; i < names.Count; i++)
                                {
                                    if (names[i] == nombre)
                                    {
                                        names.Remove(names[i]);
                                    }
                                }
                                swArray.Remove(sw);
                                cliente.Close();
                            }
                            else if (mensaje == "#lista")
                            {
                                mensaje = "Users: ";
                                foreach (var persona in names)
                                {
                                    mensaje = mensaje +"-"+ persona+" ";                     
                                }
                                list(sw, mensaje);
                            }
                            else
                            {
                                lee(sw, mensaje, nombre);
                            }
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
                if (!safeClose)
                {
                    names.Remove(nombre);
                    swArray.Remove(sw);


                }
            }

            cliente.Close();
        }



        static void lee(StreamWriter sw, string mensaje, string nombre)
        {
            foreach (var destino in swArray)
            {
                if (mensaje != null)
                {
                    if (destino != sw)
                    {
                        destino.WriteLine("{0}: {1}", nombre, mensaje);
                        destino.Flush();
                    }
                }
            }
        }



        static void userConnected(StreamWriter sw, string nombre)
        {
            foreach (var destino in swArray)
            {

                if (destino != sw)
                {
                    destino.WriteLine("User \"{0}\" is now connected. Say hi!", nombre);
                    destino.Flush();
                }

            }
        }


        static void list(StreamWriter sw, string mensaje)
        {
            sw.WriteLine(mensaje);
            sw.Flush();
        }



    }

}

