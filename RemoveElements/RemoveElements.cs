namespace RemoveElements
{
    internal class RemoveElements
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 8, 8, 2, 3, 8, 1 };
            RemoveElement(nums, 8);
        }

        //public static int RemoveElement(int[] nums, int val)
        //{
        //    int valCounter = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == val)
        //        {
        //            for (int j = nums.Length - 1; j >= i; j--)
        //            {
        //                if (nums[j] != val)
        //                {
        //                    nums[i] = nums[j];
        //                    nums[j] = val;
        //                    break;
        //                }
        //            }
        //        }
        //    }

        //    foreach(int i in nums)
        //    {
        //        if(i == val)
        //        {
        //            valCounter++;
        //        }
        //    }



        //    return nums.Length - valCounter;
        //}

        //public static int RemoveElement2(int[] nums, int val)
        //{
        //    int count = 0;
        //    int i = 0;

        //    while( i < nums.Length)
        //    {
        //        if (nums[i]!= val)
        //        {
        //            nums[count] = nums[i];
        //            count++;
        //        }
        //        i++;
        //    }

        //    return count;
        //}

        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            int l = nums.Length - 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == val)
                {
                    if (nums[l--] == val)
                    {
                        count++;
                    }

                }

            }


            return count;
        }
    }
}
