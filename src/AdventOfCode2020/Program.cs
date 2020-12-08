using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //var day1 = new Day1.Day1(new Day1.TextFileInputValuesLoader());
            //Console.WriteLine($"Day1 First Result is: {day1.SolveFirst()}");
            //Console.WriteLine($"Day1 Second Result is: {day1.SolveSecond()}");

            var day2 = new Day2.Day2(new Day2.TextFileInputValuesLoader());
            Console.WriteLine($"Day2 First Result is: {day2.SolveFirst()}");
            Console.WriteLine($"Day2 Second Result is: {day2.SolveSecond()}");

            Console.ReadLine();
        }

        
    }
}
