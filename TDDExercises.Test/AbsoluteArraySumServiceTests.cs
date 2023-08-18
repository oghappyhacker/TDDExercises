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
    public class AbsoluteArraySumServiceTests
    {
        private readonly AbsoluteArraySumService _sut;
        public AbsoluteArraySumServiceTests()
        {
            _sut = new AbsoluteArraySumService();
        }
        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[]
            {
                1,2,1,4
            },
            new object[]
            {
                -1, -2, 3, 6
            }
        };
        [Theory]
        [MemberData(nameof(Data))]
        public void AbsoluteSummation_Should_Pass(int num1, int num2,int num3,int expected)
        {
            var inputArray = new[] {num1,num2,num3};
            var result = _sut.AbsoluteSummation(inputArray);
            result.Should().Be(expected);
        }
    }
}
