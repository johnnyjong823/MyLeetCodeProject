namespace LeetCodeProject
{
    /// <summary>
    /// 5. 最長回文子串
    /// https://leetcode.com/problems/longest-palindromic-substring/description/
    /// </summary>
    public class Longest_Palindromic_Substring
    {
        public static string LongestPalindrome(string s)
        {
            int n = s.Length;
            bool[,] dp = new bool[n, n];
            string longestPalindrome = "";

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i; j < n; j++)
                {
                    dp[i, j] = s[i] == s[j] && (j - i < 3 || dp[i + 1, j - 1]);

                    if (dp[i, j] && (longestPalindrome == "" || j - i + 1 > longestPalindrome.Length))
                    {
                        longestPalindrome = s.Substring(i, j - i + 1);
                    }
                }
            }

            return longestPalindrome;
        }
    }

    /***
範例1：

輸入： s = "babad"
輸出： "bab"
解釋： "aba" 也是有效答案。
範例2：

輸入： s = "cbbd"
輸出： "bb"
     *
     */
}
