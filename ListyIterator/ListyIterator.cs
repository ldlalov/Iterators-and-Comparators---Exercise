using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> Elements;
        private int currentIndex = 0;
        public ListyIterator(params T[] items)
        {
            Elements = new List<T>(items);
        }
        public bool Move()
        {
            if (HasNext())
            {
                currentIndex++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (Elements.Count - 1 > currentIndex)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (Elements.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(Elements[currentIndex]);
            }
        }
        public void PrintAll()
        {
            Console.WriteLine(String.Join(" ", Elements));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in Elements)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
