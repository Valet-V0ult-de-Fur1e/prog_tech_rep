using OOP.OOP.Objects;

namespace OOP.OOP.Objects.Units
{
    internal class Unit : GameObject
    {
        private protected float hp;
        private protected int stamina;
        static private protected int baseDamage = 1;
        static private protected int actualId = 0;
        static private protected void updateActualId() { actualId++; }

        public Unit(string name, int x, int y, float hp, int stamina)
        {
            updateActualId();
            id = actualId;
            this.name = name;
            this.x = x;
            this.y = y;
            this.hp = hp;
            Console.WriteLine("{0}: существо заспавнилось по координатам ({1},{2}) с {3} ед. здоровья", getFullName(), getX(), getY(), getHp());
            this.stamina = stamina;
        }
        public float getHp()
        {
            return hp;
        }
        public int getStamina()
        {
            return stamina;
        }
        public bool isAlive()
        {
            return getHp() > 0;
        }
        public void receiveDamage(float damage)
        {
            if (isAlive())
            {
                hp -= damage;
                Console.WriteLine("{0}: получил {1} ед. урона, текущий уровень здоровья {2} ед.", getFullName(), damage, hp);
                if (!isAlive())
                {
                    Console.WriteLine("{0}: мёртв", getFullName());
                }
            }
            else
            {
                Console.WriteLine("{0}: тело получило {1} ед. урона", getFullName(), damage);
            }
        }

        public override string getFullName()
        {
            return string.Format("{0} (unit id: {1})", getName(), getId());
        }
    }
}
