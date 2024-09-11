namespace MInimum_Bit_Flips_To_Convert_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static int MinBitFlips(int start, int goal)
        {
            int count = 0;
            int xor = start ^ goal;

            // Implementation 1
            //while (xor != 0)
            //{
            //    xor = xor & (xor - 1);
            //    count++;
            //}

            // Implementation 2
            //count = Convert.ToString(xor, 2).Count(c => c == '1');

            // Implementation 3
            while (xor != 0)
            {
                if ((xor & 1) == 1) count++;
                xor >>= 1;
            }

            return count;
        }
    }
}
