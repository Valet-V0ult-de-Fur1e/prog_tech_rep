using OOP.ActionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Objects.Buildings
{
    internal class MobileHome : Building, Moveable
    {
        public MobileHome(int id, string name, int x, int y, bool isBuilded) : base(id, name, x, y, isBuilded)
        {
        }
        public void moveTo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
