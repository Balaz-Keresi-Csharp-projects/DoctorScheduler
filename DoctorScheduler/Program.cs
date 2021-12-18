using System;

namespace DoctorScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentWelcomeScreen();
            Login login = new Login();
            login.LogIn();
        }

        static void PresentWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("*** This program is the implementation of a karan project idea, namely: Create a patient class and a doctor class. ***");
            Console.WriteLine("*** Have a doctor that can handle multiple patients and setup a scheduling program where a doctor can only handle  ***");
            Console.WriteLine("*** 16 patients during an 8 hr work day.                                                                           ***");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
