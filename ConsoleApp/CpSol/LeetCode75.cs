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
    }
}