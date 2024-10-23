using OOP.Patterns_of_behavior.Strategy.Interfaces;
using OOP.Patterns_of_behavior.Strategy.Objects;

namespace OOP.Patterns_of_behavior.Strategy
{
    internal class Context
    {
        private StrategyInterface strategy;

        public void setStrategy(StrategyInterface strategy)
        {
            this.strategy = strategy;
        }
        public void engineMove(ElectricEngine electricEngine, int rotation)
        {
            strategy.moveDrive(electricEngine, rotation);
        }
    }
}
