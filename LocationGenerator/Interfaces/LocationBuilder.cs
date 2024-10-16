using OOP.LocationGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Spawner.Interfaces
{
    internal interface LocationBuilder
    {
        void buildFloorMaterial();
        void buildName();
        void buildSetMusicalTheme();
        Location getResult();
    }
}
