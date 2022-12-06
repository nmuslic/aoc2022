namespace Aoc2022
{
    public static class D04CampCleanup
    {
        public static int GetOverlapedPairs(string input)
        {
            List<string> scores = input.Split('\n')[..^1].ToList();
            List<AssignmentPairs> pairs = scores.Select(x => x.Split(',')).Select(x => new AssignmentPairs
            {
                ALeft = Convert.ToInt32(x[0].Split('-')[0]),
                ARight = Convert.ToInt32(x[0].Split('-')[1]),
                BLeft = Convert.ToInt32(x[1].Split('-')[0]),
                BRight = Convert.ToInt32(x[1].Split('-')[1])
            }).ToList();

            return pairs.Where(p => (p.ALeft <= p.BLeft && p.ARight >= p.BRight) ||
                                                 p.BLeft <= p.ALeft && p.BRight >= p.ARight).Count();
        }

        public static int GetAllOverlapedSections(string input)
        {
            List<string> scores = input.Split('\n')[..^1].ToList();
            List<AssignmentPairs> pairs = scores.Select(x => x.Split(',')).Select(x => new AssignmentPairs
            {
                ALeft = Convert.ToInt32(x[0].Split('-')[0]),
                ARight = Convert.ToInt32(x[0].Split('-')[1]),
                BLeft = Convert.ToInt32(x[1].Split('-')[0]),
                BRight = Convert.ToInt32(x[1].Split('-')[1])
            }).ToList();

            return pairs.Where(p =>
                                     Enumerable.Range(p.ALeft, p.ARight - p.ALeft + 1).Contains(p.BRight) ||
                                     Enumerable.Range(p.ALeft, p.ARight - p.ALeft + 1).Contains(p.BLeft) ||
                                     Enumerable.Range(p.BLeft, p.BRight - p.BLeft + 1).Contains(p.ALeft) ||
                                     Enumerable.Range(p.BLeft, p.BRight - p.BLeft + 1).Contains(p.ARight))
                                .Count();
        }

        public class AssignmentPairs
        {
            public int ALeft { get; set; }
            public int ARight { get; set; }
            public int BLeft { get; set; }
            public int BRight { get; set; }
        }
    }
}
