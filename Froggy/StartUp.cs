using System;
using System.Linq;

namespace Froggy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToList());
            //Frog frog = new Frog();
            //for (int i = 0; i < lake.stones.Count; i += 2)
            //{
            //    frog.Possition = lake.stones[i];
            //    frog.frogMoves.Add(lake.stones[i]);
            //}
            //if (lake.stones.Count % 2 == 0)
            //{

            //    for (int i = lake.stones.Count - 1; i >= 1; i -= 2)
            //    {
            //        frog.Possition = lake.stones[i];
            //        frog.frogMoves.Add(lake.stones[i]);
            //    }
            //}
            //else
            //{
            //    for (int i = lake.stones.Count - 2; i >= 1; i -= 2)
            //    {
            //        frog.Possition = lake.stones[i];
            //        frog.frogMoves.Add(lake.stones[i]);
            //    }
            //}
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
