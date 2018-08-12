using System;
using System.Runtime.CompilerServices;
using DataStructureAndAlgorithms.ArrayAndStrings;
using DataStructureAndAlgorithms.LinkedList;
using DataStructureAndAlgorithms.Recursion;
using DataStructureAndAlgorithms.Sort;
using DataStructureAndAlgorithms.Tree;

namespace DataStructureAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Sort Algorithms
            var sortedArray = Sorts<int>.BubbleSort(new[] {5, 4, 3, 2, 1});
            var arr = new[] {7, 3, 2, 8, 3};
            Sorts<int>.BubbleSortWithWhile(arr);
            var sortedArray2 = Sorts<int>.SelectionSort(new[] {5, 4, 3, 2, 1});
            var sortedArray3 = Sorts<int>.InsertionSort(new[] {5, 4, 3, 2, 1});
            var kthLargest = Sorts<int>.FindKthLargest(new[] { 3, 2, 1, 5, 6, 4 }, 2);
            
            // Recursions
            var triangularNumbers = Recursions.TriangularNumbers(7);
            var factoril = Recursions.Factorial(4);

            // Binary Search Tree
            var tree = new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(3)
                    {
                        Left = new TreeNode(5),
                        Right = new TreeNode(6)
                    },
                    Right = new TreeNode(4)
                    {
                        Left = new TreeNode(6),
                        Right = new TreeNode(5)
                    }
                },
                Right = new TreeNode(2)
                {
                    Left = new TreeNode(4)
                    {
                        Left = new TreeNode(5),
                        Right = new TreeNode(6)
                    },
                    Right = new TreeNode(3)
                    {
                        Left = new TreeNode(6),
                        Right = new TreeNode(5)
                    }
                }
            };
            var bst = new TreeNode(5)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(6)
            };
            var isBst = Trees.ValidateBst(tree);
            var isBst2 = Trees.ValidateBstRecursive(tree);
            var isSymetricRec = Trees.IsSymmetricRecursive(tree);
            var isSymetric = Trees.IsSymmetric(tree);
            var closestVal = Trees.ClosestValue(bst, 4.5);
            var sumRoutes = Trees.SumNumbers(tree);

            var test = Trees.SumNumbers(bst);

            // Linked Lists
            ListNode node1 = new ListNode(8)
            {
                Next = new ListNode(7)
                {
                    Next = new ListNode(9)
                }
            };
            ListNode node2 = new ListNode(5)
            {
                Next = new ListNode(8)
                {
                    Next = new ListNode(4)
                }
            };

            var res = LinkedLists.AddTwoNumbers(node1, node2);
            var res2 = LinkedLists.AddTwoNumbers2(node1, node2);

            var res3 = LinkedLists.GetIntersectionNode(node1, node2);

            var res4 = LinkedLists.MergeKLists(new ListNode[]{node1});

            // Arrays

            var arrRes = Arrays.TwoSum(new[] {3, 2, 4}, 6);
        }
    }
}
