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
                    try
                    {
                        List<int> list_1 = new List<int>();
                        List<int> list_2 = new List<int>();
                        if (nums == null || nums.Length == 0)
                            return 0;

                        for (int i = 0; i < nums.Length; i++)
                        {
                            for (int j = 0; j < nums.Length; j++)
                            {
                                if (nums[i] == nums[j])
                                {
                                    list_1.Add(i);
                                }
                                else
                                {
                                    list_2.Add(i);
                                }
                            }
                        }

                        int val = list_2.FirstOrDefault();
                        return val;
                        //Dictionary<int, (int, int)> keyValuePairs = new Dictionary<int, (int, int)>();
                        //foreach (int i in nums)
                        //{
                        //    List<int> keys = new();

                        //    if (nums.Contains(i))
                        //    {
                        //        int key = keyValuePairs.FirstOrDefault(x => x.Value == i).Key;
                        //        int val = key;
                        //        key++;
                        //        keyValuePairs.Add(val, ());
                        //    }

                        //    // keys accessible here


                        //    return i;
                        //    else
                        //        keyValuePairs.Add(1, i);


                    } 
                    catch (Exception e)
                    {
                        return 0;
                    }
                }
            }

        }
    }
}
