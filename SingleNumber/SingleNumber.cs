namespace SingleNumber
{
    internal class SingleNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int GetSingleNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i + 1] ^= nums[i];
            }

            return nums[^1];
        }
    }
}
