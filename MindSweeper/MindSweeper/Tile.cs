using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSweeper
{
    internal class Tile
    {
        private Button m_b;
        private Boolean m_flag;
        private Boolean m_dug;
        private Boolean m_mine;
        private int m_nearby;
        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Green;
        }
        public void SetMine(Boolean b) { m_mine = b; }
        public void SetDug(Boolean b) { m_dug = b; }
        public void SetFlag(Boolean b) { m_flag = b; }

    }
}
