namespace MathChallenge
{
    internal class MathChallenge
    {
        static void Main(string[] args)
        {

            int result = MChallenge(11121);
            string finalOutput = result.ToString() + "kybewzh40fc";

            for (int i = 3; i < finalOutput.Length; i += 4)
            {
                finalOutput = finalOutput.Substring(0, i) + "_" + finalOutput.Substring(i + 1);
            }

            Console.WriteLine(finalOutput);
            return;
        }

        public static int MChallenge(int num)
        {
            // code goes here  
            char[] nums = num.ToString().ToCharArray();
            int l = nums.Length;
            int i = l - 2;

            while (i >= 0 && nums[i] >= nums[i + 1]) i--;

            if (i == -1) return -1;

            int j = l - 1;

            while (nums[j] <= nums[i]) j--;
            Swap(nums, i, j);

            Array.Reverse(nums, i + 1, l - (i + 1));
            num = int.Parse(new string(nums));


            return num;
        }

        private static void Swap(char[] nums, int i, int j)
        {
            char temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }
    }
}
