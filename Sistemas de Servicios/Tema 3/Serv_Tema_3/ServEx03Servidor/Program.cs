using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServEx03Servidor
{
    class Program
    {
        private static readonly object l = new object();
        static List<StreamWriter> swArray = new List<StreamWriter>();
        static List<string> names = new List<string>();
        static List<int> numbers = new List<int>();
        static Random rnd = new Random();
        static int playerReady = 0;
        static bool enoughPlayers = true;
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
            string nombreSimple;
            bool safeClose = false;
            string name, ready;
            bool endGame = false;
            string numberString;
            int number,max=0;

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
                nombreSimple = nombre;
                names.Add(nombre);
                number = rnd.Next(1, 20);
                numbers.Add(number);
                numberString = number.ToString();
                nombre = String.Format("{0}@{1}", nombre, ieCliente.Address);
                swArray.Add(sw);
                userConnected(sw, nombre);

                while (true)
                {
                    try
                    {
                        //lock (l)
                        //{
                        //    mensaje = number.ToString();
                        //}
                        //lee(sw, mensaje, nombre);
                        mensaje = sr.ReadLine();
                        lock (l)
                        {
                            safeClose = false;
                            if (mensaje == "#salir")
                            {
                                safeClose = true;
                                for (int i = 0; i < names.Count; i++)
                                {
                                    if (names[i] == nombreSimple)
                                    {
                                        names.Remove(names[i]);
                                    }
                                }
                                swArray.Remove(sw);
                                cliente.Close();
                                userDisconnected(sw, nombre);
                            }
                            else if (mensaje == "#ready")
                            {
                                playerReady++;
                                if (playerReady == names.Count)
                                {
                                    for (int i = 10; i > 0; i--)
                                    {
                                        mensaje = i.ToString();
                                        lee(sw, mensaje, nombre);
                                        Thread.Sleep(500);
                                    }

                                    for (int i = 0; i < numbers.Count; i++)
                                    {
                                        Console.WriteLine("----" + numbers[i]);
                                        if (numbers[i] > max)
                                        {
                                            max = numbers[i];
                                        }
                                    }
                                    Console.WriteLine(max.ToString());
                                    mensaje = max.ToString();
                                    lee(sw, mensaje, nombre);

                                }
                            }
                            else
                            {
                                lee(sw, mensaje, nombre);
                            }
                        }
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Sa largao");
                        break;
                    }
                }
                lock (l)
                {


                    Console.WriteLine("Finished connection with {0}:{1}",
                    ieCliente.Address, ieCliente.Port);
                    if (!safeClose)
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i] == nombreSimple)
                            {
                                names.Remove(names[i]);
                            }
                        }
                        swArray.Remove(sw);
                    }
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
                    //if (destino != sw)
                    //{
                    destino.WriteLine("{0}", mensaje);
                    destino.Flush();
                    //}
                }
                else
                {
                    destino.WriteLine("User \"{0}\" has disconnected.", nombre);
                    destino.Flush();
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
        static void userDisconnected(StreamWriter sw, string nombre)
        {
            foreach (var destino in swArray)
            {

                if (destino != sw)
                {
                    destino.WriteLine("User \"{0}\" has disconnected.", nombre);
                    destino.Flush();
                }

            }
        }


    



    }

}



