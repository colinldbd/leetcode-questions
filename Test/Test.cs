using System.Diagnostics.Metrics;

namespace Test
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Merge([1, 2, 3, 0, 0, 0], 3, [ 2, 5, 6], 3);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = m;
            foreach(int num in nums2)
            {
                nums1[index++] = num;
            }
            Console.WriteLine(nums1.ToString());
        }
    }
}
