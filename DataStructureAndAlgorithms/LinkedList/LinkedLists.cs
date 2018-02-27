using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgorithms.LinkedList
{
    public static class LinkedLists
    {

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode c1 = l1;
            ListNode c2 = l2;
            ListNode sentinel = new ListNode(0);
            ListNode d = sentinel;
            int sum = 0;
            while (c1 != null || c2 != null)
            {
                sum /= 10;
                if (c1 != null)
                {
                    sum += c1.Val;
                    c1 = c1.Next;
                }
                if (c2 != null)
                {
                    sum += c2.Val;
                    c2 = c2.Next;
                }
                d.Next = new ListNode(sum % 10);
                d = d.Next;
            }
            if (sum / 10 == 1)
                d.Next = new ListNode(1);
            return sentinel.Next;
        }

        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var nexts = result;
            ListNode c1 = l1;
            ListNode c2 = l2;
            Stack<int> stack = new Stack<int>();

            FillStack(c1, stack);
            string numAsStr1 = NumAsString(stack);
            stack.Clear();

            FillStack(c2, stack);
            string numAsStr2 = NumAsString(stack);

            var sum = (numAsStr1 == "" ? 0 : int.Parse(numAsStr1)) + (numAsStr2 == "" ? 0 : int.Parse(numAsStr2));
            nexts.Next = new ListNode(sum % 10);
            nexts = nexts.Next;
            sum = sum / 10;
            while (sum > 0)
            {
                var modu = sum % 10;
                nexts.Next = new ListNode(modu);
                nexts = nexts.Next;
                sum = sum / 10;
            }

            return result.Next;
        }

        private static string NumAsString(Stack<int> stack)
        {
            var res = "";
            while (stack.Any())
            {
                res += stack.Pop();
            }

            return res;
        }

        private static void FillStack(ListNode ln, Stack<int> stck)
        {
            while (ln != null)
            {
                stck.Push(ln.Val);
                ln = ln.Next;
            }
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            HashSet<ListNode> hash = new HashSet<ListNode>();

            while (headA != null || headB != null)
            {
                var addA = hash.Add(headA);
                var addB = hash.Add(headB);
                if (!addB) return headB;
                if (!addA) return headA;
                headA = headA?.Next;
                headB = headB?.Next;
            }

            return null;
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = new ListNode(0);
            ListNode nexts = result;
            List<int> valueList = new List<int>();
            foreach (var list in lists)
            {
                var currList = list;
                while (currList != null)
                {
                    valueList.Add(currList.Val);
                    currList = currList.Next;
                }
            }

            var listArr = valueList.ToArray();
            Array.Sort(listArr);
            foreach (var val in listArr)
            {
                nexts.Next = new ListNode(val);
                nexts = nexts.Next;
            }

            return result.Next;
        }
    }
}
