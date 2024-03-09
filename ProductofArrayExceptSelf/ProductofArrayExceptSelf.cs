namespace ProductofArrayExceptSelf
{
    internal class ProductofArrayExceptSelf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        //Use DP? Divide it into left product and right product
        // Trade space for time.
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] leftProduct = new int[nums.Length];
            int[] rightProduct = new int[nums.Length];
            int[] result = new int[nums.Length];

            leftProduct[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                leftProduct[i] = nums[i - 1] * leftProduct[i - 1];
            }

            rightProduct[nums.Length - 1] = 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = leftProduct[i] * rightProduct[i];
            }

            return result;
        }

        // Optimised solution, save 1 loop and some space.
        public int[] ProductExceptSelf2(int[] nums)
        {
            int[] result = new int[nums.Length];

            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i - 1] * result[i - 1];
            }

            int right = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }

            return result;
        }
    }
}
