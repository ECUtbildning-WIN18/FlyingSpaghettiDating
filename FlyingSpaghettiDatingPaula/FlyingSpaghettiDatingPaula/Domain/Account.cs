using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingSpaghettiDatingPaula.Domain
{
    class Account : Person
    {
        private string AccountName { get; }
        private string AccountPassword { get; }
        public bool LogIn { get; set; }
        public bool LogOut { get; set; }

        public Account(string firstName, string lastName, string gender, int age, string accountName, string accountPassword) : base(firstName, lastName, gender, age)
        {
            AccountName = accountName;
            AccountPassword = accountPassword;
        }

        public void Logfunktion(bool logIn)
        {
            LogIn = logIn;
            Console.WriteLine("Welcome to FlyingSpaghettiDating site. Hope you find your soulmate soon");
        }
        public void LogFunktion(bool logOut)
        {
            LogOut = logOut;
            Console.WriteLine("Bye! Have a nice day!");
        }
        
    }
}
