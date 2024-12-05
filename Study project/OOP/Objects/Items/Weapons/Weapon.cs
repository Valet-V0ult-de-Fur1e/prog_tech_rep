using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.OOP.Objects.Items;

namespace OOP.OOP.Objects.Items.Weapons
{
    internal class Weapon : Item
    {
        private protected int damage;
        private protected int attackRadius;

        public Weapon(string name, int x, int y, int attackRadius, int damage) : base(name, x, y)
        {
            this.damage = damage;
            this.attackRadius = attackRadius;
        }


        public int getDamage()
        {
            return damage;
        }
        public int getAttackRadius()
        {
            return attackRadius;
        }
    }
}
