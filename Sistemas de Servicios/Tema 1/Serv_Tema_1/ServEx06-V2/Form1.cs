using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServEx06_V2
{
    public partial class Form1 : Form
    {
        static readonly private object l = new object();
        public static int displayNumber = 0;
        public static string displayText = displayNumber.ToString();
        public static bool finish = false;
        public static bool displayStop = false;
        public static bool stopColor = false;
        delegate void Delega(string texto, TextBox t);
        delegate void DelegaDisplay(string texto, Label l);
        delegate void DelegaColor(Label l);
        delegate void GameEnd();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread player1 = new Thread(add);
            player1.Start(1);
            Thread player2 = new Thread(add);
            player2.Start(2);
            Thread _display = new Thread(display);
            _display.Start();
        }

        public void gameEnd()
        {
            finish_lbl.Visible = true;
        }

        private void cambiaTexto(string texto, TextBox t)
        {
            t.Text = String.Format(texto + Environment.NewLine);
        }

        private void changeDisplay(string texto, Label l)
        {
            l.Text = String.Format(texto + Environment.NewLine);
        }

        private void displayColor(Label l)
        {
            int nowColor;
            Color[] colorArray = { Color.Red, Color.Blue, Color.Green };
            Random rC = new Random();
            nowColor = rC.Next(0, 3);
            display_lbl.ForeColor = colorArray[nowColor];

        }


        public void add(object code)
        {
            try
            {
                int turn, sleepTIme;
                while (!finish)
                {
                    lock (l)
                    {
                        Random r = new Random();
                        Random rS = new Random();
                        turn = r.Next(1, 11);
                        sleepTIme = rS.Next(100, 100 * turn);
                        Thread.Sleep(sleepTIme);
                        Delega t = new Delega(cambiaTexto);
                        DelegaDisplay d = new DelegaDisplay(changeDisplay);
                        GameEnd gE = new GameEnd(gameEnd);

                        switch (code)
                        {
                            case 1:
                                this.Invoke(t, turn.ToString(), player1);
                                if (turn == 5 || turn == 7)
                                {
                                    if (displayStop)
                                    {
                                        displayNumber += 5;
                                    }
                                    else
                                    {
                                        displayNumber++;
                                        displayStop = true;
                                    }
                                    displayText = String.Format("{0,3}", displayNumber.ToString());
                                    this.Invoke(d, displayText, display_lbl);
                                    if (displayNumber >= 20)
                                    {
                                        this.Invoke(gE);
                                        finish = true;
                                
                                    }
                                }
                                break;
                            case 2:
                                this.Invoke(t, turn.ToString(), player2);
                                if (turn == 5 || turn == 7)
                                {
                                    if (displayStop)
                                    {
                                        displayNumber--;
                                        displayStop = false;
                                    }
                                    else
                                    {
                                        displayNumber -= 5;
                                    }
                                    displayText = String.Format("{0,3}", displayNumber.ToString());
                                    this.Invoke(d, displayText, display_lbl);
                                    if (displayNumber <= -20)
                                    {
                                        this.Invoke(gE);
                                        finish = true;
                                    
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            catch (System.InvalidOperationException)
            {

            }
        }


        public void display()
        {
            try
            {
                DelegaColor cD = new DelegaColor(displayColor);

                while (!finish)
                {
                    if (!displayStop)
                    {
                        this.Invoke(cD, display_lbl);
                    }
                }

            }
            catch (System.InvalidOperationException)
            {

            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!displayStop)
            {
                if (display_lbl.ForeColor == Color.White)
                {
                    display_lbl.ForeColor = Color.Black;
                }
                else
                {
                    display_lbl.ForeColor = Color.White;
                }
            }
        }
    }
}


