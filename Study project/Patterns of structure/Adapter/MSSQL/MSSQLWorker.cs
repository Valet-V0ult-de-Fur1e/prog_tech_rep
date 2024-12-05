namespace OOP.Patterns_of_structure.Adapter.MSSQL
{
    internal class MSSQLWorker : MSSQLInterface
    {
        public void SelectData()
        {
            Console.WriteLine("Selected some data from MS SQL");
        }
    }
}
