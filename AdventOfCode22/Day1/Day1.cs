namespace AdventOfCode22.Day1;

public static class Day1
{
    public static async Task<int> Run()
    {
        var text = await File.ReadAllLinesAsync("Day1/input.txt");
        var highestNum = 0;
        var calories = new List<int>();

        foreach (var line in text)
        {
            if (line == string.Empty)
            {
                var total = calories.Sum();
                if (total > highestNum) highestNum = total;
                calories.Clear();
                continue;
            }
            var num = int.Parse(line);
            calories.Add(num);
        }

        return highestNum;
    }
}