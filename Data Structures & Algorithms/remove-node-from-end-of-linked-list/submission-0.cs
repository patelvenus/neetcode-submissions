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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        var dummy = new ListNode();
        dummy.next = head;

        var p1= dummy.next;
        var p2 = dummy;

        for(int i=0;i<n;i++)
        {
            p1 = p1.next;
        }

        while(p1!=null)
        {
            p1 = p1.next;
            p2 = p2.next;
        }

        p2.next = p2.next.next;
        
        return dummy.next;
    }
}