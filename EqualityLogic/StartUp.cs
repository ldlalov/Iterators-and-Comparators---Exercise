using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> peopleSorted = new SortedSet<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

            string[] personData = Console.ReadLine().Split();
            Person person = new Person(personData[0], int.Parse(personData[1]));
                    bool isThere = false;
                if (people.Count != 0)
                {
                    foreach (var p in people)
                    {
                        if (p.CompareTo(person) == 0)
                        {
                            isThere = true;
                        }
                    }
                    if (!isThere)
                    {
                        people.Add(person);
                    }

                }
                else
                {
                    people.Add(person);
                }
                peopleSorted.Add(person);
            }
            Console.WriteLine(people.Count);
            Console.WriteLine(peopleSorted.Count);
        }
    }
}
