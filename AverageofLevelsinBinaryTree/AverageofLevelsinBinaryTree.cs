namespace AverageofLevelsinBinaryTree
{
    internal class AverageofLevelsinBinaryTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<double> AverageOfLevels(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<double> result = new List<double>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count();
                double sum = 0;
                // While dequeuing, the node in next level will be added into
                // the queue, and as this itertion contines, all current level node
                // will be removed, and the Count of queue will be the size of next level
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Add(sum / size);
            }

            return result;
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
