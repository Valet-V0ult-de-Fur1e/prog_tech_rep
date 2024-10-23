namespace OOP.Objects.Units
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
            this.id = actualId;
            this.name = name;
            this.x = x;
            this.y = y;
            this.hp = hp;
            Console.WriteLine("{0}: существо заспавнилось по координатам ({1},{2}) с {3} ед. здоровья", this.getFullName(), this.getX(), this.getY(), this.getHp());
            this.stamina = stamina;
        }
        public float getHp()
        {
            return this.hp;
        }
        public int getStamina()
        {
            return this.stamina;
        }
        public bool isAlive()
        {
            return getHp() > 0;
        }
        public void receiveDamage(float damage)
        {
            if (isAlive())
            {
                this.hp -= damage;
                Console.WriteLine("{0}: получил {1} ед. урона, текущий уровень здоровья {2} ед.", this.getFullName(), damage, this.hp);
                if (!isAlive())
                {
                    Console.WriteLine("{0}: мёртв", this.getFullName());
                }
            }
            else
            {
                Console.WriteLine("{0}: тело получило {1} ед. урона", this.getFullName(), damage);
            }
        }

        public override string getFullName()
        {
            return string.Format("{0} (unit id: {1})", this.getName(), this.getId());
        }
    }
}
