using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Zealot : Unit
    {
        public Zealot()
        {
            HP = 100;
            Shield = 100;
        }

        public int Shield { get; private set; }
    }
}
