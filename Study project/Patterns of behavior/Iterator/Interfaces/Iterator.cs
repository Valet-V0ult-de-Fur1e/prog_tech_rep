using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Patterns_of_behavior.Iterator.Interfaces
{
    internal interface Iterator <T>
    {
        bool hasNext();
        T next();
    }
}
