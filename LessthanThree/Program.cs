using System;
using System.Collections.Generic;

namespace LessthanThree
{
    class Program
    {
        public static List<Domain.Person> Users = new List<Domain.Person>();
        //This is the main databse of users; since we dont have users at this time it is filled with
        //random users created at runtime using a method in the Person class, CreateRandomUser.
        //In reality this would pull users from a database.

        public static Domain.Person LoggedInUser;
        //Stores the currently logged in user; information is used for displaying who is currently logged in
        //and for the matching algorithm (excludes the logged in person)

        public static bool done = false;

        static void Main(string[] args)
        {
            while (!done)
            {
                Console.Clear();
                DisplayStatus();
                if (LoggedInUser == null)
                    Menu();
                else
                    LoggedInMenu();
            }
        }

        public static void CreateRandom()
        {
            Domain.Interests i = new Domain.Interests(1);
            Domain.Person p = new Domain.Person(i);
            Users.Add(p);
            Console.WriteLine("\n\tUser created!");
        }

        public static void CreatePerson()
        {
            Domain.Person u = Domain.Person.CreatePerson();
            Domain.Person newUser = new Domain.Person(u.Username, u.Password, u.FirstName, u.LastName, u.Age, 
                                                      u.Gender, u.Orientation, u.DateOfBirth, u.Interests);
            Users.Add(newUser);
        }

        public static void DisplayStatus()
        {
            if (LoggedInUser != null)
            {
                Console.WriteLine("\n\tLogged in user: {0} / {1} {2}", 
                                  LoggedInUser.Username, LoggedInUser.FirstName, LoggedInUser.LastName);
            } else
            {
                Console.WriteLine("\n\tNo user logged in");
            }
        }

        //THIS IS THE METHOD FOR THE MAIN MENU
        //AKA, the menu that appears prior to logging in, allowing account creating and
        //subquent in-logging.
        //Account must be created or, obviously, login WILL fail.
        public static void Menu()
        {
            Console.WriteLine("\n\t1. Create User" +
                              "\n\t2. Log in user" +
                              "\n\t3. Create random user //FOR DEBUGGING" +
                              "\n\t4. List Users //FOR DEBUGGING" +
                              "\n\t5. Delete User //FOR DEBUGGING" +
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
                        Console.Write("\n\tPlease enter your Username: ");
                        string loginName = Console.ReadLine();
                        Console.WriteLine("\n\tPlease enter your Password asscociated with that account: ");
                        string passWord = Console.ReadLine();
                        Domain.Login login = new Domain.Login(loginName, passWord, Users);
                        LoggedInUser = login.TryLogin();
                        break;
                    case 3:
                        CreateRandom();
                        break;
                    case 4:
                        foreach (Domain.Person p in Users)
                        {
                            int index = Users.IndexOf(p);
                            Console.WriteLine("{0} {1}, username: {2}.\t\nAge: {3} \tOrientation:{4} \tGender:{5} \t{6}\n",
                                              p.FirstName, p.LastName, p.Username, p.Age, p.Orientation, p.Gender, p.DateOfBirth);
                        }
                        Console.ReadLine();
                        break;
                    case 0:
                    default: 
                        Console.WriteLine("\n\tExiting..\n\tPress return to quit application..");
                        Console.ReadLine();
                        done = true;
                        break;
                }
            }
        }

        //THIS IS THE METHOD FOR THE MENU ONCE LOGGED IN
        //Through this menu, you can see log in status and perform verious tasks
        //Based on the nature of this app (Dating app)
        public static void LoggedInMenu()
        {
            Console.WriteLine("\n\t1. See your matches with other users!" +
                              "\n\t2. Send new message" +
                              "\n\t3. Inbox" +
                              "\n\t4. Sent box" +
                              "\n\t5. Delete account" +
                              "\n\t0. Logout");
            if (int.TryParse(Console.ReadLine(), out int response))
            {
                switch (response)
                {
                    case 1:
                        Domain.Matching matching = new Domain.Matching(Users, LoggedInUser);
                        matching.Match();
                        break;
                    case 2:
                        Domain.Person receiver = null;
                        Console.WriteLine("\n\tWho would you like to send a message to? (Enter first and last name OR username");
                        Domain.Search s = new Domain.Search(Users);
                        receiver = s.SearchUsersForMessage(Console.ReadLine());
                        if (receiver != null)
                        {
                            Console.WriteLine("\n\tAre you sure you want to send a message to {0} ({1}) 1-yes 2-no)",
                                              receiver.FirstName, receiver.Username);
                            if (int.TryParse(Console.ReadLine(), out int b))
                            {
                                switch (b)
                                { 
                                    case 1:
                                    LoggedInUser.Messages.SendMessage(LoggedInUser, receiver, "Test message!");
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 3:
                        if (LoggedInUser.Messages.Inbox.Count > 0)
                        {
                            Console.WriteLine("\n\tHere are your messages!");
                            foreach (string[] messages in LoggedInUser.Messages.Inbox)
                            {
                                Console.WriteLine(messages[2]);
                            }
                        } else 
                        {
                            Console.WriteLine("\n\tYou havent gotten any messages!\n\tPress enter to continue..");
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        if (LoggedInUser.Messages.Outbox.Count > 0)
                        {
                            Console.WriteLine("\n\tHere are your sent messages!");
                            foreach (string[] messages in LoggedInUser.Messages.Outbox)
                            {
                                Console.WriteLine(messages[2]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\tYou havent sent any messages!\n\tPress enter to continue..");
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("\n\tWould you really like to delete your account? (1- yes 0-no)");
                        if (int.TryParse(Console.ReadLine(), out int a))
                        {
                            switch (a)
                            {
                                case 1:
                                    Users.Remove(LoggedInUser);
                                    LoggedInUser = null;
                                    Console.WriteLine("\n\tAccount deleted!\n\tPress enter to continue..");
                                    break;
                                case 0:
                                default:
                                    break;
                            }
                        }
                        break;
                    case 0:
                        LoggedInUser = null;
                        break;
                    default:
                        Console.WriteLine("\n\tPlease enter a valid menu entry!\n\tPress enter to continue..");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}