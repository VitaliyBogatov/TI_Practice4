using System;
using System.Text.RegularExpressions;


namespace TI_Practice4
{
    public class Palindrome
    {
        public string GetInvertedString(string str)
        {
            string input = ToAlphaNumeric(str.ToLower());

            Console.WriteLine(input);
            string output = "";

            foreach (char element in input)
            {
                output = element + output;
            }
            Console.WriteLine(output);
            return output;
        }

        public string ToAlphaNumeric(string str)
            {
            const string Pattern = @"^\d+|\w+$";
            string input = str;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(input.Substring(i, 1), Pattern))
                {
                    result += input.Substring(i, 1);
                }
            }
            return result;
        }
    }
}
