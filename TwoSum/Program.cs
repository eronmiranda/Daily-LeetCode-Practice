using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());
            foreach (var item in TwoSum(nums, target))
            {
                Console.Write(item + " ");
            }
        }

        // Change and improve this.
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();
            
            if(nums != null && nums.Length >=2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    //if (hashMap.ContainsKey(complement))
                    //{
                    //    return new int[] { hashMap[complement], i };
                    //}
                    if(numsDictionary.TryGetValue(complement, out int index))
                    {
                        return new[] { index, i };
                    }
                    numsDictionary[nums[i]] = i;
                }
            }

            return Array.Empty<int>();
        }
    }
}
