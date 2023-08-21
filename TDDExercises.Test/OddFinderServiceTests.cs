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
    public class OddFinderServiceTests
    {
        private readonly OddFinderService _sut;
        public OddFinderServiceTests()
        {
            _sut = new OddFinderService();
        }
        [Theory,InlineData(3, true),InlineData(2, false)]
        public void IsNumberOdd_Should_Pass(int num, bool expected)
        {
            var result = _sut.IsNumberOdd(num);
            result.Should().Be(expected);
        }
        [Theory,InlineData(2, true),InlineData(3,false)]
        public void IsNumberOdd_Should_Not_Pass(int num, bool expected)
        {
            var result = _sut.IsNumberOdd(num);
            result.Should().NotBe(expected);
        }
    }
}
