using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingSpaghettiDatingPaula.Domain
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Gender { get; }
        public int Age { get; }
        
        public Person(string firstName, string lastName, string gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }
    }
}
