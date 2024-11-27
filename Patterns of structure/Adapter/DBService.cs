using OOP.Patterns_of_structure.Adapter.OldDB;
namespace OOP.Patterns_of_structure.Adapter
{
    internal class DBService
    {
        public void MakeRequestToDB(OldDBInterface db)
        {
            db.FindData();
        }
    }
}
