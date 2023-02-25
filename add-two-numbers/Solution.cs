// ListNode class was given
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res = new ListNode();
        ListNode resHead = res;

        int carry = 0;
        for (;;) {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            res.val = sum % 10;
            carry = sum / 10;

            l1 = l1?.next;
            l2 = l2?.next;

            if (l1 != null || l2 != null || carry > 0) {
                res.next = new ListNode();
                res = res.next;
            } else {
                break;
            }
        }

        return resHead;
    }
}