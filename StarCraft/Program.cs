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
            Marine m1 = new Marine();
            m1.Dead += Marine_Dead;
            
            while(m1.HP > 0)
            {
                Console.ReadLine();
                m1.TakeDamage(20);
                Console.WriteLine(m1);
            }
            
            return;


            Ghost g1 = new Ghost();

            UseSpecialAbility(m1, 3);
            UseSpecialAbility(g1, 3);
        }

        private static void Marine_Dead(object sender, Unit.DeadEventArgs e)
        {
            Console.WriteLine($"{e.UndamagedDamage}만큼의 데미지를 남기고 죽었음");
        }

        static void UseSpecialAbility(ISpecialUnit unit, int n)
        {
            //for (int i = 0; i < n; i++)
            //{
            //    if (unit is Marine) // instanceof
            //        ((Marine)unit).UseSteamPack();
            //    if (unit is Ghost)
            //        ((Ghost)unit).Cloak();

            //    //Marine m = unit as Marine;
            //    //if (m != null)
            //    //    m.UseSteamPack();
            //}

            for (int i = 0; i < n; i++)
            {
                unit.UseSpecialAbility();
            }
        }
    }
}
