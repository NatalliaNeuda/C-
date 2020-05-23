using System;

namespace ex49._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("enter the number or <ok>!");
                var render = Console.ReadLine();

                if (String.Equals(render, "ok"))
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(render);
                }

            }
        }
    }
}
