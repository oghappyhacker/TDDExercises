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
    public class MinMaxFinderServiceTests
    {
        private readonly MinMaxFinderService _sut;
        public MinMaxFinderServiceTests()
        {
            _sut = new MinMaxFinderService();
        }
        [Theory]
        [MemberData(nameof(Data))]
        public void MinMaxArrayGenerator_Should_Pass(int num1, int num2, int num3, int[] expected)
        {
            var inputArray = new int[] { num1, num2, num3 };
            var result = _sut.MinMaxArrayGenerator(inputArray);
            result.Should().BeEquivalentTo(expected);
        }
        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[]{
                1,2,100,new int[]{1,100}

            },
            new object[]{
                0,2,99,new int[]{0,99}
            }
        };
    }
}
