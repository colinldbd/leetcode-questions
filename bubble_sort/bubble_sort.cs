namespace bubble_sort
{
    internal class bubble_sort
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 5, 1, 7, 2, 6 };

            BubbleSort(nums);
        }

        // Move the heaviest rock to the bottom, you need a total of n -1 rounds.
        // Each round, you compared the neighbouring element, and move the larger one to the right. In the end, the largest one
        // will be at the most right place. Or if you look it as bobbles, vise-versa, the lighest bobble will be at the left.
        public static void BubbleSort(int[] nums)
        {
            for(int i =0; i < nums.Length - 1; i++)
            {
                for(int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            return;
        }
    }
}
