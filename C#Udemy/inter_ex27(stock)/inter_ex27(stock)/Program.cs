using System;
using System.ComponentModel.DataAnnotations;

namespace inter_ex27_stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            for (var i = 0; i <= 5; i++)
            {
                stack.Push(i);
                

            }
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            /*
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());*/
        }
    }
}
