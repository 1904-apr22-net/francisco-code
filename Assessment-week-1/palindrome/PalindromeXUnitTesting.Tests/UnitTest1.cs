using palindrome.library;
using System;
using Xunit;

namespace PalindromeXUnitTesting.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("nurses run")]
        //[InlineData(null)] // duplicating the above test
        [InlineData("racecaR")]
        [InlineData("1221")]
        
        public void checkIfPalindromeTrue(string inputWord)
        {
            //arrange
            Palindrome pal = new Palindrome();
            pal.Word = inputWord;

            //act
            bool result =pal.IsPalindrome();

            //assert
            Assert.True(result);
            
        }
        [Theory]
        [InlineData("never odd, or even")]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void checkIfPalindromeFalse(string inputWord)
        {
            //arrange
            Palindrome pal = new Palindrome();
            pal.Word = inputWord;

            //act
            bool result = pal.IsPalindrome();

            //assert
            Assert.False(result);
        }
    }
}
