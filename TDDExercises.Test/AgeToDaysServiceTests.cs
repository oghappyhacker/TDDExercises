using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class AgeToDaysServiceTests
    {
        private readonly AgeToDaysService _sut;
        public AgeToDaysServiceTests()
        {
            _sut = new AgeToDaysService();
        }

        [Theory]
        [InlineData(1.0,365.25)]
        public void AgeToDays_Should_Pass(double age,double expected)
        {
            var result = _sut.AgeToDays(age);

            result.Should().Be(expected);
        }
    }
}