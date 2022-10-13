using System;
using System.Linq;

namespace CustomComparator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = array.Where(x => x % 2 == 0).ToArray();
            Array.Sort(array2);
            int[] array3 = array.Where(x => x % 2 != 0).ToArray();
            Array.Sort(array3);
            int[] array4 = array2.Concat(array3).ToArray();
            //int[] array1 = array.OrderBy(x => Math.Abs(x) % 2).ToArray();
            Console.WriteLine(String.Join(" ", array4));
        }
    }
}
