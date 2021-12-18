using System;
using System.Collections.Generic;
using DoctorScheduler.Users;


namespace DoctorScheduler
{
    class Login
    {
        User loggedInUser;
        List<User> users = new List<User>();

        public Login()
        {
            users.Add(new Patient("Balazs", "Password"));
            users.Add(new Patient("Michael", "BlackOrWhite"));
            users.Add(new Patient("D", "Give_Me_Money"));
        }
        public void LogIn()
        {
            Console.Write("Username: "); string username = Console.ReadLine();
            Console.Write("Password: "); string password = HiddenInputReader.ReadLine();
            Console.WriteLine();

            if (TryToLogInUser(username, password))
            {
                
                Console.WriteLine("Welcome {0}", loggedInUser.Username);
            }
            else 
            {
                Console.WriteLine("Login failed. Wrong username or password");
            }
        }

        bool TryToLogInUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.CheckCredentials(username, password))
                {
                    loggedInUser = user;
                    return true;
                }
            }
            return false;
        }

    }
}
