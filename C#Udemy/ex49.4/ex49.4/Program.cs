using System;

namespace ex49._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var attempt = 0;
            var random = new Random();
            var guess_nbr = random.Next(1, 10);

            while (attempt <= 3)
            {
                Console.WriteLine("Pick number betveen 1 and 10!");
                var nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr == guess_nbr)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (nbr != guess_nbr && attempt != 3)
                {
                    Console.WriteLine("Try again");
                    attempt++;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Guessing number was : {0}", guess_nbr);
                    break;
                }
            }    
        }
    }
}
