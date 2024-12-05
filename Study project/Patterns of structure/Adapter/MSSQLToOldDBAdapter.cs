using OOP.Patterns_of_structure.Adapter.MSSQL;
using OOP.Patterns_of_structure.Adapter.OldDB;

namespace OOP.Patterns_of_structure.Adapter
{
    internal class MSSQLToOldDBAdapter : OldDBInterface
    {
        MSSQLWorker _MSSQLWorker;
        public MSSQLToOldDBAdapter (MSSQLWorker mssQLWorker)
        {
            _MSSQLWorker = mssQLWorker;
        }
        public void FindData()
        {
            _MSSQLWorker.SelectData();
        }
    }
}
