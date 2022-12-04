using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1920 : ILeetcodeTask
    {
        public string Name => "1920. Build Array from Permutation";

        public bool Trace {get;set;}

        public int[] Run(int[] inputArray)
        {
            if (inputArray.Length == 0) return new int[0];
            var result = new int[inputArray.Length];

            for (int i=0;i<inputArray.Length;i++)
            {
                result[i] = inputArray[inputArray[i]];
            }
            return result;
        }
    }
}
