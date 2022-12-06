namespace Aoc2022
{
    public static class Day01CalorieCounting
    {
        public static int GetTopCaloriesElf(string calories)
        {
            List<int> caloriesList = calories.Split("\n\n")[..^1].Select(x => x.Split('\n').Sum(x => Convert.ToInt32(x))).ToList();

            return caloriesList.Max();
        }

        public static int GetTop3CaloriesElf(string calories)
        {
            List<int> caloriesList = calories.Split("\n\n")[..^1].Select(x => x.Split('\n').Sum(x => Convert.ToInt32(x))).ToList();

            return caloriesList.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}