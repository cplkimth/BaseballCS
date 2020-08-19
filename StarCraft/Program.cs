using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCraft.Units;
using StarCraft.Units.ProtossUnits;
using StarCraft.Units.TerranUnits;

namespace StarCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit m1 = new Marine();
            m1.TakeDamage(30);
            Console.WriteLine(m1);

            Unit f1 = new Firebat();
            f1.TakeDamage(20);
            Console.WriteLine(f1);

            Unit z1 = new Zealot();
            z1.TakeDamage(150);
            Console.WriteLine(z1);
        }

        private static void LetDance(Unit unit) // overloading
        {
            unit.Move(100, 100);
            unit.Move(1, 1);
        }
    }
}
