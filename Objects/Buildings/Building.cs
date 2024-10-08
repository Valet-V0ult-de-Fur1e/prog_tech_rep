using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Objects.Buildings
{
    internal class Building : GameObject
    {
        private int id;
        private string name;
        private int x;
        private int y;
        private bool isBuilded;
        public Building(int id, string name, int x, int y, bool isBuilded)
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
            this.isBuilded = isBuilded;
        }
        public bool isBuild()
        {
            return isBuilded;
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
