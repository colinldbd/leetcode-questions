namespace JumpGameII
{
    internal class JumpGameII
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = Jump([2, 3, 1, 1, 4]);

            return;
        }

        // Greed Algorithm, always find the optimal solution for now.
        public static int Jump(int[] nums)
        {
            if (nums.Length == 1) { return 0; }

            int count = 0;
            int index = 0;

            while (index < nums.Length)
            {
                int jump = nums[index] + index;
                if (jump < nums.Length - 1)
                {
                    count++;
                }
                else
                {
                    break;
                }

                int step = nums[index];
                int max = 0;
                int nextPos = 0;
                while (step > 0 && step + index < nums.Length)
                {
                    if (max < index + step + nums[step + index])
                    {
                        max = index + step + nums[step + index];
                        nextPos = index + step;
                    }
                    step--;
                }
                index = nextPos;
            }

            return count + 1;
        }
    }
}
