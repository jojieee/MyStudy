using System;

namespace IntegralTypes
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000000;
            uint f = 300000000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -500000000000;
            ulong h = 2000000000000000000;

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}
