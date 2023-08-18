using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;
using Xunit;
using FluentAssertions;

namespace TDDExercises.Test
{
    public class WordReverserServiceTests
    {
        private readonly WordReverserService _sut;
        public WordReverserServiceTests()
        {
            _sut = new WordReverserService();
        }
        [Theory]
        [InlineData("John","nhoJ")]
        public void ReverseWord_Should_Pass(string word,string expected)
        {
            var result = _sut.ReverseWord(word);
            result.Should().Be(expected);
        }
    }
}
