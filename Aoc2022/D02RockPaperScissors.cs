namespace Aoc2022
{
    public static class D02RockPaperScissors
    {
        public static int GetMostWins(string input)
        {
            List<string> scores = input.Split('\n')[..^1].ToList();
            List<string> items = input.Replace(' ', '\n').Split('\n')[..^1].ToList();

            return items.Count(x => x == "X") +
                         (items.Count(x => x == "Y") * 2) +
                         (items.Count(x => x == "Z") * 3) +

                         (scores.Count(x => x == "A X") * 3) +
                         (scores.Count(x => x == "B Y") * 3) +
                         (scores.Count(x => x == "C Z") * 3) +

                         (scores.Count(x => x == "A Y") * 6) +
                         (scores.Count(x => x == "B Z") * 6) +
                         (scores.Count(x => x == "C X") * 6);
        }

        public static int GetMostStrategyWins(string input)
        {
            string strategyScores = input.Replace("A X", "A *Z")
                                         .Replace("A Y", "A *X")
                                         .Replace("A Z", "A Y")

                                         .Replace("A *X", "A X")
                                         .Replace("A *Z", "A Z")

                                         .Replace("C X", "C *Y")
                                         .Replace("C Y", "C *Z")
                                         .Replace("C Z", "C X")

                                         .Replace("C *Y", "C Y")
                                         .Replace("C *Z", "C Z");

            return GetMostWins(strategyScores);
        }     
    }
}