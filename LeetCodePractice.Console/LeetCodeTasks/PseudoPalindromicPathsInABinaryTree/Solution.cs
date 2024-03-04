using LeetCodePractice.Console.Utilities;
using TreeNode = LeetCodePractice.Console.Trees.BinaryTreeNode;

namespace LeetCodePractice.Console.LeetCodeTasks.PseudoPalindromicPathsInABinaryTree;

/// <summary>
/// https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/submissions/1155409237/?envType=daily-question&envId=2024-01-24
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<int, TreeNode>> GetTestCases()
    {
        yield return new TestCase<int, TreeNode>(1, TreeNode.CreateFromArray([9]), new Solution().PseudoPalindromicPaths);
        yield return new TestCase<int, TreeNode>(2, TreeNode.CreateFromArray([2, 3, 1, 3, 1, null, 1]), new Solution().PseudoPalindromicPaths);
        yield return new TestCase<int, TreeNode>(1, TreeNode.CreateFromArray([2, 1, 1, 1, 3, null, null, null, null, null, 1]), new Solution().PseudoPalindromicPaths);
    }

    public int PseudoPalindromicPaths(TreeNode root)
    {
        var numberOfPseudoPalindromicPaths = GetPseudoPalindromicPaths(root, new());

        return numberOfPseudoPalindromicPaths;
    }

    private static int GetPseudoPalindromicPaths(TreeNode node, Dictionary<int, bool> nodePaths)
    {
        var nodeParity = nodePaths.TryGetValue(node.val, out var currentNodeParity) switch
        {
            true => !currentNodeParity,
            false => true,
        };

        nodePaths[node.val] = nodeParity;

        var numberOfPseudoPalindromicPaths = 0;

        if (node.left is null && node.right is null)
        {
            var unpairedValues = nodePaths.Values.Count(val => val);

            nodePaths[node.val] = !nodePaths[node.val];

            return unpairedValues > 1 ? 0 : 1;
        }

        if (node.left is not null)
        {
            numberOfPseudoPalindromicPaths += GetPseudoPalindromicPaths(node.left, nodePaths);
        }

        if (node.right is not null)
        {
            numberOfPseudoPalindromicPaths += GetPseudoPalindromicPaths(node.right, nodePaths);
        }

        nodePaths[node.val] = !nodePaths[node.val];

        return numberOfPseudoPalindromicPaths;
    }
}
