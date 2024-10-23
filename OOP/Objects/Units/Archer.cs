using OOP.OOP.Objects.Buildings;
using OOP.OOP.Objects.ActionInterfaces;
using OOP.OOP.Objects.Items.Weapons;

namespace OOP.OOP.Objects.Units
{
    internal class Archer : Unit, Attacker, Moveable
    {
        private protected Weapon weapon;
        public Archer(string name, int x, int y, float hp, int stamina, Weapon newWeapon) : base(name, x, y, hp, stamina)
        {
            weapon = newWeapon;
            newWeapon.ItemStartUsing();
            newWeapon.updateCoords(this.x, this.y);
        }

        public void attack(Unit unit)
        {
            double targetDistance = Math.Sqrt(Math.Pow(unit.getX() - getX(), 2) + Math.Pow(unit.getY() - getY(), 2));
            float attackDamage = 0;
            if (targetDistance <= weapon.getAttackRadius())
            {
                attackDamage = (float)((baseDamage + weapon.getDamage()) * (1 - targetDistance / weapon.getAttackRadius()));
                Console.WriteLine("{0}: нанёс {1} ед. урона {2} предметом {3}", getFullName(), attackDamage, unit.getFullName(), weapon.getFullName());
                unit.receiveDamage(attackDamage);
            }
            else
            {
                Console.WriteLine("{0}: промахнулся", getFullName());
            }
        }
        public void moveTo(int x, int y)
        {
            if (isAlive())
            {
                int oldX = getX();
                int oldY = getY();
                this.x = x;
                this.y = y;
                weapon.updateCoords(this.x, this.y);
                Console.WriteLine("{0}: переместился с координат ({1}, {2}) в координаты ({3}, {4})", getFullName(), oldX, oldY, this.x, this.y);
            }
            else
            {
                Console.WriteLine("{0}: не может переместиться по причине смерть", getFullName());
            }
        }
    }
}
