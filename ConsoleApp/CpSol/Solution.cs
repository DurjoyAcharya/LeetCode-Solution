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
    //https://leetcode.com/problems/fizz-buzz/
    public IList<string> FizzBuzz(int n) {
        string[] answer = new string[n];
        IList<string> myList = null;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                answer[i - 1] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                answer[i - 1] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                answer[i - 1] = "Buzz";
            }
            else
            {
                answer[i - 1] = i.ToString();
            }
        }
        myList=answer.ToList();
        return myList;
        
    }

    //https://leetcode.com/explore/featured/card/fun-with-arrays/523/conclusion/3270/
    public IList<int> FindDisappearedNumbers(int[] nums) {
    //    IList<int> missingNumbers = new List<int>();
    //    int actual = nums.ToList().Sum();
    //    int n=nums.GetLength(0);
    //    int expected=n*(n+1)/2;
    //    if (actual==expected-1)
    //    {
    //     missingNumbers.Add(actual);
    //     return missingNumbers;
    //    }
      
    
    //    for (int i = 1; i < n; i++)
    //         if (!nums.Contains(i)) missingNumbers.Add(i);
    //     ((List<int>) missingNumbers).Sort();
    //     return missingNumbers;
     HashSet<int> set = new HashSet<int>(nums);
        List<int> result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
    public  bool IsPowerOfTwo(int n)
{
    // Handle negative and zero cases
    if (n <= 0)
    {
        return false;
    }

    // Check if n has only one set bit using bitwise AND with n-1
    // If n is a power of two, n-1 will have all bits set to 1 except the least significant bit
    // Performing AND operation with n-1 will result in 0 only if n is a power of two
    return (n & (n - 1)) == 0;
}
    }



    
}