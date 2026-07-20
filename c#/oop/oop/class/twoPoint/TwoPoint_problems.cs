using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace oop
{
    internal class TwoPoint_problems
    {
        public class Solution
        {
            public bool IsHappy(int n)
            {
                string result = n.ToString();
                
                List<int> intlist = result.Select(x => int.TryParse(x.ToString(), out var n) ? n : 0).ToList();
                
                int total_num = totol(intlist);
                return true;
            }

            private int totol(List<int> values)
            {
                int total = 0;
                for (int i = 0; i <= values.Count; i++)
                {
                    total = total + values[i] * values[i];
                }
                return total;
            }
        }
    }
}

