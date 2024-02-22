namespace RemoveDuplicatesFromSortedArray
{
    internal class RemoveDuplicatesFromSortedArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            RemoveDuplicates(nums);
        }

        // Use double pointer to solve this.
        public static int RemoveDuplicates(int[] nums)
        {

            //int j = 1;
            //for (int i = 1; i < nums.length; i++)
            //{
            //    if (nums[i] != nums[i - 1])
            //    {
            //        nums[j] = nums[i];
            //        j++;
            //    }
            //}
            //return j;

            if (nums.Length == 0)
            {
                return 0;
            }

            int counter = 0;

            // Edge case
            nums[counter] = nums[0];
            counter++;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[counter - 1] < nums[i])
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }
            return counter;
        }
    }
}
