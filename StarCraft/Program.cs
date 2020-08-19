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
            m1.X = 1;
            //m1.Y = 2;

            Marine m2 = new Marine();

            m1.BeAttacked(5);
            m2.BeAttacked(10);
            Console.WriteLine(m1.HP);
            Console.WriteLine(m2.HP);

            Console.WriteLine(Marine.MaxHP);
            Console.WriteLine(Marine.MaxHP);

            
            m1.BeAttacked(100);

            m1.SetHP(30);
            Console.WriteLine(m1.GetHP());
            m1.SetHP(m1.GetHP() + 1);

            m1.HP = 30;
            Console.WriteLine(m1.HP);
            m1.HP = m1.HP + 1;
        }
    }
}
