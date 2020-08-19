using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit m1 = new Marine();
            LetDance(m1);

            Unit f1 = new Firebat();
            LetDance(f1);

            Unit[] soldiers = new Unit[2];
            soldiers[0] = m1;
            soldiers[1] = f1;

            for (int i = 0; i < soldiers.Length; i++)
            {
                soldiers[i].Move(10, 12);
            }

        }

        private static void LetDance(Unit unit) // overloading
        {
            unit.Move(100, 100);
            unit.Move(1, 1);
        }
    }
}
