﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptingFilterPattern
{
    public class AuthenticationFilter:IFilter
    {
        public void Execute(string request)=>Console.WriteLine($"Authenticating request: {request}");
    }
}
