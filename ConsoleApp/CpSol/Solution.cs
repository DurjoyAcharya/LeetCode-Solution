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

    
    //https://leetcode.com/problems/isomorphic-strings/
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, char> mapS = new Dictionary<char, char>();
        Dictionary<char, char> mapT = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {

            if (mapS.ContainsKey(s[i]))
            {

                if (mapS[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (mapT.ContainsKey(t[i]))
                {
                    return false;
                }
                mapS.Add(s[i], t[i]);
                mapT.Add(t[i], s[i]);
            }
        }

        return true;
    }
}