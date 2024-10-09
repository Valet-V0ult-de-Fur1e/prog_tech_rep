namespace OOP.Objects.Items
{
    internal class Item : GameObject
    {
        private protected int id;
        private protected string name;
        private protected int x;
        private protected int y;
        private protected bool isUsed;
        static private protected int actualId = 0;
        static private protected void updateActualId() { actualId++; }
        public Item (string name, int x, int y)
        {
            updateActualId();
            this.id = actualId;
            this.name = name;
            this.x = x;
            this.y = y;
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
        public void updateCoords(int newX, int newY) 
        { 
            this.x = newX;
            this.y = newY;
        }
        public bool itemIsUsed()
        {
            return isUsed;
        }
        public void ItemStartUsing()
        {
            isUsed = true;
        }
        public override string getFullName()
        {
            return string.Format("{0} (id: {1})", this.getName(), this.getId());
        }
    }
}