﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using TDDExercises.ClassLibrary;

namespace TDDExercises.Test
{
    public class LetterMultiplierServiceTests
    {
        private readonly LetterMultiplierService _sut;
        public LetterMultiplierServiceTests()
        {
            _sut = new LetterMultiplierService();
        }
        [Theory]
        [InlineData('J', 5, "JJJJJ")]
        public void LetterMultiple_Should_Pass(char letter, int value, string expected)
        {
            var result = _sut.LetterMultiple(letter, value);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData('J', 5, "JJJJ")]
        public void LetterMultiple_Should_Not_Pass(char letter, int value, string expected)
        {
            var result = _sut.LetterMultiple(letter, value);
            result.Should().NotBe(expected);
        }
        [Theory]
        [InlineData('J', 5, "JJJJJ")]
        public void LetterMultipleAlt_Should_Pass(char letter, int value, string expected)
        {
            var result = _sut.LetterMultipleAlt(letter, value);
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData('J', 5, "JJJJ")]
        public void LetterMultipleAlt_Should_Not_Pass(char letter, int value, string expected)
        {
            var result = _sut.LetterMultipleAlt(letter, value);
            result.Should().NotBe(expected);
        }
    }
}
