using System;

namespace TI_Practice4
{
    class Practice4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something.");
            String input = Console.ReadLine();

            input = "qwer#$% %^&?><ty1^& 1ytr^& ewq";

            Palindrome palindrome = new Palindrome();
            Console.WriteLine(palindrome.ToAlphaNumeric(input)); ;


            if (input.Length > 1)
            {
                if (input.Equals(palindrome.Invert1(input)))
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
