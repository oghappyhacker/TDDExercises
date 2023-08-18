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
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _sut;

        public CalculatorServiceTests()
        {
            _sut = new CalculatorService();
        }

        [Theory]
        [InlineData(10,5,15)]
        public void Add_Should_Pass(int a,int b, int expected)
        {
            var result = _sut.Add(a,b);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(10,5,5)]
        public void Subtract_Should_Pass(int a, int b, int expected)
        {
            var result = _sut.Subtract(a,b);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(10,5,50)]
        public void Multiply_Should_Pass(int a, int b,int expected)
        {
            var result = _sut.Multiply(a,b);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(20,5,4)]
        public void Divide_Should_Pass(int a, int b, int expected)
        {
            var result = _sut.Divide(a,b);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(21,5,1)]
        public void Remainder_Should_Pass(int a, int b, int expected)
        {
            var result = _sut.Remainder(a,b);
            result.Should().Be(expected);
        }
    }
}
