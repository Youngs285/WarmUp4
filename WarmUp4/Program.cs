using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarmUp4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool Palindrome = true;
                Console.Write("Enter a word: ");
                string word = Console.ReadLine().ToLower();

                if (word == "quit")
                    break;
 
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        Palindrome = false;
                    }
                }

                if (Palindrome)
                {
                    Console.WriteLine("It's a Palindrome");
                }
                else
                {
                    Console.WriteLine("It's not a Palindrome");
                }


            }
        }
    }
}
