using System;
using System.IO;
namespace LessthanThree.Domain
{
    public class Names
    {
        public string[] Forenames;
        public string[] Surnames;

        public Names()
        {
            Forenames = File.ReadAllLines(@"Domain/ForenameList.txt");
            Surnames = File.ReadAllLines(@"Domain/SurnameList.txt");
        }
    }
}
