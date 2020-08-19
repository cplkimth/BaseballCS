using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Unit
    {
        public int X { get; set; } // auto property

        private int _y;

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
