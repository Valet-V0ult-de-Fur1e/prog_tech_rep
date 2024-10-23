using OOP.OOP.Objects.ActionInterfaces;
using OOP.OOP.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOP.Objects.Buildings
{
    internal class Fort : Building, Attacker
    {
        private protected int fortsWeaponsDamage = 10;
        public Fort(string name, int x, int y, bool isBuilded) : base(name, x, y, isBuilded) { }
        public Fort(string name, int x, int y, bool isBuilded, int fortsWeaponsDamage) : base(name, x, y, isBuilded)
        {
            this.fortsWeaponsDamage = fortsWeaponsDamage;
        }

        public void attack(Unit unit)
        {
            unit.receiveDamage(fortsWeaponsDamage);
        }
    }
}
