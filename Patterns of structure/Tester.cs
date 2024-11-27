using OOP.Patterns_of_structure.Adapter;
using OOP.Patterns_of_structure.Adapter.MSSQL;
using OOP.Patterns_of_structure.Adapter.OldDB;
using OOP.Patterns_of_structure.Bridge.ColorThemes;
using OOP.Patterns_of_structure.Bridge.Pages;
using OOP.Patterns_of_structure.Proxy;

namespace OOP.Patterns_of_structure
{
    class Tester
    {
        public static void TestAdapter()
        {
            DBService dBService = new DBService();
            OldDBWorker worker = new OldDBWorker();
            dBService.MakeRequestToDB(worker);
            MSSQLWorker worker2 = new MSSQLWorker();
            OldDBInterface _MSSQLToOldDBAdapter = new MSSQLToOldDBAdapter(worker2);
            dBService.MakeRequestToDB(_MSSQLToOldDBAdapter);
        }
        public static void TestProxy()
        {
            ServerInterface rootUser = new ServerProxy("sdfnj122@33_dff");
            ServerInterface otherUser = new ServerProxy("Qweertrt123");
            rootUser.StartConsoleCommand("sudo mkdir smthDir");
            otherUser.StartConsoleCommand("sudo mkdir smthDir");

        }
        public static void TestBridge()
        {
            BlackTheme blackTheme = new BlackTheme();
            About aboutPage = new About(blackTheme);
            Contacts contactsPage = new Contacts(blackTheme);
            aboutPage.getContent();
            contactsPage.getContent();
        }
    }
}
