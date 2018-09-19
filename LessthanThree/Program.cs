using System;
using System.Collections.Generic;

namespace LessthanThree
{
    class Program
    {
        public static List<Domain.Person> Users = new List<Domain.Person>();

        static void Main(string[] args)
        {
            /* Get basic profile info
             * Get interests
             * Create profile
             * Search for mathes based on profile info
             * Return matches
             * Option to message others
             */

            bool done = false;

            while (!done)
            {
                Console.Clear();

                Console.WriteLine("\n\t1. Create User" +
                                  "\n\t2. Delete User" +
                                  "\n\t3. List Users" +
                                  "\n\t4. Match User" +
                                  "\n\t0. Exit");
                if (int.TryParse(Console.ReadLine(), out int response))
                {
                    switch (response)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n\tEntering create user mode..\n\t");
                            CreatePerson();
                            break;
                        case 2:
                            break;
                        case 3:
                            foreach (Domain.Person p in Users)
                            {
                                int index = Users.IndexOf(p);
                                Console.WriteLine("{0} {1}, user number: {2}", p.FirstName, p.LastName, index);
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("\n\tPress return to quit application");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }

        public static void CreatePerson()
        {
            Console.WriteLine("\n\tWhat is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("\n\tWhat is your last name?");
            string lname = Console.ReadLine();
            Console.WriteLine("\n\tHow old are you?");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("\n\tPress return to quit application" +
                                  "\n\tYou probably entered a wrong format somewhere..");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("\n\tWhat is your gender? m-MALE f-FEMALE");
            if (!char.TryParse(Console.ReadLine(), out char g))
            {
                Console.WriteLine("\n\tPress return to quit application" +
                                  "\n\tYou probably entered a wrong format somewhere..");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("\n\tWhat is your sexual orientation?  A-HETERO, B-BISEXUAL C-HOMO");
            if (!char.TryParse(Console.ReadLine(), out char o))
            {
                Console.WriteLine("\n\tPress return to quit application" +
                                  "\n\tYou probably entered a wrong format somewhere..");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("\n\tWhat is your date of birth? YYYY-MM-DD");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Domain.Interests i = new Domain.Interests();

            Domain.Person person = new Domain.Person(name, lname, a, g, o, dob, i);

            Users.Add(person);
        }
    }
}
