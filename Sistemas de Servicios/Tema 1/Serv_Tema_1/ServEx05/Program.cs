using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServEx05
{
    public delegate void MyDelegate();
    class Program
    {
        static int counter = 0;
        static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            MyDelegate passFunc;
            passFunc = new MyDelegate(increment);
            MyTimer t = new MyTimer(passFunc);
            t.interval = 1000;
            string op = "";
            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            } while (op == "1");
            t.kill();
        }
    }

    class MyTimer
    {
        static readonly private object l = new object();
        Thread _thread;
        public int interval;
        public bool finish = false;
        public bool wait = true;

        public MyTimer(MyDelegate passFunc)
        {
            Thread _timer = new Thread(() =>
            {
                while (!finish)
                {
                    Thread.Sleep(interval);
                    lock (l)
                    {
                        if (wait)
                        {
                            Monitor.Wait(l);
                        }
                        else
                        {
                            passFunc();
                        }
                    }
                }
            });
            _timer.Start();
        }

        public void start()
        {
            wait = false;
            lock (l)
            {

                Monitor.Pulse(l);
            }
        }

        public void stop()
        {
            wait = true;

        }

        public void kill()
        {
            finish = true;
            start();
        }

    }
}

