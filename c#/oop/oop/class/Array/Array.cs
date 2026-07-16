using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    internal class Array_problem
    {

        public class Problem
        {
            public class Solution
            {
                public int SingleNumber(int[] nums)
                {
                    int result = 0;
                    foreach (int num in nums)
                    {
                        result ^= num;
                    }
                    return result;
                }
            }

        }
    }
}
