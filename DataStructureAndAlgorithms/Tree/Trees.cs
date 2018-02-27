using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAndAlgorithms.Tree
{
    public static class Trees
    {
        public static bool ValidateBst(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode pre = null;

            while (root != null || stack.Any())
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }

                root = stack.Pop();
                if (pre != null && root.Val <= pre.Val) return false;
                pre = root;
                root = root.Right;
            }

            return true;
        }

        public static bool ValidateBstRecursive(TreeNode root)
        {
            if (root == null) return true;

            return ValidateBstRecursiveHelper(root, long.MinValue, long.MaxValue);
        }

        private static bool ValidateBstRecursiveHelper(TreeNode root, long minValue, long maxValue)
        {
            if (root == null) return true;
            if (root.Val >= maxValue || root.Val <= minValue) return false;
            return ValidateBstRecursiveHelper(root.Left, minValue, root.Val) &&
                   ValidateBstRecursiveHelper(root.Right, root.Val, maxValue);
        }

        public static bool IsSymmetricRecursive(TreeNode root)
        {
            return IsSymmetricRecursive(root, root);
        }

        private static bool IsSymmetricRecursive(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null) return true;
            if (leftNode == null || rightNode == null) return false;

            return leftNode.Val == rightNode.Val &&
                   IsSymmetricRecursive(leftNode.Right, rightNode.Left) &&
                   IsSymmetricRecursive(leftNode.Left, rightNode.Right);
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root.Left);
            stack.Push(root.Right);

            while (stack.Any())
            {
                var node1 = stack.Pop();
                var node2 = stack.Pop();
                if (node1 == null && node2 == null) continue;
                if (node1 == null || node2 == null) return false;
                if (node1.Val != node2.Val) return false;
                stack.Push(node1.Right);
                stack.Push(node2.Left);
                stack.Push(node1.Left);
                stack.Push(node2.Right);
            }

            return true;
        }

        public static int ClosestValue(TreeNode root, double target)
        {
            TreeNode result = root;
            var minimum = double.MaxValue;
            while (root != null)
            {
                var absolute = Math.Abs(target - root.Val);
                if (absolute < minimum)
                {
                    result = root;
                    minimum = absolute;
                }

                root = target > root.Val ? root.Right : root.Left;
            }

            return result.Val;
        }

        public static int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;
            return SumNumbers(root, 0);
        }

        private static int SumNumbers(TreeNode root, int s)
        {
            if (root.Left == null && root.Right == null)
            {
                return 10 * s + root.Val;
            }

            int val = 0;
            if (root.Left != null)
                val = val + SumNumbers(root.Left, 10 * s + root.Val);
            if (root.Right != null)
                val = val + SumNumbers(root.Right, 10 * s + root.Val);
            return val;
        }
    }
}