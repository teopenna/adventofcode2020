using System.Collections.Generic;
using System.Linq;
using MoreLinq.Extensions;

namespace AdventOfCode2020.Day1
{
    public class Day1
    {
        private readonly IList<long> _inputValues;

        public Day1(IInputValuesLoader inputValuesLoader)
        {
            _inputValues = inputValuesLoader.LoadInputValues();
        }

        public long SolveFirst()
        {
            var firstResult = _inputValues.Subsets(2).First(n => n.Sum() == 2020).Aggregate((x, y) => x * y);
            return firstResult;
        }

        public long SolveSecond()
        {
            var secondResult = _inputValues.Subsets(3).First(n => n.Sum() == 2020).Aggregate((x, y) => x * y);
            return secondResult;
        }
    }
}
