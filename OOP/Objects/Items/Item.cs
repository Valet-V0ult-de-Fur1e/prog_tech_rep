using OOP.OOP.Objects;

namespace OOP.OOP.Objects.Items
{
    internal class Item : GameObject
    {
        private protected bool isUsed;
        static private protected int actualId = 0;
        static private protected void updateActualId() { actualId++; }
        public Item(string name, int x, int y)
        {
            updateActualId();
            id = actualId;
            this.name = name;
            this.x = x;
            this.y = y;
        }
        public void updateCoords(int newX, int newY)
        {
            x = newX;
            y = newY;
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
            return string.Format("{0} (id: {1})", getName(), getId());
        }
    }
}