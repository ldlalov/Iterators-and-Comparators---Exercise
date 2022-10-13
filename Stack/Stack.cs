using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> StackElements = new List<T>();
        public CustomStack()
        {

        }
        public CustomStack(List<T> stackElements)
        {
            StackElements = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
            StackElements.Insert(StackElements.Count, item);
            }
        }
        public void Pop()
        {
            if (StackElements.Count == 0)
            {
                Console.WriteLine("No elements");
                return;
            }
            StackElements.RemoveAt(StackElements.Count-1);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in StackElements)
            {
                yield return item;
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
