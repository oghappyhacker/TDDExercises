using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class PalindromeCheckerServiceTests
    {
        private readonly PalindromeCheckerService _sut;
        public PalindromeCheckerServiceTests()
        {
            _sut = new PalindromeCheckerService();
        }
        [Theory]
        [InlineData("otto",true),InlineData("otter",false),InlineData("racecar",true)]
        public void PalindromeCheckerService_Should_Pass(string wordToCheck, bool expected)
        {
            var result = _sut.IsPalindrome(wordToCheck);
            result.Should().Be(expected);
        }
        [Theory,InlineData("ott1o",true)]
        public void PalindromeCheckerService_Should_Not_Pass(string wordToCheck, bool expected)
        {
            var result = _sut.IsPalindrome(wordToCheck);
            result.Should().NotBe(expected);
        }
    }
}
