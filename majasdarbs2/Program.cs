using System;

namespace majasdarbs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("ierakstit skaitli:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
            Console.ReadLine();
        }

    }
}