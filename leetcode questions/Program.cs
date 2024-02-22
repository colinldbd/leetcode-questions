// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public void Merge(int[] nums1, int m, int[] nums2, int n)
{
    List<int> list = [];

    foreach (int i in nums1)
    {
        if (i != 0)
        {
            list.Add(i);
        }
    }

    foreach (int i in nums2)
    {
        if (i != 0)
        {
            list.Add(i);
        }
    }

    list.Sort();

    nums1 = [];
    nums1 = [.. list];
}