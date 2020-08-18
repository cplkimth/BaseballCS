using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Marine
    {
        public int X;
        public int Y;
        public int HP;

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void BeAttacked(int damage)
        {
            HP -= damage;
        }
    }
}
