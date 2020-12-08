using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Day2
{
    public class TextFileInputValuesLoader : IInputValuesLoader
    {
        public IList<PasswordMatcher> LoadInputValues()
        {
            var fileItems = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Day2", "input2.txt"));
            var inputValues = new List<PasswordMatcher>();

            return fileItems.Where(item =>
            {
                var itemEntries = item.Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                return itemEntries.Length == 4;
            })
            .Select(item => 
            {
                var itemEntries = item.Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                return PasswordMatcher.CreatePasswordMatcher(int.Parse(itemEntries[0]), int.Parse(itemEntries[1]), Convert.ToChar(itemEntries[2]), itemEntries[3]);
            })
            .ToList();
        }
    }
}
