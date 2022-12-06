using System.Text;

namespace Aoc2022
{
    public static class D06TuningTrouble
    {
        public static int GetStartOfPacketMarker(string input, int packetLength)
        {
            for (int i = 0; i < input.Length; i++)
            {
                HashSet<char> hs = new();

                for (int j = i; j < i + packetLength; j++)
                {
                    if (!hs.Contains(input[j]))
                    {
                        hs.Add(input[j]);
                    }
                    else
                    {
                        break;
                    }

                    if (j == i + packetLength - 1)
                    {
                        return j + 1;
                    }
                }
            }
            return 0;
        }
    }
}
