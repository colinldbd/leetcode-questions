namespace MinimumAbsoluteDifferenceinBST
{
    internal class MinimumAbsoluteDifferenceinBST
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int GetMinimumDifference(TreeNode root)
        {
            int min = Int32.MaxValue;

            return FindMinDiff(root, root, min);

            //Or you can do it with inodertraversal, use a global variable minDiff and prevNode to track the difference.
            // And as you traver it, update the prevNode and variable minDiff.
        }

        protected int FindMinDiff(TreeNode root, TreeNode? node, int min)
        {
            if (node == null) return min;
            if (FindSuccessor(root, node) != null)
            {
                int diff = Math.Abs(FindSuccessor(root, node).val - node.val);
                if (min > diff) min = diff;
            }

            min = Math.Min(FindMinDiff(root, node.left, min), min);
            min = Math.Min(FindMinDiff(root, node.right, min), min);
            return min;
        }

        // The idea here is if node.val >= currentRoot.val
        // go right if node.val >= currentRoot.val because you need to find
        // a larger number til node.val < current.val, then you need to go left,
        // to find the smallest number that is larger than node.val.
        // go left if node.val < currentRoot.val because you need to find
        // a smaller number than node.val.
        // If node.val is still less than currentRoot.val, you need to keep going
        // left, til node.val >= currentRoot.val, which means you should go right
        // to find a number larger than node.val.
        // then try to go left to find the smallest number in the numbers that is
        // larger than node.val
        // til there's no left(currentRoot.left == null),
        // then the successor is the currentRoot.

        protected TreeNode? FindSuccessor(TreeNode? root, TreeNode node)
        {
            if (root == null)
            {
                return null;
            }
            if (node.val >= root.val)
            {
                return FindSuccessor(root.right, node);
            }
            else
            {
                TreeNode? leftNode = FindSuccessor(root.left, node);
                return leftNode ?? root;
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