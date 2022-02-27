using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject11
{
    class MyCals
    {
        public int Sum(int x,int y)
        {
            return x + y;
        }

        public double Residual(double x,double y)
        {
            return x - y;
        }
        public double GetSqrt(int value)
        {
            return Math.Sqrt(value);
        }
        public void MethodThatThrows()
        {
            throw new ArgumentException();
        
        }
    }
}
