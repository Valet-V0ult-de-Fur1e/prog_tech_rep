using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.UserData
{
    internal class UserData
    {
        private static UserData instance;
        private protected int userID;
        private protected string name;
        private UserData(int userID, string name)
        {
            this.userID = userID;
            this.name = name;
        }
        public static UserData getInstance(int userID, string name)
        {
            if (instance == null)
            {
                instance = new UserData(userID, name);
            }
            return instance;
        }
        public int getId()
        {
            return this.userID;
        }
        public string getName()
        {
            return this.name;
        }
        public string getInfo()
        {
            return string.Format("{0} (user id: {1})", this.getName(), this.getId());
        }
    }
}
