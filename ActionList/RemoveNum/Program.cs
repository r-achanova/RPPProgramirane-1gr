using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int last = nums[nums.Count - 1];//last element
            int last1 = nums.Last(); //last element
           //  nums.RemoveAll(x => x == last);
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]==last)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
