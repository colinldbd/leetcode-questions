namespace SameTree
{
    internal class SameTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if(p == null && q == null)
            {
                return true;
            }
            else if(p!=null && q != null)
            {
                if (p.val != q.val) return false;
                bool isSameTreeLeft = IsSameTree(p.left, q.left);
                bool isSameTreeRight = IsSameTree(p.right, q.right);
                if (!isSameTreeLeft || !isSameTreeRight) return false;
                else return true;
            }
            else
            {
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
