﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public interface ILeetcodeTask
    {
        string Name { get; }
        bool Trace { set; get; }
        Task Run();
    }
}
