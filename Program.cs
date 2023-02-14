using System;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enters word
            Console.WriteLine("Enter a word!");
            string word = Console.ReadLine();
            #endregion
            int p = word.Length;
            bool ispalindrome = true;
            // creates a loop and cuts the word halfway to only check the first letters to see if = to last
            for (int i = 0; i < p / 2; i++)
            {  
                // if not = then false
                if (word[i] != word[p - i - 1])
                {
                    ispalindrome = false;
                }
            }
            if (ispalindrome)
            {
                Console.WriteLine(word + " is a palindrome");
            }
            else
            {
                Console.WriteLine (word + " not a palindrome");
            }
        }
        }
    }

