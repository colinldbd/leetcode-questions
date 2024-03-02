namespace CalculatePathSum
{
    internal class CalculatePathSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            //int sum = 0;

            //return dfs(root, sum, targetSum);
            return dfs2(root, targetSum);

            //if (root == null) return false;
            //if (root.left == null && root.right == null) return root.val == k;
            //return hasPathSum(root.left, k - root.val) || hasPathSum(root.right, k - root.val);
        }

        // Why can't we use a non-recursive approach using stack?
        // Because by doing ti recursively, we are using copies of sum
        // in different function calls, and in different call, the sum
        // is not affected. But when using stack, there's only one sum 
        // and it will be changed in the iteration process, and we won't
        // be able to "roll back" to a certain sum when one path doesn't work.
        public bool dfs(TreeNode node, int val, int targetSum)
        {
            int result = val + node.val;
            bool leftFlag = false, rightFlag =false;

            if (node.left == null && node.right == null)
            {
                return result == targetSum;
            }
            if (node.left != null) leftFlag = dfs(node.left, result, targetSum);
            if (node.right != null) rightFlag =  dfs(node.right, result, targetSum);

            return leftFlag || rightFlag;
        }

        public bool dfs2(TreeNode? node, int targetSum)
        {
            if(node == null) return false;

            if (node.left == null && node.right == null)
            {
                return node.val == targetSum;
            }

            return dfs2(node.left, targetSum - node.val) || dfs2(node.right, targetSum - node.val);
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
