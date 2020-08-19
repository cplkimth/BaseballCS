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
            Ghost g1 = new Ghost();

            UseSpecialAbility(m1, 3);
            UseSpecialAbility(g1, 3);
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
