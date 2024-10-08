using OOP.ActionInterfaces;
using OOP.Objects.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Objects.Buildings
{
    internal class Fort : Building, Attacker
    {
        private protected int fortsWeaponsDamage = 10;
        public Fort(int id, string name, int x, int y, bool isBuilded) : base(id, name, x, y, isBuilded) {}
        public Fort(int id, string name, int x, int y, bool isBuilded, int fortsWeaponsDamage) : base(id, name, x, y, isBuilded)
        {
            this.fortsWeaponsDamage = fortsWeaponsDamage;
        }

        public void attack(Unit unit)
        {
            unit.receiveDamage(fortsWeaponsDamage);
        }
    }
}
