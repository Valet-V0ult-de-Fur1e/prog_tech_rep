using OOP.ActionInterfaces;
using OOP.Objects.Buildings;
using OOP.Objects.Items.Weapons;

namespace OOP.Objects.Units
{
    internal class Archer : Unit, Attacker, Moveable
    {
        private protected Weapon weapon;
        public Archer(int id, string name, int x, int y, float hp, Weapon newWeapon) : base(id, name, x, y, hp) 
        {
            this.weapon = newWeapon;
            newWeapon.ItemStartUsing();
            newWeapon.updateCoords(this.x, this.y);
        }

        public void attack(Unit unit)
        {
            double targetDistance = Math.Sqrt(Math.Pow(unit.getX() - this.getX(), 2) + Math.Pow(unit.getY() - this.getY(), 2));
            float attackDamage = 0;
            if (targetDistance <= weapon.getAttackRadius()) 
            {
                attackDamage = (float)((Unit.baseDamage + this.weapon.getDamage()) * (1 - targetDistance / weapon.getAttackRadius()));
                unit.receiveDamage(attackDamage);
            }
            Console.WriteLine("{0}: нанёс {1} ед. урона {2} предметом {3}", this.getFullName(), attackDamage, unit.getFullName(), this.weapon.getFullName());
        }
        public void moveTo(int x, int y)
        {
            if (this.isAlive())
            {
                int oldX = this.getX();
                int oldY = this.getY();
                this.x = x;
                this.y = y;
                this.weapon.updateCoords(this.x, this.y);
                Console.WriteLine("{0}: переместился с координат ({1}, {2}) в координаты ({3}, {4})", this.getFullName(), oldX, oldY, this.x, this.y);
            }
            else
            {
                Console.WriteLine("{0}: не может переместиться по причине смерть", this.getFullName());
            }
        }
    }
}
