using oop.Models;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Oop;


public class Program
{

    public static async Task Main()
    {


        //Task.WhenAll(PrintOne(), PrintOneAsync());

        //var solution = new Solution();
        //int[] num = new int[] { -1, 0, 1, 2, -1, -4 };
        //var response = solution.ThreeSum(num);
        //Console.WriteLine(response);


        var solution_1 = new Solution_1();

        bool value = solution_1.IsPalindrome("A man, a plan, a canal: Panama");
        Console.WriteLine(value);

        Console.ReadLine();

    }


    public static async Task PrintOne()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current number:one {i}");

            }
        });
    }

    public static async Task PrintOneAsync()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current number:two {i}");
            }
        });
    }


    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }

    public class Solution_1
    {
        public bool IsPalindrome(string s)
        {
            if(string.IsNullOrEmpty(s)) return true;
            string value = RemoveNonAlphanumericChars(s.ToLower().Trim());
            string[] array = value.Select(c => c.ToString()).ToArray();
            for(int i = 0; i < array.Length; i++)
            {
                int x = (array.Length - i ) - 1;
                int y = i;
                if (array[x] != array[y])
                {
                   return false;
                }

            }
            return true;

        }


        Regex regex = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);

        public  string RemoveNonAlphanumericChars(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            return regex.Replace(s, "");

        }

    }



}
    




