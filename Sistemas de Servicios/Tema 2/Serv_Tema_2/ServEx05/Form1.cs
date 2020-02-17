using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServEx05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string realPath = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            string actualPath = _txtboxDirectory.Text;
            string[] words = actualPath.Split('\\');
            string subStr;
            string newWord;
            realPath = "";
            bool firstTime = true;
            foreach (var word in words)
            {
                newWord = word;
                if (word.StartsWith("%") && word.EndsWith("%"))
                {
                    subStr = word.Substring(1, word.Length - 2);
                    newWord = Environment.GetEnvironmentVariable(subStr);
                }
                if (firstTime)
                {
                    realPath = realPath + newWord;
                    firstTime = false;
                }
                else
                {
                    realPath = realPath + "\\" + newWord;
                }




            }

            int contThread = 0;

            string[] files = Directory.GetFiles(realPath);
            Thread[] hilos = new Thread[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                hilos[i] = new Thread(wordSearch);
                hilos[i].Start(files[i]);
            }




        }



        delegate void Delega(string texto, TextBox t);

        public void wordSearch(object files)
        {
            Delega d = new Delega(cambiaTexto);
            int cont = 0;
            if (files.ToString().EndsWith(".txt"))
            {
                string fileRead = File.ReadAllText(files.ToString());
                if (fileRead.ToString().Contains(_txtboxPatron.Text))
                {
                    cont++;

                    this.Invoke(d, _txtboxResult.Text + "" + cont, _txtboxResult);
                }
            }
        }


        private void cambiaTexto(string texto, TextBox t)
        {
            t.AppendText(texto + Environment.NewLine);
        }
    }
}
