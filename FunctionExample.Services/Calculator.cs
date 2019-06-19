using FunctionExample.Contracts;
using System;

namespace FunctionExample.Services
{
    public class Calculator : ICalculator
    {
        public int Add(int integer1, int integer2)
        {
            int result = integer1 + integer2;
            return result;
        }
    }
}
