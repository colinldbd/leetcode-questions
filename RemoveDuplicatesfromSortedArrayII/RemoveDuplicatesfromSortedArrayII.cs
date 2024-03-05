namespace RemoveDuplicatesfromSortedArrayII
{
    internal class RemoveDuplicatesfromSortedArrayII
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            RemoveDuplicates([0, 0, 1, 1, 1, 1, 2, 3, 3]);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int k = 0;
            int count = 0;
            // Remember to deal with edge case,
            k++;
            count++;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1] && count < 2)
                {
                    nums[k++] = nums[i];
                    count++;
                }
                else if (nums[i] != nums[i - 1])
                {
                    nums[k++] = nums[i];
                    count = 1; // Count is always 1 initially.
                }                
            }

            //int j = 1;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (j == 1 || nums[i] != nums[j - 2])
            //    {
            //        nums[j++] = nums[i];
            //    }
            //}
            //return j;

            return k;
        }
    }
}
