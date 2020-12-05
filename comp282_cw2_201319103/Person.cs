using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp282_cw2_201319103
{
    class Person
    {
        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Name attribute with get and set
        public string Name { get; set; }

        // Age attribute with get and set
        public int Age { get; set; }

        // Output person with correct format
        public string Output()
        {
            return Name + " (" + Age + ")";
        }

        // Compare's 2 people by their name
        static public int CompareByName(Person person1, Person person2)
        {
            // Return int indication of person1's name vs person2's name
            return person1.Name.CompareTo(person2.Name);
        }

        static public int CompareByNameReverse(Person person1, Person person2)
        {
            // Return int indication of person2's name vs person1's name
            return person2.Name.CompareTo(person1.Name);
        }
        
        // Compare's 2 people by their age
        static public int CompareByAge(Person person1, Person person2)
        {
            // Return int indication of person1's age vs person2's age 
            return person1.Age.CompareTo(person2.Age);
        }

        static public int CompareByAgeReverse(Person person1, Person person2)
        {
            // Return int indication of person2's age vs person1's age 
            return person2.Age.CompareTo(person1.Age);
        }
    }
}
