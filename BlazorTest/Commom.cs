using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest
{
    public class Commom
    {
        public double Divide(int a, int b)
        {
            if (b == 0) throw new Exception("...");
            return a / b;
        }
    }
}
