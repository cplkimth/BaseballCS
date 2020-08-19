using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft.Units.TerranUnits
{
    class Ghost : TerranUnit, ISpecialUnit
    {
        protected override string UnitName => "Ghost";

        public void Cloak()
        {
            Console.WriteLine("숨음");
        }

        public void UseSpecialAbility()
        {
            Cloak();
        }
    }
}
