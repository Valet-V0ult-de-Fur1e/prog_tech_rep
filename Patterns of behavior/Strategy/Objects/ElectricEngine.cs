namespace OOP.Patterns_of_behavior.Strategy.Objects
{
    internal class ElectricEngine
    {
        public ElectricEngine(string newName, int startRotation) 
        {
            this.name = newName;
            this.rotation = startRotation;
        }
        public string name { get; init; } = "Undefined";
        public int rotation { get; init; } = 0;

        public virtual void ChangeRotation(string command) { }
    }
}
