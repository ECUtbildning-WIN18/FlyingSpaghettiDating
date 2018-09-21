using System;
using System.Collections.Generic;
namespace LessthanThree.Domain
{
    public class Matching
    {
        private List<Domain.Person> Users { get; set; }
        private Domain.Person Searcher { get; set; }

        public Matching(List<Domain.Person> users, Domain.Person searcher)
        {
            Users = users;
            Searcher = searcher;
        }

        public void Match()
        {
            int OriginalPosition = Users.IndexOf(Searcher);
            Users.Remove(Searcher);
            foreach (Person p in Users)
            {
                int matchCount = 0;
                for (int x = 0; x < p.Interests.InterestList.Count; x++)
                {
                    if (Searcher.Interests.InterestList[x] == p.Interests.InterestList[x] &&
                        Searcher.Interests.InterestList[x] == true)
                    {
                        matchCount++;
                    }
                }
                if (matchCount > 5)
                {
                    Console.WriteLine("\n\tYou got {0} things in common with {1}!", matchCount, p.FirstName);
                }
                matchCount = 0;
            }
            Users.Insert(OriginalPosition, Searcher);
            Console.ReadLine();
        }
    }
}
