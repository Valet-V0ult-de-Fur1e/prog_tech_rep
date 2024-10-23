using OOP.OOP.Player;
using OOP.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Player.WizzardUI
{
    internal class WizzardUIFactory : PlayerUI
    {
        public Icon createIcon()
        {
            return new WizzardIcons();
        }

        public StaminaIndicator createStaminaIndicator()
        {
            return new WizzardMana();
        }
    }
}
