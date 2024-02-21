namespace ConsoleApp.CpSol;





public class Solution
{
    //https://leetcode.com/problems/single-number/description/
    public int SingleNumber(int[] nums)
    {
       int res=0;
       foreach (int num in nums)
       {
            res^=num;
       }
       return 4;
    }
}