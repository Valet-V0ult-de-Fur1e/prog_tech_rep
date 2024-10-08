using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Objects.Items.Weapons
{
    internal class Weapon:Item
    {
        private protected int damage;
        private protected int attackRadius;

        public Weapon(int id, string name, int x, int y) : base(id, name, x, y)
        {
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
