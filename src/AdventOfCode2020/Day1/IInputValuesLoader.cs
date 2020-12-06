using System.Collections.Generic;

namespace AdventOfCode2020.Day1
{
    public interface IInputValuesLoader
    {
        IList<long> LoadInputValues();
    }
}
