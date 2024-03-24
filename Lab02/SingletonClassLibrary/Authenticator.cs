using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClassLibrary
{
    public class Authenticator
    {
        private static Authenticator _instance;
        private Authenticator() { }
        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Authenticator();
            }
            return _instance;
        }
        public void CheckAuthentication(string username, string password)
        {
            if (username == "Admin" && password == "password")
            {
                Console.WriteLine("Authentication successful.");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
        }
    }
}
