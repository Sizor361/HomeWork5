using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void SplitText(string text)
        {
            string[] split = text.Split(' ');
            ReverseText(split);
        }

        static void ReverseText(string[] text)
        {
            string reverseWords = "";

            for (int i = text.Length -1; i >= 0; i--)
            {
                reverseWords += text[i] + "\n"; 

            }
            Console.WriteLine(reverseWords);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");

            string userText = Console.ReadLine();
            SplitText(userText);

            Console.ReadKey();
        }
    }
}
