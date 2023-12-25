using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProject
{
    /// <summary>
    /// 6.鋸齒形轉換
    /// https://leetcode.com/problems/zigzag-conversion/description/
    /// </summary>
    public class Zigzag_Conversion
    {
        public static string Convert(string s, int numRows)
        {
            var str = s.ToCharArray();
            if (numRows == 1)return s;

            List<StringBuilder> rows = new List<StringBuilder>(Math.Min(numRows, s.Length));
            for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            {
                rows.Add(new StringBuilder());
            }

            var direction = -1;
            var row = 0;

            for (int i = 0; i < str.Length; i++)
            {
                rows[row].Append(str[i]);
                row += (direction == -1)? 1 : -1;

                if (row == 0 || row == numRows - 1)
                {
                    direction *= -1;
                }
            }
            var result = new StringBuilder();
            foreach (var item in rows)
            {
                result.Append(item);
            }
            return result.ToString();
        }
    }

    /*
範例1：

輸入： s =“PAYPALISHIRING”，numRows = 3
輸出： “PAHNAPLSIIGYIR”

範例2：

輸入： s = "PAYPALISHIRING", numRows = 4
輸出： "PINALSIGYAHRPI"
解釋： 
PIN 
ALSIG 
YAHR 
PI
範例3：


輸入： s = "A"，行數 = 1
輸出： "A"
     
     */
}
