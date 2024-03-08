using System.Text;

namespace ConsoleApp
{
    public class LeetCode75{
        public string MergeAlternately(string word1, string word2) {
        StringBuilder mergedString = new StringBuilder();
        int shortestLength = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < shortestLength; i++)
         {
    mergedString.Append(word1[i]);
    mergedString.Append(word2[i]);
      }

  // Append remaining characters from longer string
  mergedString.Append(word1.Substring(shortestLength));
  mergedString.Append(word2.Substring(shortestLength));

  return mergedString.ToString();
         }



         /// <summary>
         /// 
         /// </summary>
         /// <param name="str1"></param>
         /// <param name="str2"></param>
         /// <returns></returns>

         public string GcdOfStrings(string str1, string str2) {
        int len1 = str1.Length;
        int len2 = str2.Length;
        int gcdLength = Gcd(len1, len2);
        string substring = str1.Substring(0, gcdLength);

        if (IsDivisible(str1, substring) && IsDivisible(str2, substring))
        {
            return substring;
        }
        else
        {
            return "";
        }
    }
 
    
    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static bool IsDivisible(string str, string pattern)
    {
        int patternLength = pattern.Length;
        int strLength = str.Length;

        if (strLength % patternLength != 0)
        {
            return false;
        }

        for (int i = 0; i < strLength; i += patternLength)
        {
            if (str.Substring(i, patternLength) != pattern)
            {
                return false;
            }
        }

        return true;
    }
    }
}