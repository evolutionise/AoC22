using AdventOfCode22.Day1;
using AdventOfCode22.Day2;
using AdventOfCode22.Day3;
using AdventOfCode22.Day4;


if (args.Any() && (int.TryParse(args[0], out var day)))
{
    switch (day)
    {
        case 1:
            var day1Solution = await Day1.Run();
            Console.WriteLine("Day 1 Solution: " + day1Solution);
            break;
        case 2:
            var day2Solution = await Day2.Run();
            Console.WriteLine("Day 2 Solution: " + day2Solution);
            break;
    }
}

var d3Input = await File.ReadAllLinesAsync("Day3/input.txt");
var day3Solution =  Day3.Run(d3Input);
Console.WriteLine("Day 3 Solution: " + day3Solution);

var d4Input = await File.ReadAllLinesAsync("Day4/input.txt");
var day4Solution =  Day4.Run(d4Input);
Console.WriteLine("Day 4 Solution: " + day4Solution);



// static void RunAndPrint(Action action)
// {
//     var solution = action.Invoke();
// }