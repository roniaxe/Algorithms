using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Tree
{
    public class TreeNode
    {
        public int Val { get; }
        public TreeNode Right { get; set; }
        public TreeNode Left { get; set; }

        public TreeNode(int val)
        {
            Val = val;
        }
    }
}
