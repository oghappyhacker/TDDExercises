using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class ProfitCalculatorServiceTests
    {
        private readonly ProfitCalculatorService _sut;
        public ProfitCalculatorServiceTests()
        {
            _sut = new ProfitCalculatorService();
        }
        [Theory]
        [InlineData(100.00, 80.0, 0.2)]
        public void GetProfitMargin_Should_Pass(double revenue, double cost, double expected)
        {
            var result = _sut.GetProfitMargin(revenue, cost);
            result.Should().Be(expected);
        }
    }
}
