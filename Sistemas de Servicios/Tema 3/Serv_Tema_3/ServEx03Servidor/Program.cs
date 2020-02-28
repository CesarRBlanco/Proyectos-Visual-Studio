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
        static List<int> numbers= new List<int>();
        static Random rnd = new Random();
        static int playerReady = 0;

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
            string name,ready;
            bool endGame = false;
            string numberString;
            int number;
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
                swArray.Add(sw);
                name = sr.ReadLine();
                names.Add(name);

                //userConnected(sw, nombre);
                try
                {
                    lock (l)
                    {
                        number = rnd.Next(1, 20);
                        numbers.Add(number);
                        numberString = number.ToString();
                        sw.WriteLine(numberString);
                        sw.WriteLine("Press any key to ready.");
                        sw.Flush();
                    }
        
                    lock(l){
                        ready = sr.ReadLine();
                        playerReady++;
                    }
                }
                catch (IOException)
                {

                }
                lock (l)
                {
                    int max = numbers[0];
                    if (playerReady == swArray.Count)
                    {

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > max)
                            {
                                max = numbers[i];
                            }
                        }
                        Console.WriteLine(max);
                    }
                }

                lock (l)
                {
                    if (endGame)
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i] == name)
                            {
                                names.Remove(names[i]);
                            }
                        }
                        swArray.Remove(sw);
                        cliente.Close();
                    }
                }
            }


        }
    }
}