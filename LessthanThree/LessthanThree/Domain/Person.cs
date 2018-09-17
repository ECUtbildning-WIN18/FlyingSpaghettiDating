using System;
namespace LessthanThree.Domain
{
    public class Person
    {
        public string FirstName     { get; set; }
        public string LastName      { get; set; }
        public int Age              { get; set; }
        public char Gender          { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool StatusSingle    { get; set; }
        public bool Smoker          { get; set; }
        public bool HasPets         { get; set; }
        public bool HasJob          { get; set; }
        public bool HasEducation    { get; set; }

        public Person(string firstName, string lastName, int age, char gender, DateTime dob,
                     bool statusSingle, bool smoker, bool hasPets, bool hasJob, bool hasEducation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            DateOfBirth = dob;
            StatusSingle = statusSingle;
            Smoker = smoker;
            HasPets = hasPets;
            HasJob = hasJob;
            HasEducation = hasEducation;
        }
    }
}
