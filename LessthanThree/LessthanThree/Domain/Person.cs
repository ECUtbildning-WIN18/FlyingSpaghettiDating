using System;
namespace LessthanThree.Domain
{
    public class Person
    {
        Interests Interests         { get; set; }

        public string FirstName     { get; set; }
        public string LastName      { get; set; }
        public int Age              { get; set; }
        public char Gender          { get; set; }
        public char Orientation     { get; set; }
        public DateTime DateOfBirth { get; set; }

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
        }
    }
}
