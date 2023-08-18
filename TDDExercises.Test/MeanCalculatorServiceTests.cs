using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using TDDExercises.ClassLibrary;
using Xunit;

namespace TDDExercises.Test
{
    public class MeanCalculatorServiceTests
    {
        private readonly MeanCalculatorService _sut;
        public MeanCalculatorServiceTests()
        {
            _sut = new MeanCalculatorService();
        }
        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[]
            {
                1.00, 2.00, 1.00, 1.3333333333333333
            },
            new object[]
            {
                1.00,2.00,3.00, 2.0
            }
        };
        [Theory]
        [MemberData(nameof(Data))]
        public void GetMeanFromIEnumerable_Should_Pass(double num1, double num2, double num3, double expected)
        {
            var result = _sut.GetMeanFromIEnumerable(new[] { num1, num2, num3 });
            result.Should().Be(expected);
        }
    }
}