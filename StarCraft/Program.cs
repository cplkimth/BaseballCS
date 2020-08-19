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
            
            m1.BeAttacked(100);

            m1.hp = 30;
            Console.WriteLine(m1.hp);

        }
    }
}
