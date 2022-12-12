namespace AdventOfCode22.Day2;

public class Day2
{
    public static async Task<int> Run()
    {
        var text = await File.ReadAllLinesAsync("Day2/input.txt");
        var matchScore = 0;
        foreach (var line in text)
        {
            var opponent = ISymbol.Parse(line[0]);
            var mine = ISymbol.Parse(line[2]);

            matchScore += ISymbol.RoundResult(mine, opponent);
        }

        return matchScore;
    }

    public enum Symbol
    {
        Rock,
        Paper,
        Scissors
    }

    public abstract class ISymbol
    {
        public virtual Symbol Symbol { get; }

        public static int RoundResult(ISymbol mine, ISymbol opponent)
        {
            var result = 0;
            switch (mine.Symbol)
            {
                case Symbol.Rock:
                    result += 1;
                    return opponent.Symbol switch
                    {
                        Symbol.Rock => result += 3,
                        Symbol.Paper => result,
                        Symbol.Scissors => result += 6,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                case Symbol.Paper:
                    result += 2;
                    return opponent.Symbol switch
                    {
                        Symbol.Rock => result += 6,
                        Symbol.Paper => result += 3,
                        Symbol.Scissors => result,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                case Symbol.Scissors:
                    result += 3;
                    return opponent.Symbol switch
                    {
                        Symbol.Rock => result,
                        Symbol.Paper => result += 6,
                        Symbol.Scissors => result += 3,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static ISymbol Parse(char letter)
        {
            return letter switch
            {
                'A' or 'X' => new Rock(),
                'B' or 'Y' => new Paper(),
                'C' or 'Z' => new Scissors(),
                _ => throw new Exception("Cannot parse input")
            };
        }
    }

    public class Rock : ISymbol
    {
        public override Symbol Symbol => Symbol.Rock;
    }

    public class Paper : ISymbol
    {
        public override Symbol Symbol => Symbol.Paper;
    }

    public class Scissors : ISymbol
    {
        public override Symbol Symbol => Symbol.Scissors;
    }
}