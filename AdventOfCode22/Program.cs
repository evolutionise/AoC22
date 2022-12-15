// See https://aka.ms/new-console-template for more information

using AdventOfCode22.Day1;
using AdventOfCode22.Day2;
using AdventOfCode22.Day3;

var day1Solution = await Day1.Run();

Console.WriteLine("Day 1 Solution: " + day1Solution);

var day2Solution = await Day2.Run();
Console.WriteLine("Day 2 Solution: " + day2Solution);

var d3input = await File.ReadAllLinesAsync("Day3/input.txt");
var day3Solution =  Day3.Run(d3input);
Console.WriteLine("Day 3 Solution: " + day3Solution);
