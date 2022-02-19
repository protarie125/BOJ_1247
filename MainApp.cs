using System;
using System.Numerics;

namespace BOJ_1247
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var nstr = Console.ReadLine();
                var n = int.Parse(nstr);

                var sum = default(BigInteger);
                for (int j = 0; j < n; j++)
                {
                    var line = Console.ReadLine();
                    var val = BigInteger.Parse(line);
                    sum += val;
                }

                if (sum < 0)
                {
                    Console.WriteLine('-');
                }
                else if (0 < sum)
                {
                    Console.WriteLine('+');
                }
                else
                {
                    Console.WriteLine('0');
                }
            }
        }
    }
}