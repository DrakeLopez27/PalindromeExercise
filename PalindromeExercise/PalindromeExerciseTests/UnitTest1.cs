using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", false)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {
            WordSmith tester = new WordSmith();
            bool actual = tester.IsAPalindrome(word);
            Assert.Equal(expected, actual);

        }
    }
}
