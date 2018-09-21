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

        public static Person CreatePerson()
        {
            Console.Clear();
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

            return person;
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
