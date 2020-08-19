using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Marine
    {
        public static int MaxHP = 50; // static member

        public void Heal()
        {
            _hp = MaxHP;
        }

        // auto property
        public int X { get; set; }

        public int Y { get; private set; }

        private int _hp; // instance member

        public Marine()
        {
            X = 1;
            Y = 1;
            _hp = 50;
        }

        // getter
        public int GetHP()
        {
            return _hp;
        }

        // setter
        public void SetHP(int hp)
        {
            _hp = hp;
        }

        // sugar syntax
        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void BeAttacked(int damage)
        {
            while (damage > 0 && _hp > 0)
            {
                _hp--;
                damage--;
            }
        }


    }
}
