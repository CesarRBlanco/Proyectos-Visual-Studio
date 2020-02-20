using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pruebas
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
                        sw.WriteLine(mensaje);
                        sw.Flush();
                        //El mensaje es null en el Shutdown
                        if (mensaje != null)
                        {
                            Console.WriteLine("{0} says: {1}",
                            ieCliente.Address, mensaje);
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




















        // Prueba Uno Sin Hilos

        /*

    IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);

        //Creacion del Socket
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Enlace de socket al puerto (y en cualquier interfaz de red)
        //Salta excepción si el puerto está ocupado
        s.Bind(ie);

        //Esperando una conexión y estableciendo cola de clientes pendientes
        s.Listen(10);

        //Esperamos y aceptamos la conexion del cliente (socket bloqueante)
        Socket sClient = s.Accept();

        //Obtenemos la info del cliente
        //El casting es necesario ya que RemoteEndPoint es del tipo EndPoint
        //mas genérico
        IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
        Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address, ieClient.Port);


     // Console.ReadKey();
     //   sClient.Close(); // Se puede usar using con Socket y nos ahorramos los close.
     //   s.Close();



        //Preparando End Point del servidor
        //Creación del Stream de Red. Nuevamente puede hacerse con using.
        NetworkStream ns = new NetworkStream(sClient);
        //StreamReader y StreamWriter aceptan un Stream
        //como parámetro en el constructor
        StreamReader sr = new StreamReader(ns);
        StreamWriter sw = new StreamWriter(ns);
        string welcome = "Welcome to The Echo-Logic, Odd, Desiderable, " +
        "Incredible, and Javaless Echo Server (T.E.L.O.D.I.J.E Server)";
        //El envío por red se convierte en un WriteLine
        sw.WriteLine(welcome);
        //Con flush se fuerza el envío de los datos sin esperar al cierre
        sw.Flush();
        //El código del protocolo debe ir antes de esta línea
        //Siempre cerramos los Streams y sockets si no lo hemos hecho con using.



        string msg;
        while (true)
        {
            try
            {
                //Leemos el mensaje del cliente
                msg = sr.ReadLine();
                // Si se cierra el cierra el cliente mientras se espera
                // en el ReadLine, este devuelve null.
                Console.WriteLine(msg != null ? msg : "Client disconnected");
                //Mandamos nuevamente el mensaje al cliente
                sw.WriteLine(msg);
                sw.Flush();
            }
            // Si se cierra el cliente, salta excepción
            // Al siguiente readline
            catch (IOException e)
            {
                break;
            }
        }
        Console.WriteLine("Connection closed");



        sw.Close();
        sr.Close();
        ns.Close();

        sClient.Close();

    }
*/
    }

}
