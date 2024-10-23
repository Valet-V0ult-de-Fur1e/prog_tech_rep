using OOP.Patterns_of_behavior.Strategy.Objects;

namespace OOP.Patterns_of_behavior.Strategy.Interfaces
{
    internal interface StrategyInterface
    {
        void moveDrive(ElectricEngine electricEngine, int degreeOfTiltAngle);
    }
}
