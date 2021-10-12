using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            var threds = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var taskToBeKilled = int.Parse(Console.ReadLine());
            while (true)
            {
                if (tasks.Peek()==taskToBeKilled)

                {
                    break;
                }

                if (tasks.Peek()<=threds.Peek())
                {
                    tasks.Pop();
                    threds.Dequeue();
                }
                else
                {
                    threds.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threds.Peek()} killed task {taskToBeKilled}");
            Console.WriteLine(string.Join(" ",threds));
        }
    }
}


