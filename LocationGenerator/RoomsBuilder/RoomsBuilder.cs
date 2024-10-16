using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LocationGenerator.RoomsBuilder
{
    internal class RoomsBuilder
    {
        private protected Location location;

        public RoomsBuilder()
        {
            this.location = new Location();
        }

        public void buildFloorMaterial()
        {
            location.setFloorMaterial("камень");
        }

        public void buildName()
        {
            location.setName("сарай");
        }

        public void buildSetMusicalTheme()
        {
            location.setMusicalTheme("звук ветра.mp3");
        }

        public Location getResult()
        {
            return location;
        }
    }
}
