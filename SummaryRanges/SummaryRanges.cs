namespace SummaryRanges
{
    internal class SummaryRanges
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<string> SummaryRange(int[] nums)
        {
            List < (int START, int END) > list = new List<(int START, int END)>();
            List<string> result = new List<string>();

            if (nums.Length == 0)
            {
                return new List<string>();
            }

            int start = nums[0];
            int end = nums[0];

            if (nums.Length == 1)
            {
                return new List<string>() { "" + nums[0] };
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != end + 1)
                {
                    list.Add((START: start, END: end));
                    start = nums[i];
                }
                end = nums[i];
            }

            // Handle the edge case.
            list.Add((START: start, END: end));

            foreach ((int START, int END) t in list)
            {
                if (t.START == t.END)
                {
                    result.Add($"{t.START}");
                }
                else
                {
                    result.Add($"{t.START}->{t.END}");
                }
            }

            return result;
        }
    }
}
