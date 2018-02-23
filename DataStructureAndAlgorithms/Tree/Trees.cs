using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (root.Val > maxValue || root.Val < minValue) return false;
            return ValidateBstRecursiveHelper(root.Left, minValue, root.Val) &&
                   ValidateBstRecursiveHelper(root.Right, root.Val, maxValue);
        }
    }
}
