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
    public class TipCalculatorServiceTests
    {
        private readonly TipCalculatorService _sut;
        public TipCalculatorServiceTests()
        {
            _sut = new TipCalculatorService();
        }
        [Theory]
        [InlineData(10.00,0.15,1.50)]
        public void CalculateTip_Should_Pass(double total, double tipPercent, double expected)
        {
            var value = _sut.CalculateTip(total, tipPercent);
            value.Should().Be(expected);
        }
    }
}
