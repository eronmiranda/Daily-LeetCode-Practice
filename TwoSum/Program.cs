using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = int.Parse(Console.ReadLine());
            foreach (var item in TwoSum(nums, target))
            {
                Console.Write(item + " ");
            }
        }

        // Change and improve this.
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashMap.ContainsKey(complement))
                {
                    return new int[] { hashMap[complement], i};
                }
                else
                {
                    hashMap.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
