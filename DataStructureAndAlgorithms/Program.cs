using System;
using System.Runtime.CompilerServices;
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
            var sortedArray2 = Sorts<int>.SelectionSort(new[] {5, 4, 3, 2, 1});
            var sortedArray3 = Sorts<int>.InsertionSort(new[] {5, 4, 3, 2, 1});
            
            // Recursions
            var triangularNumbers = Recursions.TriangularNumbers(7);
            var factoril = Recursions.Factorial(4);

            // Binary Search Tree
            var tree = new TreeNode(10)
            {
                Left = new TreeNode(8)
                {
                    Left = new TreeNode(4),
                    Right = new TreeNode(9)
                },
                Right = new TreeNode(15)
            };
            var isBst = Trees.ValidateBst(tree);
            var isBst2 = Trees.ValidateBstRecursive(tree);
        }
    }
}
