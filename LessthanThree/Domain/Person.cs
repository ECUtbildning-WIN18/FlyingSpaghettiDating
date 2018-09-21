using System;
namespace LessthanThree.Domain
{
    public class Person
    {
        public Interests Interests         { get; set; }

        public DM Messages;

        public string FirstName     { get; set; }
        public string LastName      { get; set; }
        public int Age              { get; set; }
        public char Gender          { get; set; }
        public char Orientation     { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(Interests i) //DEBUGGING USE
        {
            Random rnd = new Random();
            Names n = new Names();
            string orientations = "abc";
            string genders = "mf";

            FirstName = GetRandomName(n.Forenames, rnd);
            LastName = GetRandomName(n.Surnames, rnd);
            Age = rnd.Next(18, 60);
            Gender = GetRandomCharacter(genders, rnd);
            Orientation = GetRandomCharacter(orientations, rnd);
            DateOfBirth = DateTime.Now;
            Interests = i;
        }

        public Person(string firstName, string lastName, int age, char gender, char orientation, DateTime dob,
                      Interests interests)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Orientation = orientation;
            DateOfBirth = dob;
            Interests = interests;
            Messages = new DM();
        }

        public char GetRandomCharacter(string text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }

        public string GetRandomName(string[] text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }
    }
}
