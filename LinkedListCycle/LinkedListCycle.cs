namespace LinkedListCycle
{
    internal class LinkedListCycle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /**
        * Definition for singly-linked list.
        * public class ListNode {
        *     public int val;
        *     public ListNode next;
        *     public ListNode(int x) {
        *         val = x;
        *         next = null;
        *     }
        * }
        */
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();

            if(head == null)
            {
                return false;
            }

            while(head.next != null)
            {
                if (visited.Contains(head.next))
                {
                    return true;
                }

                visited.Add(head);
                head = head.next;
            }

            return false;
        }

        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
