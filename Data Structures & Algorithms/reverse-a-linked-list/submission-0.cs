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
    public ListNode ReverseList(ListNode head) {
        
        ListNode n = null;

        while(head!=null)
        {
            var t = new ListNode(head.val);
            t.next = n;
            n = t;
            head = head.next;
        }

        return n;
    }
}
