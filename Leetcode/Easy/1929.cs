using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1929 : ILeetcodeTask
    {
        public string Name => "1929. Concatenation of Array";

        public bool Trace { get; set; }
        public int[] Run(int[] nums)
        {
            if (nums.Length == 0) return new int[0];

            int[] result = new int[nums.Length * 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[i % nums.Length];
            }
            return result;
        }
    }
}
