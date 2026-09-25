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
    public void ReorderList(ListNode head) {

        var fast = head.next;
        var slow = head;

        while(fast!=null && fast.next!=null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var middle = slow.next;
        slow.next = null;
        
        var p2 = ReverseList(middle);
        var p1 = head;

        while(p2!=null)
        {
            var temp1 = p1.next;
            var temp2 = p2.next;

            p1.next = p2;
            p2.next = temp1;
            p1 = temp1;
            p2 = temp2;
        }
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode h = null;

        while(head!=null)
        {
            var t = new ListNode(head.val);
            t.next = h;
            h = t;
            head = head.next;
        }
        return h;
    }
}
