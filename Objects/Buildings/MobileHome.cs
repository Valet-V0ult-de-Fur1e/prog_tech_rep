using OOP.Objects.ActionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Objects.Buildings
{
    internal class MobileHome : Building, Moveable
    {
        public MobileHome(string name, int x, int y, bool isBuilded) : base(name, x, y, isBuilded)
        {
        }
        public void moveTo(int x, int y)
        {
            if (this.isBuild())
            {
                int oldX = this.getX();
                int oldY = this.getY();
                this.x = x;
                this.y = y;
                Console.WriteLine("{0}: переместился с координат ({1}, {2}) в координаты ({3}, {4})", this.getFullName(), oldX, oldY, this.x, this.y);
            }
            else
            {
                Console.WriteLine("{0}: не может переместиться по причине ещё не построено", this.getFullName());
            }
        }
    }
}
