using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProject.LeetCodeModel
{
    /// <summary>
    /// 12. 整數轉羅馬值
    /// https://leetcode.com/problems/integer-to-roman/description
    /// </summary>
    public class Integer_to_Roman
    {
        public static string IntToRoman(int num)
        {
            var result = "";
            var roman = new Dictionary<int, string>();
            roman.Add(1, "I");
            roman.Add(4, "IV");
            roman.Add(5, "V");
            roman.Add(9, "IX");
            roman.Add(10, "X");
            roman.Add(40, "XL");
            roman.Add(50, "L");
            roman.Add(90, "XC");
            roman.Add(100, "C");
            roman.Add(400, "CD");
            roman.Add(500, "D");
            roman.Add(900, "CM");
            roman.Add(1000, "M");


            var keys = roman.Keys.OrderByDescending(x => x).ToList();
            while (num > 0)
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (num >= keys[i])
                    {
                        result += roman[keys[i]];
                        num -= keys[i];
                        break;
                    }
                }
            }


            return result;
        }
    }

    /*
     Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

Example 1:

Input: num = 3
Output: "III"
Explanation: 3 is represented as 3 ones.
Example 2:

Input: num = 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.
Example 3:

Input: num = 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
     */
}
