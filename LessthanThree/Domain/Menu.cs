using System;
using System.Collections.Generic;
using System.Text;
using LessthanThree;


namespace LessthanThree.Domain
{
    class Menu
    {
        public static List<Tuple<string, string>> users = new List<Tuple<string, string>>();

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("===WELCOME TO <3 DATING=======");
            Console.WriteLine("   Login - press '1' ");
            Console.WriteLine("   Join  - press '2' ");
            Console.WriteLine("   Exit  - press '3' ");
            Console.WriteLine("==============================");

            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
    }
            catch (Exception)
            {
                Console.WriteLine("Number, knobhead, number!!!");
            }
            switch (choice)
            {
                case 1: Login(); break;
                case 2: Join(); break;
                case 3: ; break;
                default: Console.WriteLine("A number within the 1-3 scope, bell-end!!");
                        MainMenu(); break;
            }
        }
        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("===LOGIN=====================");
            Console.WriteLine();
            Console.Write("Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            if (users.Exists(e => e.Item1 == userName))
            {
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if (users.Exists(e => e.Item2 == password))
                {
                    Menu.MainMenu();
                }
                else
                {
                    Console.WriteLine("wrong password");
                    Console.ReadKey();
                    Menu.MainMenu();
                }
            }
            else
            {
                Console.WriteLine("you are not a member");
                Console.ReadKey();
                Menu.MainMenu();

            }
        }
        public static void Join()
        {
            Console.Clear();
            Console.WriteLine("===Registry====================");
            Console.WriteLine();
            Console.Write("Username:");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Password:");
            string password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Your username is {userName}  and your password is {password}");
            Console.WriteLine();
            Console.WriteLine("Is this correct? Y/N");
            string correct = Console.ReadLine();

            if (correct == "y" || correct == "Y")
            {
                users.Add(new Tuple<string, string>(userName, password));

                foreach (var element in users)
                {
                    Console.WriteLine($"Username: {element.Item1} and the password is: {element.Item2}");
                }
                Console.ReadKey();

                Menu.MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Try again!");
                Console.ReadKey();
                Login();
            }


        }
    }
}
