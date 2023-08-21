using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class LogicalOperationsServiceTests
    {
        private readonly LogicalOperationsService _sut;
        public LogicalOperationsServiceTests()
        {
            _sut = new LogicalOperationsService();
        }
        [Theory,InlineData(1, 1, true)]
        [InlineData(1, 0, false)]
        public void And_Should_Pass(int numberOne, int numberTwo, bool expected)
        {
            var result = _sut.And(numberOne, numberTwo);
            result.Should().Be(expected);
        }
        [Theory,InlineData(0, 1, true)]
        public void And_Should_Not_Pass(int numberOne, int numberTwo, bool expected)
        {
            var result = _sut.And(numberOne,numberTwo);
            result.Should().NotBe(expected);
        }
        [Theory]
        [InlineData(0, 1, true)]
        public void Not_Should_Pass(int numberOne,int numberTwo, bool expected) 
        {
            var result = _sut.Not(numberOne, numberTwo);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(0, 1, false)]
        public void Not_Should_Not_Pass(int numberOne, int numberTwo, bool expected)
        {
            var result = _sut.Not(numberOne, numberTwo);
            result.Should().NotBe(expected);
        }
        [Theory]
        [InlineData(1, 0, true)]
        public void Or_Should_Pass(int numberOne, int numberTwo, bool expected)
        {
            var result = _sut.Or(numberOne, numberTwo);
            result.Should().Be(expected);
        }
        [Theory,InlineData(0,0,true)]
        public void Or_Should_Not_Pass(int numberOne,int numberTwo,bool expected)
        {
            var result = _sut.Or(numberOne,numberTwo); result.Should().NotBe(expected);
        }
    }
}
