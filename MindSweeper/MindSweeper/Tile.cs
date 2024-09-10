using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSweeper
{
    internal class Tile
    {
        Button m_b;
        Boolean m_flag;
        public Tile(Button b)
        {
            m_b = b;
        }
    }
}
