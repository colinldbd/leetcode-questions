namespace merge_sorted_array
{
    internal class merge_sorted_array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums1 = [0];
            int[] nums2 = [1];

            Merge(nums1, 0, nums2, 1);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> list = new();

            nums1 = IgnoreZero(nums1);
            nums2 = IgnoreZero(nums2);

            for (int i = 0, j = 0; i < m || j < n;)
            {
                if (i == m)
                {
                    list.Add(nums2[j]);
                    j++;
                    continue;
                }
                else if (j == n)
                {
                    list.Add(nums1[i]);
                    i++;
                    continue;
                }


                if (nums1[i] <= nums2[j])
                {
                    list.Add(nums1[i]);
                    i++;
                }
                else
                {
                    list.Add(nums2[j]);
                    j++;
                }
            }

            nums1 = list.ToArray();

            return;
        }

        public static int[] IgnoreZero(int[] nums)
        {
            List<int> list = [];

            foreach (int n in nums)
            {
                if (n != 0)
                {
                    list.Add(n);
                }
            }

            nums = list.ToArray();

            return nums;
        }
    }
}
