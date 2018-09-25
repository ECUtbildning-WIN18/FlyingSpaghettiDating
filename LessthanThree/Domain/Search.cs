using System;
using System.Collections.Generic;
namespace LessthanThree.Domain
{
    public class Search
    {
        public static List<Domain.Person> Users { get; set; }

        public Search(List<Domain.Person> users)
        {
            Users = users;
        }

        //Simple linear search algorithm
        //Searches through list of TYPE Domain.Person (Users) that is obtained
        //from the main method, which contains all the users, hopefully.
        //The search actually takes two sets of arguments;
        //The first set is a single, non spaced or otherwise delimited string.
        //If this type of string is detected, it searches linear-ly through the list for a username match
        //and then returns that Domain.Person value to where it was called
        //The second set is a string that has a space delimiter in it (if the user uses it correctly! grr)
        //The program will then separate this string into 2 parts - first name and last name, respectively,
        //and then search linear-ly through the list, attempting to find a match and then return that Domain.Person value
        public Domain.Person SearchUsersForMessage(string query)
        {
            string[] searchTerm = query.Split(' ');
            string searchFn = "";
            string searchLn = "";
            string searchUn = "";

            if (searchTerm.Length == 2)
            {
                searchUn = searchTerm[0];
            } else if (searchTerm.Length == 1)
            {
                searchFn = searchTerm[0];
                searchLn = searchTerm[1];
            } else
            {
                Console.WriteLine("\n\tUser not found." +
                                      "\n\tPlease only enter the first and last name, separated by a space," +
                                      "or ONLY the username, exactly as it is spelled" +
                                      "\n\tReturning to menu, press enter to continue..");
                return null;
            }
            switch (searchTerm.Length)
            {
                case 1:
                    foreach (Domain.Person p in Users)
                    {
                        if (searchUn == p.Username)
                        {
                            return p;
                        }
                    }
                    break;
                case 2:
                    foreach (Domain.Person p in Users)
                    {
                        if (searchFn == p.FirstName && searchLn == p.LastName)
                        {
                            return p;
                        }
                    }
                    break;
                case 0:
                default:
                    Console.WriteLine("\n\tUser not found." +
                                      "\n\tPlease only enter the first and last name, separated by a space," +
                                      "or ONLY the username, exactly as it is spelled" +
                                      "\n\tReturning to menu, press enter to continue..");
                    Console.ReadLine();
                    break;
            }
            return null;
        }
    }
}
