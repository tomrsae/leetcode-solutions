using System.Collections.Generic;

public class ListNode {
	public int val;
	public ListNode next;
	public ListNode(int val=0, ListNode next=null) {
		this.val = val;
		this.next = next;
	}
}

public class Solution {
	public ListNode RemoveNthFromEnd(ListNode head, int n) {
		if (head == null || (head.next == null && n >= 1)) return null;

		List<ListNode> li = new List<ListNode>();

		ListNode cur = head;
		int sz = 0;
		while (cur != null) {
			li.Add(cur);
			sz++;
			cur = cur.next;
		}

		if (n == 1) li[sz - 2].next = null;
		else if (n >= sz) head = head.next;	
		else li[sz - n - 1].next = li[sz - n + 1];

		return head;
	}
}