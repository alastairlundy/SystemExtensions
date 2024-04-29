using System;

namespace AlastairLundy.Extensions.System.DoubleExtensions
{
    public static class DoubleRootExtension
    {
        public static double Root(this double value, double n)
        {
            return Math.Pow(value, 1.0 / n);
        }
    }
}