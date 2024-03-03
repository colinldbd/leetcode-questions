namespace SearchInsertPosition
{
    internal class SearchInsertPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int result = SearchInsert([1, 3, 5, 6], 2);

            return;
        }

        public static int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        public static int BinarySearch(int[] nums, int l, int r, int target)
        {
            // Why just return l? Because if target can't be found, there're two types of situations
            // 1. r is subtracted to less than l, in this case, we need to insert it to the left side of l
            // thus l
            // 2. l is added to more than r, in this case, we need to insert it to the right side of r.
            // but because l is larger than r(by 1), so l = r + 1,
            // thus also l.
            if (l > r)
            {
                return l;
            }

            int mid = (l + r) / 2;

            //Left closed right open interval to better represent the index, because we're using l+1
            if (target < nums[mid])
            {
                r = mid - 1;
            }
            else if (target > nums[mid])
            {
                l = mid + 1;
            }
            else { return mid; }

            return BinarySearch(nums, l, r, target);
        }

        int BinarySearch2(int[] nums, int target)
        {
            // 初始化双闭区间 [0, n-1] ，即 i, j 分别指向数组首元素、尾元素
            int i = 0, j = nums.Length - 1;
            // 循环，当搜索区间为空时跳出（当 i > j 时为空）
            while (i <= j) //注意这里是i<=j 相当于 if i > j ,break
            {
                int m = i + (j - i) / 2;   // 计算中点索引 m
                if (nums[m] < target)      // 此情况说明 target 在区间 [m+1, j] 中
                    i = m + 1;
                else if (nums[m] > target) // 此情况说明 target 在区间 [i, m-1] 中
                    j = m - 1;
                else                       // 找到目标元素，返回其索引
                    return m;
            }
            // 未找到目标元素，返回 -1
            return i;
        }
    }
}
