using System.Xml.Linq;

namespace CountCompleteTreeNodes
{
    internal class CountCompleteTreeNodes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int CountNodes(TreeNode? root)
        {
            if (root == null) return 0;
            return 1 + CountNodes(root.left) + CountNodes(root.right);
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
