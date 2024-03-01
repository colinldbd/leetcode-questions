namespace MaxDepthOfBInaryTree
{
    internal class MaxDepthOfBInaryTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;

            int depthLeft = MaxDepth(root.left);
            int depthRight = MaxDepth(root.right);

            return 1 + Math.Max(depthLeft, depthRight);
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
