using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Objects.Buildings
{
    internal class Building : GameObject
    {
        private protected bool isBuilded;
        static private protected int actualId = 0;
        static private protected void updateActualId() { actualId++; }
        public Building(string name, int x, int y, bool isBuilded)
        {
            updateActualId();
            this.id = actualId;
            this.name = name;
            this.x = x;
            this.y = y;
            this.isBuilded = isBuilded;
        }
        public bool isBuild()
        {
            return isBuilded;
        }
        public override string getFullName()
        {
            return string.Format("{0} (building id: {1})", this.getName(), this.getId());
        }
    }
}
