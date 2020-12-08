using AdventOfCode2020.Day2;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020.Test
{
    public class Day2Tests
    {
        private IList<PasswordMatcher> _inputValues = new List<PasswordMatcher>
        {
            PasswordMatcher.CreatePasswordMatcher(3, 4, 't', "dttt"),
            PasswordMatcher.CreatePasswordMatcher(5, 7, 'l', "llmlqmblllh"),
            PasswordMatcher.CreatePasswordMatcher(3, 10, 'g', "gggxwxggggkgglklhhgg"),
            PasswordMatcher.CreatePasswordMatcher(5, 7, 'd', "zxhddvxd"),
            PasswordMatcher.CreatePasswordMatcher(5, 12, 's', "sgscssssphxs"),
            PasswordMatcher.CreatePasswordMatcher(3, 4, 'b', "lbbbbntqswsv")
        };

        [Fact]
        public void SolvePuzzle()
        {
            var valuesLoader = new Mock<IInputValuesLoader>();
            valuesLoader.Setup(l => l.LoadInputValues()).Returns(_inputValues);

            var sut = new Day2.Day2(valuesLoader.Object);

            var expectedFirstResult = 4;
            var expectedSecondResult = 1;

            Assert.Equal(expectedFirstResult, sut.SolveFirst());
            Assert.Equal(expectedSecondResult, sut.SolveSecond());
        }
    }
}
