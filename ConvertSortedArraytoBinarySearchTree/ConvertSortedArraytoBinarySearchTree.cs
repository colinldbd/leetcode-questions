namespace ConvertSortedArraytoBinarySearchTree
{
    internal class ConvertSortedArraytoBinarySearchTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SortedArrayToBST([-10, -3, 0, 5, 9]);

            return;
        }

        public static TreeNode? SortedArrayToBST(int[] nums)
        {
            return CreateSubTree(nums, 0, nums.Length - 1);
        }

        protected static TreeNode? CreateSubTree(int[] nums, int left, int right)
        {
            if (left > right)
                return null;
            // If left == right, you still got one node, still need to create
            int mid = (left + right) / 2;

            TreeNode treeNode = new(nums[mid])
            {
                left = CreateSubTree(nums, left, mid - 1),
                right = CreateSubTree(nums, mid + 1, right)
            };

            return treeNode;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
