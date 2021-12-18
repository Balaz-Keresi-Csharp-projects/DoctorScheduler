using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorScheduler
{
    class Login
    {
        string loggedInUserName;
        string loggedInPassword;
        public void LogIn()
        {
            Console.Write("Username: "); string username = Console.ReadLine();
            Console.Write("Password: "); string password = HiddenInputReader.ReadLine();
            Console.WriteLine();

            if (UserExists(username, password))
            {
                loggedInUserName = username;
                loggedInPassword = password;
                Console.WriteLine("Welcome {0}", username);
            }
            else 
            {
                Console.WriteLine("Login failed. Wrong username or password");
            }
        }

        bool UserExists(string username, string password)
        {
            return true;
        }

    }
}
