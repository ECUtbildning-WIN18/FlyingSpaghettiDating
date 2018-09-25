using System;
using System.Collections.Generic;
namespace LessthanThree.Domain
{
    public class Login
    {
        public static List<Domain.Person> Users { get; set; }

        string UserLogin { get; }
        string UserPassword { get; }

        public Login(string userLogin, string userPassword, List<Domain.Person> users)
        {
            Users = users;
            UserLogin = userLogin;
            UserPassword = userPassword;
        }

        public Person TryLogin()
        {
            foreach (Person p in Users)
            {
                if (UserLogin == p.Username && UserPassword == p.Password)
                {
                    Console.WriteLine("\n\tLogging in {0} {1}", p.FirstName, p.LastName);
                    return p;
                }
            }
            Console.WriteLine("\n\tUser not found!\n\tPress enter to continue..");
            Console.ReadLine();
            return null;
        }
    }
}
