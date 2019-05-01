using System;
using System.Linq;
using System.Text.RegularExpressions;

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
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            string newWord = ""; 
            newWord=rgx.Replace(newWord, ""); //get rid of non alphanumerics
            newWord=Word.ToUpper(); //make all uppercase
            newWord = Regex.Replace(newWord, @"\s", ""); //remove spaces
            return newWord.SequenceEqual(newWord.Reverse()); //reverse word/compare it
        }
    }
}
