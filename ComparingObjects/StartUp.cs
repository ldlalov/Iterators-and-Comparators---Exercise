using System;
using System.Collections.Generic;
using System.Drawing;

namespace ComparingObjects
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] prsn = input.Split();
                Person person = new Person(prsn[0], int.Parse(prsn[1]), prsn[2]);
                people.Add(person);
            }
            int n = int.Parse(Console.ReadLine()) ;
            int matches = 0;
            //int nonMatches = 0;
            foreach (var person in people)
            {
                if (people[n-1].CompareTo(person) == 0)
                {
                    matches++;
                }
            }
            if (matches == 1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
        }
    }
}
