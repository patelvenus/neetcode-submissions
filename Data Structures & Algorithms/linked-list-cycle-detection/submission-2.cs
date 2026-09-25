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
    public bool HasCycle(ListNode head) {
        var p1 = head;
        var p2 = head;

        while(p1 != null && p2 !=null && p2.next!=null)
        {
            if(p1.next == p2.next.next)
                return true;
             p1 = p1.next;
             p2 = p2.next.next;
        }

        return false;
    }
}
