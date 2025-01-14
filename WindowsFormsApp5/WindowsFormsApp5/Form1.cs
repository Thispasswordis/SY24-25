using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] bits = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            total = 0;
            if (bits[0] != 0)  total += 1;
            if (bits[1] != 0) total += 2;
            if (bits[2] != 0) total += 4;
            if (bits[3] != 0) total += 8;
            if (bits[4] != 0) total += 16;
            if (bits[5] != 0) total += 32;
            if (bits[6] != 0) total += 64;
            if (bits[7] != 0) total += 128;
            TotalLabel.Text = total.ToString(); 

        }

        private void Bit1_TextChanged_1(object sender, EventArgs e)
        {
            //Bit1
            if (Bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            //Bit2
            if (Bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            //Bit3
            if (Bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            //Bit4
            if (Bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //Bit5
            if (Bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            //Bit6
            if (Bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            //Bit7
            if (Bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            //Bit8
            if (Bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;
            Calc();
        }
    }
}
