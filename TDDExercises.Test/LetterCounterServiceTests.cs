using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class LetterCounterServiceTests
    {
        private readonly LetterCounterService _sut;
        public LetterCounterServiceTests()
        {
            _sut = new LetterCounterService();
        }
        [Theory]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 'L', 1)]
        public void GetLetterCount_Should_Pass(string sentence, char character, int expected)
        {
            var result = _sut.GetLetterCount(sentence, character);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 'L', 2)]
        public void GetLetterCount_Should_Not_Pass(string sentence, char letter, int expected)
        {
            var result = _sut.GetLetterCount(sentence, letter);
            result.Should().NotBe(expected);
        }
        [Theory]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 'L', 1)]
        public void GetLetterCountAlt_Should_Pass(string sentence, char character, int expected)
        {
            var result = _sut.GetLetterCountAlt(sentence, character);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData("Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 'L', 2)]
        public void GetLetterCountAlt_Should_Not_Pass(string sentence, char letter, int expected)
        {
            var result = _sut.GetLetterCountAlt(sentence, letter);
            result.Should().NotBe(expected);
        }
    }
}
