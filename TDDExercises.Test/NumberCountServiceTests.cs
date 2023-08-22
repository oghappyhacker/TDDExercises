using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class NumberCountServiceTests
    {
        private NumberCountService _ncs;
        public NumberCountServiceTests()
        {
            _ncs = new NumberCountService();
        }
        [Theory, InlineData(100, 100)]
        public void Count_Should_Pass(int numToCount, int expected)
        {
            var result = _ncs.Count(numToCount);
            result.Should().Be(expected);
        }
        [Theory,InlineData(100, 100)]
        public void CountAlt_Should_Pass(int numToCount,int expected)
        {
            var result = _ncs.CountAlt(numToCount);
            result.Should().Be(expected);
        }
    }
}
