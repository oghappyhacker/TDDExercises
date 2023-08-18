using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class AreaCalculatorServiceTest
    {
        private readonly AreaCalculatorService _sut;
        public AreaCalculatorServiceTest()
        {
            _sut = new AreaCalculatorService();
        }
        [Theory]
        [InlineData(10.9, 15.5, 84.47500000000001)]
        public void AreaCalculatorService_Should_Pass(double tBase, double tHeight, double expected)
        {
            var result = _sut.GetAreaOfTriangle(tBase, tHeight);
            result.Should().Be(expected);
        }
    }
}
