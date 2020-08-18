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
            Marine m1 = new Marine();
            Marine m2 = new Marine();

            //MoveMarine(m1, 100, 100);
            m1.Move(100, 100);
            
            //BeAttacked(m2, 3);
            m2.BeAttacked(3);

            //Firebat firebat = new Firebat();
            //MoveFirebat(firebat, 100, 100);
        }
    }
}
