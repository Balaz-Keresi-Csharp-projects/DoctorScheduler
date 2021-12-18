using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorScheduler.Users
{
    class Patient : User
    {
        public Patient(string name, string password) : base(name, password) {}
    }
}
