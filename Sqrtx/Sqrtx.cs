using System.Numerics;

namespace Sqrtx
{
    internal class Sqrtx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int result = MySqrt(2147395600);

            return;
        }

        public static int MySqrt(int x)
        {
            long sqrt = 0;

            for (long i = 0; i * i <= x; i++)
            {
                if (i * i > x)
                {
                    break;
                }
                sqrt = i;
            }

            /*
             * Int32.MaxValue = 2^31 - 1, why ? 1 bit is reserved for the sign.
             */
            Console.WriteLine(Int32.MaxValue);

            return (int)sqrt;
        }
    }
}
