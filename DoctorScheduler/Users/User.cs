using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorScheduler.Users
{
    abstract class User
    {
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckCredentials(string username, string password)
        {
            if (Username == username && Password == password)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
