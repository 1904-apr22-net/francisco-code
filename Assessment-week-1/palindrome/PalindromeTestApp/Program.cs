using palindrome.library;
using System;

namespace PalindromeTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palindrome pal1 = new Palindrome();
            pal1.Word = "nurses run";
            pal1.IsPalindrome();
            Console.WriteLine(pal1.Word);
        }
    }
}
