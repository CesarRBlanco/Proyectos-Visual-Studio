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


        private readonly object l = new object();
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

            _txtboxResult.Clear();
            _lblError.Visible = false;
            _lblErrorPatron.Visible = false;
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
            try
            {
                string[] files = Directory.GetFiles(realPath);
                Thread[] hilos = new Thread[files.Length];
                lock (l)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        hilos[i] = new Thread(wordSearch);
                        hilos[i].Start(files[i]);
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                _lblError.Text = "Directorio no encontrado";
                _lblError.Visible = true;
            }
            catch (System.ArgumentException)
            {
                _lblError.Text = "Introduzca un directorio";
                _lblError.Visible = true;
            }
        }

        delegate void Delega(string texto, TextBox t);
        delegate void DelegaError(Label l);

        public void wordSearch(object files)
        {
            Delega d = new Delega(cambiaTexto);
            DelegaError dE = new DelegaError(errorPatron);
            int cont = 0;
            lock (l)
            {
                if (files.ToString().EndsWith(".txt"))
                {
                    string patron = _txtboxPatron.Text.Trim();
                    string fileRead = File.ReadAllText(files.ToString());
                    string[] words = fileRead.Split(' ');

                    if (patron == "")
                    {
                        this.Invoke(dE,_lblErrorPatron);
                        return;
                    }


                    for (int i = 0; i < words.Length; i++)
                    {
                        if (_chkboxMayusMin.Checked)
                        {
                            if (words[i].ToLower().Equals(patron.ToLower()))
                            {
                                cont++;
                            }
                        }
                        else
                        {
                            if (words[i].Equals(patron))
                            {
                                cont++;
                            }
                        }
                    }
                    if (cont > 0)
                    {
                        this.Invoke(d, files.ToString() + ". Contiene: " + "\"" + patron + "\" " + cont + " vez/veces.", _txtboxResult);
                    }
                }
            }
        }

        private void errorPatron(Label l)
        {
            l.Visible=true;
        }

        private void cambiaTexto(string texto, TextBox t)
        {
            t.AppendText(texto + Environment.NewLine);
        }


    }
}
