using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Day1
{
    public class TextFileInputValuesLoader : IInputValuesLoader
    {
        public IList<long> LoadInputValues()
        {
            var fileItems = File.ReadAllLines("input.txt");
            var inputValues = fileItems.Select(long.Parse).ToList();
            return inputValues;
        }
    }
}
