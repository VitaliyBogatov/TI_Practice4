using System;
using System.Text.RegularExpressions;


namespace TI_Practice4
{
    class Palindrome
    {
        public string Invert1(string input)
        {
            string _input = ToAlphaNumeric(input.ToLower());

            Console.WriteLine(_input);
            string _output = "";

            foreach (char element in _input)
            {
                _output = element + _output;
            }
            Console.WriteLine(_output);
            return _output;
        }

        public string Invert2(string input)
        {
            string _input = input;
            int length = _input.Length - 1;
            for (int i = 0; length-- >= i; i++)
            {
                _input = _input.Replace(_input.Substring(i, 1), _input.Substring(length, 1));
                Console.WriteLine(_input);
                //length--;
            }
            return _input;
        }

        public string ToAlphaNumeric(string input)
        {
            const string Pattern = @"^\d+|\w+$";
            string _input = input;
            string _result = "";

            for (int i = 0; i < _input.Length; i++)
            {
                if (Regex.IsMatch(_input.Substring(i, 1), Pattern))
                {
                    _result += _input.Substring(i, 1);
                }
            }
            return _result;
        }
    }
}
