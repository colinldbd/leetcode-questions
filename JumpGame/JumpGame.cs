namespace JumpGame
{
    internal class JumpGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool CanJump(int[] nums)
        {
            int gas = nums[0];

            foreach(int n in nums)
            {
                if (gas == 0) return false;
                if (gas < n) gas = n;
                gas--;
            }
            return true;
        }
    }
}
