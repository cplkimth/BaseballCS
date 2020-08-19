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
        private int hp;

        public Marine()
        {
            X = 1;
            Y = 1;
            hp = 50;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void BeAttacked(int damage)
        {
            while (damage > 0 && hp > 0)
            {
                hp--;
                damage--;
            }
        }


    }
}
