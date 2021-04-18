using System;

namespace TI_Practice4
{
    class Practice4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something.");
            String input = Console.ReadLine();

            Palindrome palindrome1 = new Palindrome();
            Palindrome palindrome2 = new Palindrome();

            if (input.Length > 1)
            {
                if (palindrome1.ToAlphaNumeric(input).Equals(palindrome2.GetInvertedString(input)))
                {
                    Console.WriteLine("You have written a palindrome.");
                }
                else
                {
                    Console.WriteLine("Written string is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("You have written a palindrome.");
            }
            Console.ReadKey();
        }
    }
}
