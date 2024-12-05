namespace OOP.Patterns_of_behavior.Strategy.Objects.Engines
{
    internal class ServoDrive : ElectricEngine
    {
        public ServoDrive(string newName, int startRotation) : base(newName, startRotation)
        {
        }

        public override void ChangeRotation(string command)
        {
            Console.WriteLine("{0} using sd command {1}", this.name, command);
        }
    }
}
