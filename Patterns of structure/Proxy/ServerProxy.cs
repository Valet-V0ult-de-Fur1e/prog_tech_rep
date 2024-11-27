namespace OOP.Patterns_of_structure.Proxy
{
    class ServerProxy : ServerInterface
    {
        private Server server;
        private string rootPassword = "sdfnj122@33_dff";
        private string userPassword;
        
        public ServerProxy(string password)
        {
            this.server = new Server();
            this.userPassword = password;
        }
        public void StartConsoleCommand(string command)
        {
            if (userPassword == rootPassword)
            {
                server.StartConsoleCommand(command);
            }
            else
            {
                Console.WriteLine("access denied");
            }
        }
    }
}
