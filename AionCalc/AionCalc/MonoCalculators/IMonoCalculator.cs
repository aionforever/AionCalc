﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public interface IMonoCalculator
    {
        string Calculate(double firstArgument);
    }
}