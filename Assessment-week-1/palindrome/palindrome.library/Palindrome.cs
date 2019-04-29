using System;
using System.Linq;

namespace palindrome.library
{
    public class Palindrome
    {
        private string word;

        public string Word
        {
            get { return word;}
            set {word=value;}
        }

        public bool IsPalindrome()
        {
            return word.SequenceEqual(word.Reverse());
        }

    }
}
