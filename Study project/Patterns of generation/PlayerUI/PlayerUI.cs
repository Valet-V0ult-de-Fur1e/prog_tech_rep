using OOP.OOP.Objects.Units;
using OOP.Player.Interfaces;

namespace OOP.OOP.Player
{
    internal interface PlayerUI
    {
        Icon createIcon();
        StaminaIndicator createStaminaIndicator();
    }
}
