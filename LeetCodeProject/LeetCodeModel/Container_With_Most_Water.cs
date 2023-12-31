﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProject.LeetCodeModel
{
    /// <summary>
    /// 11. 裝最多水的容器
    /// https://leetcode.com/problems/container-with-most-water
    /// </summary>
    public class Container_With_Most_Water
    {
        public static int MaxArea(int[] height)
        {
            var max = 0;
            int left =0,right = height.Length-1;
            while(left < right)
            {
                var area = Math.Min(height[left], height[right]) * (right - left);
                max = Math.Max(max, area);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }


            return max;
        }
    }

    /*
     *
範例1：
輸入： height = [1,8,6,2,5,4,8,3,7]
輸出： 49
解釋：上面的垂直線由陣列 [1,8,6,2,5,4,8 表示, 3,7]。在這種情況下，容器可容納的最大水面積（藍色部分）為 49。

範例2：

輸入：高度 = [1,1]
輸出： 1
     */
}
