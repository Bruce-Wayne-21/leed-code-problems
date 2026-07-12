using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace oop
{
    internal class leedcode 
    {

        public class Booking
        {
            public int Id { get; set; }
            public string CustomerName { get; set; }

            public void PrintDetails()
            {
                Console.WriteLine($"Booking #{Id} for {CustomerName}");
            }
        }

        public class problms
        {
            public async Task PrintOne()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Current number:one {i}");

                    }
                });
            }

            public  async Task PrintOneAsync()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Current number:two {i}");
                    }
                });
            }


            //public class Solution
            //{
            //    public IList<IList<int>> ThreeSum(int[] nums)
            //    {
            //        Array.so(nums);
            //        IList<IList<int>> result = new List<IList<int>>();

            //        for (int i = 0; i < nums.Length - 2; i++)
            //        {
            //            if (i > 0 && nums[i] == nums[i - 1]) continue;

            //            int left = i + 1, right = nums.Length - 1;

            //            while (left < right)
            //            {
            //                int sum = nums[i] + nums[left] + nums[right];

            //                if (sum == 0)
            //                {
            //                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
            //                                                    while (left < right && nums[left] == nums[left + 1]) left++;
            //                    while (left < right && nums[right] == nums[right - 1]) right--;

            //                    left++;
            //                    right--;
            //                }
            //                else if (sum < 0)
            //                {
            //                    left++;
            //                }
            //                else
            //                {
            //                    right--;
            //                }
            //            }
            //        }

            //        return result;
            //    }
            //}

            public class Solution_1
            {
                public bool IsPalindrome(string s)
                {
                    if (string.IsNullOrEmpty(s)) return true;
                    string value = RemoveNonAlphanumericChars(s.ToLower().Trim());
                    string[] array = value.Select(c => c.ToString()).ToArray();
                    for (int i = 0; i < array.Length; i++)
                    {
                        int x = (array.Length - i) - 1;
                        int y = i;
                        if (array[x] != array[y])
                        {
                            return false;
                        }

                    }
                    return true;

                }


                Regex regex = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);

                public string RemoveNonAlphanumericChars(string s)
                {
                    if (string.IsNullOrEmpty(s))
                        return s;

                    return regex.Replace(s, "");

                }

            }

            public class solution_2
            {
                public string ConvertToTitle(int columnNumber)
                {
                    try
                    {
                        var letters = Enumerable.Range(1, 26)
                                .ToDictionary(i => i, i => ((char)('A' + i - 1)).ToString());
                        if (columnNumber <= letters.Count)
                        {
                            return letters[columnNumber];
                        }
                        else
                        {
                            int times = (columnNumber / letters.Count);
                            int digicount = times.ToString().Length;
                            if (digicount > 4)
                            {
                                int count = 0;
                                for (int i = 0; i <= columnNumber; i++)
                                {
                                    if(i == times)
                                    {

                                    }
                                    if (i == 26)
                                    {
                                        count++;
                                        i = 0;
                                        continue;
                                    }

                                    if (count > columnNumber)
                                    {
                                        break;
                                    }

                                }
                            }

                            for (int i = 0; i <= columnNumber; i++)
                            {
                                do
                                {
                                     
                                }
                                while (i == columnNumber);
                            }
                            //var value_2 = letters[times];

                            int remainder = columnNumber % letters.Count;
                            //var index =   letters.Length % columnNumber;
                            string second_value = letters[remainder];
                            return  second_value;
                        }

                        return letters[columnNumber];

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            public class Solution_3
            {
                public string ConvertToTitle(int columnNumber)
                {
                    if (columnNumber == 0) return "";
                    columnNumber--;
                    char c = (char)('A' + columnNumber % 26);
                    return ConvertToTitle(columnNumber / 26) + c;
                }
            }

            public class solution_4
            {
                public int MajorityElement_1(int[] nums)
                {

                    var groups = nums.GroupBy(n => n).Select(g => new { number = g.Key, count = g.Count() });
                    int half = nums.Length / 2;

                    var index = groups.Where(n => n.count > half).ToList();
                    int number_1 = index[0].number;
                    return number_1;
                    //var number = index.Max(n => n.count && n.number).tolist();
                   
                }

                public int MajorityElement(int[] nums)
                {
                    int count = 0;
                    int candiate = nums[0];
                    for(int i =0; i < nums.Length; i++)
                    {
                        if(count == 0)
                        {
                            candiate = nums[i];
                            count++;
                            continue;
                        }
                        if(candiate != nums[i])
                        {
                            count--;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    return candiate;
                }

                public class Solution
                {
                    public int MyAtoi(string str)
                    {
                        string value = str.Replace(" ", "");
                        string st_value = "";
                        string words = "";
                        bool nagativ = false;
                        int gottheword = 1;
                        List<string> st = value.ToString().Select(c => c.ToString()).ToList();
                        for (int i = 0; i < st.Count; i++)
                        {
                            if (!int.TryParse(st[i], out int str_val))
                            {
                                words = words + st[i];
                                nagativ = st[i] == "-" ? true : false;
                                if (i == 0 && !nagativ)
                                {
                                    break;
                                }
                                
                                if(gottheword > i && !nagativ && i !=0 )
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (st[i] == "0" && i == 0)
                                {
                                    break;
                                }
                                gottheword++;
                                st_value = st_value + st[i];
                            }
                        }

                        _ = int.TryParse(st_value , out int result);
                        
                        if (nagativ)
                        {
                            result = -result;
                        }
                        return result;
                    }

                    public class Solution_23
                    {
                        public int MyAtoi(string str)
                        {
                            int i = 0, n = str.Length;

                            while (i < n && str[i] == ' ') i++;

                            int sign = 1;
                            if (i < n && (str[i] == '+' || str[i] == '-'))
                            {
                                sign = str[i] == '-' ? -1 : 1;
                                i++;
                            }

                            long result = 0; 
                            while (i < n && char.IsDigit(str[i]))
                            {
                                result = result * 10 + (str[i] - '0');
                                if (sign == 1 && result > int.MaxValue) return int.MaxValue;
                                if (sign == -1 && -result < int.MinValue) return int.MinValue;
                                i++;
                            }

                            return (int)(sign * result);
                        }
                    }
                }


                public class solition
                {
                    public bool IsIsomorphic_1(string s , string t)
                    {
                        try
                        {
                            if(s.Length !=  t.Length) return false;
                            List<string > s_list = new List<string>();
                            s_list = s.ToString().Select(e=>e.ToString()).ToList();
                            var t_list = t.ToString().Select(e =>  e.ToString()).ToList();

                            for (int i = 0, j = 0; i < s_list.Count && j < t_list.Count; i++, j++)
                            {
                                List<string> s_list2 = new List<string>();
                                List<string> t_list2 = new List<string>();

                                s_list2.Add(s_list[i]);
                                s_list.RemoveAt(i);
                                s_list.Insert(i, "0");
                                t_list2.Add(t_list[i]);
                                t_list.RemoveAt(i);
                                t_list.Insert(i, "0");
                                s_list[i] = t_list2[i];
                                t_list[i] = s_list2[i]; 

                            }

                            return true;


                        }
                        catch(Exception e)
                        {
                            return false;
                        }

                    }

                    public class Solution
                    {
                        public bool IsIsomorphic(string s, string t)
                        {
                            if (s.Length != t.Length) return false;

                            Dictionary<char, char> mapST = new Dictionary<char, char>();
                            Dictionary<char, char> mapTS = new Dictionary<char, char>();

                            for (int i = 0; i < s.Length; i++)
                            {
                                char cs = s[i];
                                char ct = t[i];

                                if (mapST.ContainsKey(cs))
                                {
                                    if (mapST[cs] != ct) return false;
                                }
                                else
                                {
                                    mapST[cs] = ct;
                                }

                                if (mapTS.ContainsKey(ct))
                                {
                                    if (mapTS[ct] != cs) return false;
                                }
                                else
                                {
                                    mapTS[ct] = cs;
                                }
                            }

                            return true;
                        }
                    }
                }

                

            }


            


        }
    }
}
