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
    public class PinValidatorServiceTests
    {
        private readonly PinValidatorService _sut;
        public PinValidatorServiceTests()
        {
            _sut = new PinValidatorService();
        }
        [Theory]
        [InlineData(1000,1000,true)]
        public void ValidatePin_Should_Pass(int pin,int correctPin,bool expected)
        {
            var result = _sut.ValidatePin(pin,correctPin);
            result.Should().Be(expected);
        }
    }
}
