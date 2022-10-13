using System;
using System.Linq;

namespace ListyIterator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] create = Console.ReadLine().Split();
            var listy = new ListyIterator<string>(create.Skip(1).ToArray());
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                switch(input)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                    case "PrintAll":
                        listy.PrintAll();
                        break;
                }
                //if (create.Length > 1)
                //{
                //    var type = create[1].GetType();
                //    for (int i = 1; i < create.Length-1; i++)
                //    {
                //    }
                //}
            }
        }
    }
}
