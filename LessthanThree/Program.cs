using System;
using System.Collections.Generic;

namespace LessthanThree
{
    class Program
    {
        public static List<Domain.Person> Users = new List<Domain.Person>();
        public static Domain.Person LoggedInUser;

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
                                  "\n\t4. Match currently logged in User" +
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
                            CreateRandom();
                            break;
                        case 3:
                            foreach (Domain.Person p in Users)
                            {
                                int index = Users.IndexOf(p);
                                Console.WriteLine("{0} {1}, user number: {2}.\t\t \nAge: {3} \tOrientation:{4} \tGender:{5} \t{6}\n", 
                                                  p.FirstName, p.LastName, index, p.Age, p.Orientation, p.Gender, p.DateOfBirth);
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            Domain.Matching testMatch = new Domain.Matching(Users, LoggedInUser);
                            testMatch.Match();
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

        public static void CreateRandom()

        {
            Domain.Interests i = new Domain.Interests(1);
            Domain.Person p = new Domain.Person(i);
            Users.Add(p);
            Console.WriteLine("User created");
        }


        public static void CreatePerson()
        {
            Domain.Person u = Domain.Person.CreatePerson();
            Domain.Person newUser = new Domain.Person(u.FirstName, u.LastName, u.Age, 
                                                      u.Gender, u.Orientation, u.DateOfBirth, u.Interests);
            Users.Add(newUser);
            LoggedInUser = newUser;
        }
    }
}
