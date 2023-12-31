﻿namespace DataStructurePractice.LeetCode;

public class MergeTwoBinaryTrees
{
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        if (t1 == null)
        {
            return t2;
        }
        if (t2 == null)
        {
            return t1;
        }
        TreeNode merged = new TreeNode(t1.val + t2.val);
        merged.left = MergeTrees(t1.left, t2.left);
        merged.right = MergeTrees(t1.right, t2.right);
        return merged;
    }
}
