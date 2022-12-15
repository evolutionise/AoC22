namespace AdventOfCode22.Day3;

public class Day3
{
    public static int Run(string[] d3Input)
    {
        var prioritySum = 0;
        foreach (var line in d3Input)
        {
            var length = line.Length / 2;
            var c1 = line[..length].ToCharArray();
            var c2 = line[length..].ToCharArray();

            var badItems = new Dictionary<char, int>();

            foreach (var item in c1)
            {
                if (c2.Contains(item))
                {
                    if (badItems.TryAdd(item, GetPriorityNum(item)))
                    {
                        prioritySum += GetPriorityNum(item);
                    }
                }
            }
        }

        return prioritySum;
    }

    private static int GetPriorityNum(char x)
    {
        return char.IsUpper(x) 
            ? x - 65 + 27 
            : x - 97 + 1;
    }
}