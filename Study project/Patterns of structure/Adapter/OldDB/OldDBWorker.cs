namespace OOP.Patterns_of_structure.Adapter.OldDB
{
    internal class OldDBWorker : OldDBInterface
    {
        public void FindData()
        {
            Console.WriteLine("Finded some data from Old DB");
        }
    }
}
