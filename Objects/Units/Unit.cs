using System.Net.Http.Headers;

namespace OOP.Objects.Units
{
    internal class Unit : GameObject
    {
        private protected int id;
        private protected string name;
        private protected int x;
        private protected int y;
        private protected float hp;

        static public int baseDamage = 1;

        public Unit(int id, string name, int x, int y, float hp)
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
            this.hp = hp;
        }
        public float getHp()
        {
            return hp;
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
                if (isAlive())
                {
                    Console.WriteLine("{0}: мёртв", this.getFullName());
                }
            }
            else
            {
                Console.WriteLine("{0}: тело получило {1} ед. урона", this.getFullName(), damage);
            }
        }
        public override int getId()
        {
            return id;
        }

        public override string getName()
        {
            return name;
        }

        public override int getX()
        {
            return x;
        }

        public override int getY()
        {
            return y;
        }

        public override string getFullName()
        {
            return string.Format("{0} (id: {1})", this.getName(), this.getId());
        }
    }
}
