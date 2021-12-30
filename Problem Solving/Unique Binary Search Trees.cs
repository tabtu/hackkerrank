/* https://leetcode.com/problems/unique-binary-search-trees/
 *
 * DP
 * 
 * Taking 1~n as root respectively:
 *      1 as root: # of trees = F(0) * F(n-1)  // F(0) == 1
 *      2 as root: # of trees = F(1) * F(n-2) 
 *      3 as root: # of trees = F(2) * F(n-3)
 *      ...
 *      n-1 as root: # of trees = F(n-2) * F(1)
 *      n as root:   # of trees = F(n-1) * F(0)
 *
 * So, the formulation is:
 *      F(n) = F(0) * F(n-1) + F(1) * F(n-2) + F(2) * F(n-3) + ... + F(n-2) * F(1) + F(n-1) * F(0)
 */
public class Solution
{
    public int NumTrees(int n)
    {
        int[] cases = new int[n + 1];
        cases[0] = cases[1] = 1;

        for (int i = 2; i < n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                cases[i] += cases[j - 1] * cases[i - j];
            }
        }
        return cases[n];
    }
}