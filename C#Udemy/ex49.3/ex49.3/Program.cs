using System;

namespace ex49._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorial = 1;
            Console.WriteLine("Write the number, please!");
            var nbr = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= nbr; i++)
                factorial *= i;
            Console.WriteLine(factorial);
        }
    }
}
