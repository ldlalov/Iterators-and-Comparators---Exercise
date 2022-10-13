using System;
using System.Linq;

namespace Stack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmd = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string cmd1 = cmd[0].Split().FirstOrDefault();
                string[] cmd2 = input.Split(", ").Skip(1).ToArray();
                switch (cmd[0])
                {
                    case "Push":
                        
                        stack.Push(cmd.Skip(1).Select(x => x.Split(",").First()).ToArray());
                        break;
                    case "Pop":
                        stack.Pop();
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
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
