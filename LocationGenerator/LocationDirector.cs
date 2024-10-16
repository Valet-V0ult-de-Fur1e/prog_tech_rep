using OOP.Spawner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.LocationGenerator
{
    internal class LocationDirector
    {
        private LocationBuilder builder;

        public LocationDirector(LocationBuilder builder)
        {
            this.builder = builder;
        }

        public void constructPizza()
        {
            builder.buildFloorMaterial();
            builder.buildName();
            builder.buildSetMusicalTheme();
        }
    }
}
