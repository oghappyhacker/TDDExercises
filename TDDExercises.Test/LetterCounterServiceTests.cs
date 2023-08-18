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
        public void GetLetterCount_Should_Pass(string sentence,char character, int expected)
        {
            var result = _sut.GetLetterCount(sentence, character);
            result.Should().Be(expected);
        }
    }
}
