namespace TwoSum
{
    internal class TwoSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] returnTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] result = new int[2];

            for(int i  = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (dict.ContainsKey(diff))
                {
                    result = [dict[diff], i];
                    break;
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }

            return result;
        }
    }
}
