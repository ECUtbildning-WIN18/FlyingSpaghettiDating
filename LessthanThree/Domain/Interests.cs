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
        //Then uses these true or false values to other users' values
        public List<bool> InterestList = new List<bool>();

        public string[] WordList =
        {"like cats", "like dogs", "smoke", "like to travel", "work", "study", "believe in a religion",
            "drive", "like sports", "like to game", "like music", "like movies", "like TV/series"
        }; 
        //This is the word list for the interests we use.
        //These strings are appended to "Do you" so they make make sense given the interest/context.

        int x;
        Random rnd = new Random();

        public Interests()
        {
            foreach (string s in WordList)
            {
                Console.WriteLine("\n\tDo you {0}? (1-yes, 2-no)", s);
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

        public Interests(int i)//DEBUGGING USE
        {
            foreach (string s in WordList)
            {
                x = rnd.Next(0, 2);
                switch (x)
                {
                    case 0:
                        InterestList.Add(true);
                        break;
                    case 1:
                        InterestList.Add(false);
                        break;
                }
            }
        }
    }
}
