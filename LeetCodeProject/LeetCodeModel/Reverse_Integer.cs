using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProject
{
    /// <summary>
    /// 7. 反轉整數
    /// https://leetcode.com/problems/reverse-integer/description
    /// </summary>
    public class Reverse_Integer
    {
        public static int Reverse(int x)
        {
            var c = x.ToString().ToCharArray();
            var result  = new StringBuilder();
            for (int i = c.Length - 1; i >= 0; i--)
            {
                if (c[i] == '-') result.Insert(0, c[i]);
                else result.Append(c[i]);
            }
            if(Convert.ToInt64(result.ToString()) > Int32.MaxValue || Convert.ToInt64(result.ToString()) < Int32.MinValue) return 0;
            var output = Convert.ToInt32(result.ToString());

            return output;
        }
    }


    /*
Example 1:

Input: x = 123
Output: 321

Example 2:

Input: x = -123
Output: -321

Example 3:

Input: x = 120
Output: 21
     */
}
