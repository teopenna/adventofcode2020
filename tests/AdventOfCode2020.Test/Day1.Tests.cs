using AdventOfCode2020.Day1;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode2020.Test
{
    public class Day1Tests
    {
        private IList<long> _inputValues = new List<long>
        {
            1632,
            1438,
            1811,
            300,
            1943,
            1883,
            1698,
            582,
            1976,
            22,
            1972,
            1794
        };

        [Fact]
        public void SolveFirst()
        {
            var valuesLoader = new Mock<IInputValuesLoader>();
            valuesLoader.Setup(l => l.LoadInputValues()).Returns(_inputValues);

            var sut = new Day1.Day1(valuesLoader.Object);

            var expectedFirstResult = 836916;
            var expectedSecondResult = 11206800;

            Assert.Equal(expectedFirstResult, sut.SolveFirst());
            Assert.Equal(expectedSecondResult, sut.SolveSecond());
        }
    }
}
