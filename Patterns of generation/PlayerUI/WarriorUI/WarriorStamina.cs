using OOP.OOP.Objects.Units;
using OOP.Player.Interfaces;

namespace OOP.Player.WarriorUI
{
    internal class WarriorStamina : StaminaIndicator
    {
        public void printCount(Unit unit)
        {
            Console.WriteLine("{1}: stamina = {0} ед.", unit.getStamina(), unit.getFullName());
        }
    }
}
