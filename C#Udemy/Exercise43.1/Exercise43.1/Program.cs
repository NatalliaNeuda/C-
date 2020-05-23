using System;

namespace Exercise43._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;

            Console.WriteLine("Enter the number, please: ");

            string c = Console.ReadLine();
            x = Convert.ToInt32(c);
            if ( x > 0 && x < 11)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
