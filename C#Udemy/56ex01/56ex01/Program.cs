using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _56ex01
{
    class Program
    {
        static void ex_01()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }
            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

        static void ex_02()
        {
            Console.WriteLine("Type your name, please:");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine(reversed);
        }

        static void ex_03()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Type a number (or hit ENTER to quit): ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(input))
                {
                    Console.WriteLine("Your list already has {0}, write different number:", input);
                    //input = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                numbers.Add(Convert.ToInt32(input));

            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void ex_04()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Type a number or 'Quit' for exit:");
                var str = Console.ReadLine();
                var str1 = str.ToLower();
                if (str1 == "quit")
                {
                    break;
                }
                var number = Convert.ToInt32(str);
                numbers.Add(number);
            }
            numbers.Sort();
            var new_nb = new List<int>();
            foreach (var nbr in numbers)
            {
                if (!new_nb.Contains(nbr))
                {
                    new_nb.Add(nbr);
                    Console.WriteLine(nbr);
                }
            }
        }

        static void ex_05()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("write line of numbers separated by comma and space. When you finish, press enter");
                var str = Console.ReadLine();
                char[] separator = { ',', ' ' };

                String[] stringlist = str.Split(',');
                if (stringlist.Length < 5)
                {
                    Console.WriteLine("Not enough numbers. Try again");
                    continue;
                }
                else
                {
                    foreach (var nbr in stringlist)
                    {
                        numbers.Add(Convert.ToInt32(nbr));
                    }
                    break;
                }
            }
            numbers.Sort();
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void Main(string[] args)
        {
            //ex_01();
            //ex_02();
            //ex_03();
            //ex_04();
            ex_05();
        }
    }
}
