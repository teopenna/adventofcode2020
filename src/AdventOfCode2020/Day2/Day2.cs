using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day2
{
    public class Day2
    {
        private readonly IList<PasswordMatcher> _inputValues;

        public Day2(IInputValuesLoader inputValuesLoader)
        {
            _inputValues = inputValuesLoader.LoadInputValues();
        }

        public long SolveFirst()
        {
            var firstResult = _inputValues.Count(i => i.IsMatchFirst());
            return firstResult;
        }

        public long SolveSecond()
        {
            var secondResult = _inputValues.Count(i => i.IsMatchSecond());
            return secondResult;
        }
    }
}
