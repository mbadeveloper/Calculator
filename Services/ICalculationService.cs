﻿using Calculator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public interface ICalculationService
    {
        decimal Caluclate(List<Operation> operations);
    }
}
