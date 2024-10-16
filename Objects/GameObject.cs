namespace OOP.Objects
{
    abstract class GameObject
    {
        private protected int id;
        private protected string name;
        private protected int x;
        private protected int y;
        public abstract string getFullName();
        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
