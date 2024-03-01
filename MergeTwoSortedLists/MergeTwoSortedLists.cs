namespace MergeTwoSortedLists
{
    internal class MergeTwoSortedLists
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
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */

        public ListNode MergeLists(ListNode list1, ListNode list2)
        {
            ListNode? head = new ListNode();
            ListNode? tail = null;

            tail = head;

            while (list1 != null && list2 != null)
            {
                if (list2.val <= list1.val)
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    tail.next = list1;
                    list1 = list1.next;
                }

                tail = tail.next;
            }

            if(list1 != null){
                tail.next = list1;
            }
            if(list2 != null)
            {
                tail.next = list2;
            }

            return head.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
