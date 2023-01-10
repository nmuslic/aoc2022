using System.Collections;
using System.Text;

namespace Aoc2022
{
    public static class D05SupplyStacks
    {
        public static string GetTopCrates9000(string input)
        {
            string[] inputParts = input.Split("\n\n");

            List<string> startingStacks = inputParts[0].Split('\n').ToList();

            List<Stack> stacks = new();

            var lastLine = startingStacks[^1];
            var stacksCount = startingStacks[^1].ElementAt(lastLine.Length - 2) - '0';

            for (int i = 0; i < stacksCount; i++)
            {
                stacks.Add(new Stack());
            }

            for (int i = startingStacks.Count - 2; i >= 0; i--)
            {
                var currentLine = startingStacks[i].ToString();

                for (int j = 0; j < currentLine.Length; j += 3)
                {
                    if (currentLine[j] == '[')
                    {
                        stacks[j / 4].Push(currentLine[j + 1]);
                    }

                    j++;
                }
            }

            List<string> moves = inputParts[1].Split('\n').ToList();

            foreach (var move in moves)
            {
                int movesCount = Convert.ToInt32(move.Split("move ")[1].Split(" from ")[0]);
                int stackFrom = Convert.ToInt32(move.Split("move ")[1].Split(" from ")[1].Split(" to ")[0]);
                int stackTo = Convert.ToInt32(move.Split("move ")[1].Split(" from ")[1].Split(" to ")[1]);

                while (movesCount > 0)
                {
                    var value = stacks[stackFrom - 1].Pop();
                    stacks[stackTo - 1].Push(value);
                    movesCount--;
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (var stack in stacks)
            {
                result.Append(stack.Peek());
            }

            return result.Replace("[", "").Replace("]", "").ToString();

        }


        public static string GetTopCrates9001(string input)
        {
            string[] inputParts = input.Split("\n\n");

            List<string> startingStacks = inputParts[0].Split('\n').ToList();

            List<Stack> stacks = new List<Stack>();

            var lastLine = startingStacks[startingStacks.Count - 1];
            var stacksCount = lastLine.ElementAt(lastLine.Length - 2) - '0';

            for (int i = 0; i < stacksCount; i++)
            {
                stacks.Add(new Stack());
            }

            for (int i = startingStacks.Count - 2; i >= 0; i--)
            {
                var currentLine = startingStacks[i].ToString();

                for (int j = 0; j < currentLine.Length; j += 3)
                {
                    if (currentLine[j] == '[')
                    {
                        stacks[j / 4].Push(currentLine[j + 1]);
                    }

                    j++;
                }
            }

            List<string> moves = inputParts[1].Split('\n').ToList();

            foreach (var move in moves)
            {
                int movesCount = Convert.ToInt32(move.Split("move ")[1].Split(" from ")[0]);
                int stackFrom = Convert.ToInt32(move.Split("move ")[1].Split(" from ")[1].Split(" to ")[0]);
                int stackTo = Convert.ToInt32(move.Split("move ")[1].Split(" from ")[1].Split(" to ")[1]);

                Stack tempStack = new Stack();

                int movesCountTemp = movesCount;

                while (movesCountTemp > 0)
                {
                    var value = stacks[stackFrom - 1].Pop();
                    tempStack.Push(value);
                    movesCountTemp--;
                }

                while (movesCount > 0)
                {
                    var value = tempStack.Pop();
                    stacks[stackTo - 1].Push(value);
                    movesCount--;
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (var stack in stacks)
            {
                result.Append(stack.Peek());
            }

            return result.Replace("[", "").Replace("]", "").ToString();
        }
    }
}
