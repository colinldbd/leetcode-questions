namespace ClimbingStairs
{
    internal class Clime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int result = ClimbStairs2(45);

            return;
        }

        // This, however will pass the time limit. Because it will go for O(2^n)
        public static int ClimbStairs(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }

        public static int ClimbStairs2(int n)
        {
            int[] dp = new int[n + 1];

            if (n == 0) return 1;
            if (n == 1) return 1;

            dp[0] = dp[1] = 1;

            for (int i = 3; i < n + 1; i++)
            {
                dp[i] = dp[i - 2] + dp[i - 1];
            }

            return dp[n];
        }
    }
}
