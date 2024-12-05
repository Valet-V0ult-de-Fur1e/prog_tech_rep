using OOP.Patterns_of_behavior.Strategy.Interfaces;
using OOP.Patterns_of_behavior.Strategy.Objects;

namespace OOP.Patterns_of_behavior.Strategy.Strategies
{
    internal class ServoDriveControllerStrategy : StrategyInterface
    {
        public void moveDrive(ElectricEngine electricMotor, int degreeOfTiltAngle)
        {
            electricMotor.ChangeRotation(string.Format("sd_move_degree_{0}", degreeOfTiltAngle));
        }
    }
}
