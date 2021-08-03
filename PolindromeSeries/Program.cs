using System;

namespace PolindromeSeries
{
        class Program
        {
            static void Main(string[] args)
            {
                string s;
                string rev = "";
                Console.WriteLine("Enter string");
                s = Console.ReadLine();
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    rev += s[i].ToString();
                }
                if (rev == s)
                {
                    Console.WriteLine("Given String is Palindrome\n", s, rev);
                }
                else
                {
                    Console.WriteLine("Given String is not Palindrome", s, rev);
                }
                Console.ReadLine();
            }
        }
    }