using System;


namespace inter_ex16._1
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var game = new Game();

            while (true)
            {
                Console.Write("write 'set', 'stop', 'exit': ");
                var str = Console.ReadLine();
                if (str == "set" && game._status != 1)
                {
                    game.SetStart();
                    Console.WriteLine("start is {0} ", game.GetStart());
                }
                
                else if (str == "stop" && game._status != 2)
                {
                    game.SetStop();
                    Console.WriteLine("stop is {0}", game.GetStop());
                    game.TimeSpawner();
                    Console.WriteLine(game._duration);
                }
                else if (str == "exit")
                    break;
                else
                    Console.WriteLine("You can't set start or stop twice in the row");
            }
        }
    }
}
