namespace ReverseBits
{
    internal class ReverseBits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public uint reverseBits(uint n)
        {
            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                if ((n & 1) == 1) result++;
                n >>= 1;
            }

            return result;
        }
        /*          1234|5678
         *          5678|1234
         *          56|78|12|34
         *          78|56|34|12
         *          7|8|5|6|3|4|1|2
         *          8|7|6|5|4|3|2|1
         */
        public uint reverseBits2(uint n)
        {
            n = ((n & 0xffff0000) >> 16) | ((n & 0x0000ffff) << 16);
            n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
            n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
            n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
            n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);

            return n;
        }
    }
}
