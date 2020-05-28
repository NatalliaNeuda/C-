using System;

namespace inter_ex16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post(new DateTime(2020, 5, 3, 4, 15, 0));
            post.Title = new string("Hi, Natallia");
            post.Discription = new string("This is post about most beutiful girl in the World");
            
            Console.WriteLine("{0}\n{1}\n{2}\n", post.Title, post.Discription, post.MadeDataTime);
            while (true)
            {
                Console.WriteLine("Votation (input + or - or 'stop')");
                var str = Console.ReadLine();

                if (str == "+")
                {
                    post.SetVoting(1);
                }
                else if (str == "-")
                {
                    post.SetVoting(-1);
                }
                else if (str == "stop")
                {
                    break;
                }
                else
                    Console.WriteLine("only '+', '-', and 'stop' input are acceptable");
            }
            Console.WriteLine(post.GetVoting());
           
        }
    }
}
