using OOP.OOP.Player;
using OOP.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Player.WarriorUI
{
    internal class WarriorUIFactory : PlayerUI
    {
        public Icon createIcon()
        {
            return new WarriorIcons();
        }

        public StaminaIndicator createStaminaIndicator()
        {
            return new WarriorStamina();
        }
    }
}
