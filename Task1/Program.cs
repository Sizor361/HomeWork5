using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static string[] SplitText(string text)
        {
            string[] split = text.Split(' ');
            return split;
        }

        static void PrintText (string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");

            string userText = Console.ReadLine();
            string[] words = SplitText(userText);

            PrintText(words);

            Console.ReadKey();
        }
    }
}
