namespace Numberof1Bits
{
    internal class Numberf1Bits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1) count++;
                n >>= 1;
            }

            return count;
            //var str = Convert.ToString(n, 2);
            //var result = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == '1') { result += 1; }
            //}
            //return result;
        }
    }
}
