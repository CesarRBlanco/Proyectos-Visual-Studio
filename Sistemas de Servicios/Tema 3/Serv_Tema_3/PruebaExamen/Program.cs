using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaExamen
{
    class Program
    {
        private static readonly object l = new object();
        public string rutaRepuesto = "C:\\Users\\Ner0\\ArchivosTexto";
        public int puerto = 0;
        public bool puertoLlave;
        static void Main(string[] args)
        {
            Program funcis = new Program();
            string fileName = "illo.txt";
            string subStr = "EXAMEN";
            string route = Environment.GetEnvironmentVariable(subStr);
            string fullRoute = route + "\\" + fileName;
            string repuesto = "C:\\Users\\Ner0\\ArchivosTexto\\illo.txt";


            funcis.iniciaServidorArchivos();
        }


        private void leeArchivo(string nombreArchivo, int nLineas)
        {

            StreamReader sR = new StreamReader(nombreArchivo);

            if (puertoLlave)
            {
                puerto = Int32.Parse(sR.ReadLine());
            }
            else
            {
                for (int i = 0; i < nLineas; i++)
                {
                    Console.WriteLine(sR.ReadLine());

                }
            }



            sR.Close();

        }

        private int leePuerto()
        {
            string archivo = "C:\\Users\\Ner0\\ArchivosTexto\\puerto.txt";
            try

            {
                puertoLlave = true;
                leeArchivo(archivo, 1);
                puertoLlave = false;
                return puerto;
            }
            catch (FileNotFoundException)
            {
                return 31416;

            }
        }

        private void guardarPuerto(int numero)
        {
            StreamWriter sW = new StreamWriter("C:\\Users\\Ner0\\ArchivosTexto\\puerto.txt");
            sW.WriteLine(numero);
            sW.Close();
        }


        private void listarArchivos()
        {
            string lista = "";
            string[] files = Directory.GetFiles(rutaRepuesto);
            for (int i = 0; i < files.Length; i++)
            {
                lista = lista + "\n" + Path.GetFileName(files[i]);
            }
            Console.WriteLine(lista);
        }



        private void iniciaServidorArchivos()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, leePuerto());
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie);
            s.Listen(10);


            while (true)
            {
                Socket cliente = s.Accept();
                Thread hilo = new Thread(hiloCliente);
                hilo.Start(cliente);
            }

        }


        private void hiloCliente(object socket)
        {
            Program funciones = new Program();
            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;

            string mensaje;

            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {



                while (true)
                {

                    mensaje = sr.ReadLine();
                    lock (l)
                    {
                        if (mensaje.Substring(0, 4) == "LIST")
                        {
                            funciones.listarArchivos(); 
                        }
                    }

                }
            }
        }
    }
}
//iniciaServidorArchivos() : Método principal donde se inicia el servicio.Realiza la programación necesaria para el inicio de la
//    comunicación por red.Se obtiene el puerto llamando a leePuerto, si el puerto está ocupado informa de ese hecho en
//pantalla y fnaliza el programa.Si no debe informar por pantalla del puerto de conexión y tras esto se queda a la escucha.
//Finalmente entra en un bucle en el cual se realiza la conexión con el cliente iniciando un hilo que ejecuta la función
//hiloCliente.Del bucle se saldrá cuando reciba el comando correcto de un cliente como se indica más abajo.