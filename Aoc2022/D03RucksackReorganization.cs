namespace Aoc2022
{
    public static class D03RucksackReorganization
    {
        public static int GetSumOfPairs(string input)
        {
            int result = 0;
            List<string> scores = input.Split('\n')[..^1].ToList();

            foreach (string score in scores)
            {
                HashSet<char> items = new();

                for (int i = 0; i < score.Length / 2; i++)
                {
                    if (!items.Contains(score[i]))
                    {
                        items.Add(score[i]);
                    }
                }

                for (int i = score.Length / 2; i < score.Length; i++)
                {
                    if (items.Contains(score[i]))
                    {
                        result += char.IsLower(score[i]) ? score[i] - 'a' + 1 : score[i] - 38;
                        break;
                    }
                }
            }

            return result;
        }

        public static int GetSumOfThrees(string input)
        {
            int result = 0;
            List<string> scores = input.Split('\n')[..^1].ToList();

            int currentGroup = 0;
            HashSet<string> badges = new();
            foreach (string score in scores)
            {
                currentGroup++;
                if (currentGroup == 4)
                {
                    badges = new HashSet<string>();
                    currentGroup = 1;
                }

                for (int i = 0; i < score.Length; i++)
                {
                    if (!badges.Contains($"{score[i]}{currentGroup}"))
                    {
                        badges.Add($"{score[i]}{currentGroup}");

                        if (currentGroup == 3 && badges.Contains($"{score[i]}{currentGroup - 1}") && badges.Contains($"{score[i]}{currentGroup - 2}"))
                        {
                            result += char.IsLower(score[i]) ? score[i] - 'a' + 1 : score[i] - 38;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
