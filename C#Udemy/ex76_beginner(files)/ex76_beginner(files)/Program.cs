using System;
using System.IO;
using System.Collections.Generic;

namespace ex76_beginner_files_
{
	class Program
	{
		static void wordsCounter()
		{
			char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
			var path = @"C:\Users\Nataly\source\repos\C#Udemy\ex76_beginner(files)\Privet1.txt";
			var content = File.ReadAllText(path);
			foreach (var symbol in content)
				Console.Write(symbol);
			string[] words = content.Split(delimiterChars);
			Console.WriteLine();
			Console.WriteLine(words.Length);
		}

		static void findMaxWordInText()
		{
			char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
			int max = 0;
			int biggest = 0;
			var path = @"C:\Users\Nataly\source\repos\C#Udemy\ex76_beginner(files)\Privet1.txt";
			var content = File.ReadAllText(path);
			//var word = new List<string>;
			string[] words = content.Split(delimiterChars);
			for (var i = 0; i < words.Length; i++)
			{
				if (words[i].Length > max)
				{
					max = words[i].Length;
					biggest = i;
				}
			}
			Console.WriteLine(words[biggest]);

		}
		static void Main(string[] args)
		{
			wordsCounter();
			findMaxWordInText();
		}
	}
}
