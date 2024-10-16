using OOP.Objects.Units;
using OOP.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Player
{
    internal interface PlayerUI
    {
        Icon createIcon();
        StaminaIndicator createStaminaIndicator();
    }
}
