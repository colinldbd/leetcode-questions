using System.Collections;

namespace MajorityElement
{
    internal class MajorityElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MajorityElement([10, 9, 9, 9, 10]);
        }

        public static int MajorityElement(int[] nums)
        {
            //Hashtable ht = new Hashtable();
            //ht.Add(nums[0], 0);
            Dictionary<int, int> counters = [];
            int major = 0;

            foreach (int n in nums)
            {
                if (!counters.ContainsKey(n))
                {
                    counters.Add(n, 0);
                }
            }

            foreach (int n in nums)
            {
                counters[n]++;
            }

            foreach (int n in nums)
            {
                if (counters[n] > nums.Length / 2)
                {
                    major = n;
                    break;
                }
            }

            return major;
        }
    }
}
