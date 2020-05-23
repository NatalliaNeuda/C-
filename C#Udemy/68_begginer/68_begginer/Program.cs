using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _68_begginer
{
    class Program
    {
        static bool dup_check(List<int> nb)
        {
            var unic = new List<int>();
            var doubles = false;
            foreach (var number in nb)
            {
                if (!unic.Contains(number))
                {
                    unic.Add(number);
                }
                else
                {
                    doubles = true;
                    break;
                }  
            }
            return (doubles);
        }
        static void ex_01()
        {
            Console.WriteLine("Please, write number trough '-':");
            var str = Console.ReadLine();

            String[] str_split = str.Split("-");

            var nb_list = new List<int>();
            foreach (var number in str_split)
            {
                nb_list.Add(Convert.ToInt32(number));
            }
            var counter1 = 0;
            var counter2 = 0;
            for (var i = 1; i <= nb_list.Count - 1; i++)
            {
                if (nb_list[i] == nb_list[i - 1] + 1)
                    counter1++;
                else if (nb_list[i] == nb_list[i - 1] - 1)
                    counter2++;
            }
            if (counter1 == nb_list.Count - 1 || counter2 == nb_list.Count - 1)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Unconsecutive");
        }
        static void ex_02()
        {
            Console.Write("Write numbers trough hyphen (ex. 1-2-3): ");
            var str = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(str))
                return;

            String[] str_split = str.Split("-");
            var list_nb = new List<int>();
            for (int i = 0; i < str_split.Length; i++)
            {
                list_nb.Add(Convert.ToInt32(str_split[i]));
            }
            var message = dup_check(list_nb) ? "Doubles" : "No doubles";
            Console.WriteLine(message);

        }

        static void ex_03()
        {
            Console.Write("Write time ex(23:42) : ");
            var str = Console.ReadLine();

            String[] str_split = str.Split(":");

            if (str_split.Length != 2)
                Console.WriteLine("Invalid");
            else
            {
                int nmb;
                bool valid = false;
                for (var i = 0; i < 2; i++)
                {
                    nmb = Convert.ToInt32(str_split[i]);
                    if (i == 0 && nmb <= 23 && nmb >= 0)
                        valid = true;
                    else if (i == 1 && nmb <= 59 && nmb >= 0 && valid)
                        Console.WriteLine("Valid time");
                    else
                    {
                        Console.WriteLine("Invalid time");
                        break;
                    }

                }
            }
           /* var timespan = TimeSpan.Parse(str);
            Console.WriteLine(timespan);*/
        }

        static void ex_04()
        {
            Console.WriteLine("Write a few words");
            var str1 = Console.ReadLine();

            str1.Trim(' ');
            var str = str1.ToUpper();
            Console.Write((str[0]));
            bool flag = false;
            var c = str.ToLower();
            for (var i = 1; i < str.Length; i++)
            {
                if (str[i] != ' ' && !flag)
                    Console.Write("{0}", c[i]);
                else if (str[i] == ' ')
                    flag = true;
                else
                {
                    Console.Write(str[i]);
                    flag = false;
                }
            }
        }
        static void ex_05()
        {
            Console.WriteLine("write smth to count vovels:");
            var str = Console.ReadLine();
            var str1 = str.ToLower();
            var counter = 0;
            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] == 'a' || str1[i] == 'o' || str1[i] == 'e' || str1[i] == 'i' || str1[i] == 'u')
                    counter++;
            }
            Console.WriteLine(counter);
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
