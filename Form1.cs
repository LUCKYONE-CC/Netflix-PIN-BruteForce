using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix_PIN_Code_BruteForce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enter = 0;

            char[] input = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int laenge = 4;
            ErzeugeAlleKombinationen("", input, laenge);
            Console.ReadLine();
        }

        private static void ErzeugeAlleKombinationen(String strBegin, char[] ach, int iLen)
        {
            if (iLen <= 0)
            {
                SendKeys.Send(strBegin);
                SendKeys.Send("{ENTER}");
                return;
            }

            foreach (char ch in ach)
            {
                ErzeugeAlleKombinationen(strBegin + ch, ach, iLen - 1);
            }
        }
    }
}
