using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSweeper
{
    public partial class Form1 : Form
    {
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile [100];
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();

            Reset();

        }
        private Button getButton(int r, int c)
        {
            return (Button)getButton(r, c);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal-1;
        }

        

        private void button101_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
                t.SetFlag();
            else 
                t.SetDug();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                tileGrid[i].SetFlagImage(FlagpictureBox.Image);
                tileGrid[i].SetMineImage(MinepictureBox.Image);
            }
            createMines(5);
        }
        private void createMines(int numMines)
        {
            int mineCount = 0;
            //until we have enough mines
            while (mineCount < numMines)
            {
                //generate num from 1-100
                int rNum = Random.Next(0, 100);

                // set mine on that tile if it doesnt already have a mine
                if (tileGrid[rNum].GetMine() == false)
                {
                    mineCount++;
                    tileGrid[rNum].SetMine(true);
                }
            }



        }
    }
}
