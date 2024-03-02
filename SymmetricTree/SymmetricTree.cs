using System.Security.Cryptography;

namespace SymmetricTree
{
    internal class SymmetricTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Solution
        {
            public bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }

                return check(root.left, root.right);
            }

            protected bool check(TreeNode? left, TreeNode? right)
            {
                if (left == null && right == null) return true;
                else if (left != null && right != null)
                {
                    return left.val == right.val && check(left.left, right.right) && check(left.right, right.left);
                }

                return false;
            }
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
