using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something.");
            String input = Console.ReadLine();

            if (input.Length > 1)
            {
                String output = "";
                char[] array = input.ToCharArray();

                foreach (char element in array)
                {
                    output = element + output;
                }

                if (input == output)
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
        }
    }
}
