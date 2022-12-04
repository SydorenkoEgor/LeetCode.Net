using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _771 : ILeetcodeTask
    {
        public string Name => "771. Jewels and Stones";

        public bool Trace { get; set; }

        public int Run(string jewels, string stones)
        {
            var result = 0;
            //return stones.Count((c) => jewels.Contains(c));
            var chars = new int[128];
            for (int i = 0; i < stones.Length; i++)
                chars[stones[i]]++;
            for(int i=0;i<jewels.Length;i++)
                result+=chars[jewels[i]];
            return result;
        }
    }
}
