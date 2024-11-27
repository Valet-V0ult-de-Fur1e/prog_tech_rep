using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Patterns_of_structure.Bridge.ColorThemes
{
    internal class LightTheme : ColorThemeInterface
    {
        public string getColor()
        {
            return "white";
        }
    }
}
