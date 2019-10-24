using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3NT
{
    public partial class Form1 : Form
    {
        int credit = 50;
        public Form1()
        {
            InitializeComponent();
        }

        public void CreditManager()
        {
            credit = credit - 2;
            lblCredit.Text = ("Creditos: " + credit + " $").ToString();
            lblPrize.Text = "Prize: - - $";

            if (credit <= 0)
            {
                btnSpin.Enabled = false;
            }

            if ((Spin1.Text == Spin2.Text) && (Spin2.Text == Spin3.Text))
            {
                credit = credit + 20;
                lblCredit.Text = ("Creditos: " + credit + " $").ToString();
                lblPrize.Text = "Prize: 20 $";
            }
            else if ((Spin1.Text == Spin2.Text) || (Spin1.Text == Spin3.Text) || (Spin2.Text == Spin3.Text))
            {
                credit = credit + 5;
                lblCredit.Text = ("Creditos: " + credit + " $").ToString();
                lblPrize.Text = "Prize: 5 $";
            }

#if PRIZE == true
            if ((Spin1.Text == Spin2.Text) || (Spin1.Text == Spin3.Text) || (Spin2.Text == Spin3.Text))
            {
                credit = credit - 5;
                lblCredit.Text = ("Creditos: " + credit + " $").ToString();
                lblPrize.Text = "Prize: 5 $";
            }
#endif



        }
        private void BtnSpin_Click(object sender, EventArgs e)
        {

            Random ran = new Random();

            Spin1.Text = ran.Next(1, 8).ToString();
            Spin2.Text = ran.Next(1, 8).ToString();
            Spin3.Text = ran.Next(1, 8).ToString();
            CreditManager();


        }

        private void BtnMoreCredit_Click(object sender, EventArgs e)
        {
            credit = credit + 10;
            lblCredit.Text = ("Creditos: " + credit + " $").ToString();
            btnSpin.Enabled = true;
        }
    }
}
