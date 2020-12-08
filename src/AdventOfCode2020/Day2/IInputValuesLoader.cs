using System.Collections.Generic;

namespace AdventOfCode2020.Day2
{
    public interface IInputValuesLoader
    {
        IList<PasswordMatcher> LoadInputValues();
    }
}
