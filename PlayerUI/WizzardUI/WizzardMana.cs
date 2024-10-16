using OOP.Objects.Units;
using OOP.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Player.WizzardUI
{
    internal class WizzardMana : StaminaIndicator
    {
        public void printCount(Unit unit)
        {
            Console.WriteLine("{1}: mana = {0} ед.", unit.getStamina(), unit.getFullName());
        }
    }
}
