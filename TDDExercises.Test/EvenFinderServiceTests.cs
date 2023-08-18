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
    public class EvenFinderServiceTests
    {
        private readonly EvenFinderService _sut;

        public EvenFinderServiceTests()
        {
            _sut = new EvenFinderService();
        }
        [Theory]
        [InlineData(2, true)]
        public void IsNumberEven_Should_Pass(int number, bool expected)
        {
            var result = _sut.IsNumberEven(number);
            result.Should().Be(expected);
        }

    }
}
