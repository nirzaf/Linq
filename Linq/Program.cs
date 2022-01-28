using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));
        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }
    }
}
