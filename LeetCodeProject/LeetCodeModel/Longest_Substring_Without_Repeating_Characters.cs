namespace LeetCodeProject
{
    /// <summary>
    /// 3. 最長無重複字元的子字串
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
    /// </summary>
    public class Longest_Substring_Without_Repeating_Characters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == "") return 0;

            var c = s.ToCharArray();
            var n = "";
            var maxlength = 1;
            for (int i = 0; i < c.Count(); i++)
            {
                if (n.IndexOf(c[i]) != -1)
                {
                    n = "";
                    continue;
                }
                n += c[i];
                for (int j = i + 1; j < c.Count(); j++)
                {
                    if (n.IndexOf(c[j]) != -1)
                    {
                        maxlength = n.Length > maxlength ? n.Length : maxlength;
                        n = "";
                        break;
                    }
                    n += c[j];
                    if(j == c.Count() - 1) return n.Length > maxlength ? n.Length : maxlength;
                }
            }

            return  maxlength;
        }
    }


    /**
     範例1：

輸入： s = "abcabcbb"
輸出： 3
解釋：答案是“abc”，長度為 3。
範例2：

輸入： s = "bbbbb"
輸出： 1
解釋：答案是 "b"，長度為 1。
範例3：

輸入： s = "pwwkew"
輸出： 3
解釋：答案是“wke”，長度為 3。
注意，答案必須是子字串，“pwke”是子序列而不是子字串。
 

限制條件：

0 <= s.length <= 5 * 104
s由英文字母、數字、符號和空格組成。
     
     */
}
