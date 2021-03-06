﻿using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultproxy
{
    public interface ICalculatorService : IService
    {
        Task<int> Add(int a, int b);
        Task<int> Subtract(int a, int b);

        Task<string> HelloWorldAsync();

        Task<DateTime> GetCurrentTime();

    }

}
