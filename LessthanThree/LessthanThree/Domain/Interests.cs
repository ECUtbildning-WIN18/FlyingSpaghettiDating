using System;
using System.Collections.Generic;

namespace LessthanThree.Domain
{
    public class Interests
    {
        //List of interests in boolean format.
        //It will compare the true/false values of users' own input to other users'
        //If the value matches (true), the searching user will be notified.. somehow.

        // 1 Cats       
        // 2 Dogs       
        // 3 Smoke      
        // 4 Travel     
        // 5 Work       
        // 6 Study      
        // 7 Religious  
        // 8 Drive      
        // 9 Sports     
        // 10 Games      
        // 11 Music      
        // 12 Movies     
        // 13 TV         

        //Uses a list that stores true or false values which corrosping to the items above;
        //EG, the List at index 1 corrosponds to a true or false value referring to cats.
        //Then uses these true or false values to other user's values

        public List<bool> InterestList = new List<bool>();

        int x;

        public Interests()
        {
            Console.WriteLine("Do you like cats? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x) {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            } else 
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like dogs?? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you smoke? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like to travel? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you work? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like study? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Are you religious? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you drive? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like sports? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like games? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like music? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like movies? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }

            Console.WriteLine("Do you like TV/series? 1-yes 2-no");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                switch (x)
                {
                    case 1:
                        InterestList.Add(true);
                        break;
                    case 2:
                        InterestList.Add(false);
                        break;
                    default:
                        Console.WriteLine("Invalid input detected, closing program");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input detected, closing program");
                Environment.Exit(0);
            }


        }
    }
}
