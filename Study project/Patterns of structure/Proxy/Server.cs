namespace OOP.Patterns_of_structure.Proxy
{
    class Server : ServerInterface
    {
        public void StartConsoleCommand(string command)
        {
            Console.WriteLine(command + ":\tsuccessfully");
        }
    }
}
