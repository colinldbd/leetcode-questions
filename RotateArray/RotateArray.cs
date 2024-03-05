namespace RotateArray
{
    internal class RotateArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rotate([1, 2, 3, 4, 5, 6, 7], 3);
        }

        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            //if (k < 0) k += nums.Length;

            Reverse(nums, 0, nums.Length - k - 1);
            Reverse(nums, nums.Length - k, nums.Length - 1);
            Reverse(nums, 0, nums.Length - 1);
        }

        public static void Reverse(int[] nums, int i, int j)
        {
            int li = i;
            int ri = j;

            while (li < ri)
            {
                int temp = nums[li];
                nums[li] = nums[ri];
                nums[ri] = temp;

                li++;
                ri--;
            }
        }
    }
}
