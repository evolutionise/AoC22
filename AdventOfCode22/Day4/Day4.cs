namespace AdventOfCode22.Day4;

public class Day4
{
    public static int Run(string[] input)
    {
        var count = 0;
        var meow = input.Length;
        var countOfGreater = 0;
        foreach (var line in input)
        {
            var thing = ParseLine(line);
            
            if (thing.Item1.Item1 >= thing.Item1.Item2 && thing.Item2.Item1 >= thing.Item2.Item2)
            {
                countOfGreater += 1;
            }
            var (p1, p2) = ParseLine(line);

            if (GetRange(p1.Item1, p1.Item2).Contains(p2.Item1) && GetRange(p1.Item1, p1.Item2).Contains(p2.Item2))
            {
                count += 1;
            }
            else if (GetRange(p2.Item1, p2.Item2).Contains(p1.Item1) && GetRange(p2.Item1, p2.Item2).Contains(p1.Item2))
            {
                count += 1;
            }
        }

        return count;
    }

    private static IEnumerable<int> GetRange(int one, int two)
    {
        return Enumerable.Range(one, (two - one + 1));
    }

    private static ((int, int), (int, int)) ParseLine(string line)
    {
        var pairs = line.Split(',');
        var p1 = ParseAssignment(pairs[0]);
        var p2 = ParseAssignment(pairs[1]);
        
        return (p1, p2);
    }

    private static (int, int) ParseAssignment(string line)
    {
        var assignment = line.Split('-');
        return (int.Parse(assignment[0]), int.Parse(assignment[1]));
    }



    // private static (Range p1, Range p2) ParseLine(string line)
    // {
    //     var pairs = line.Split(',');
    //     var p1 = ParseAssignment(pairs[0]);
    //     var p2 = ParseAssignment(pairs[1]);
    //
    //     return (p1, p2);
    // }
    //
    // private static Range ParseAssignment(string val)
    // {
    //     var assignment = val.Split('-');
    //     return new Range(int.Parse(assignment[0]), int.Parse(assignment[1]));
    // }
}