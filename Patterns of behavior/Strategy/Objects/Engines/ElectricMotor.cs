namespace OOP.Patterns_of_behavior.Strategy.Objects.Engines
{
    internal class ElectricMotor : ElectricEngine
    {
        public ElectricMotor(string newName, int startRotation) : base(newName, startRotation)
        {
        }

        public override void ChangeRotation(string command)
        {
            Console.WriteLine("{0} using em command {1}", this.name, command);
        }
    }
}
