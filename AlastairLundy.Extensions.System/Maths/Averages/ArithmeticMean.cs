﻿/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:
       
       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.
       
       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE.
   */

using System;

namespace AlastairLundy.Extensions.System.Maths.Averages
{
    /// <summary>
    /// A class to assist in getting the Arithmetic mean of an array of values.
    /// </summary>
    public static class ArithmeticMean
    {
        /// <summary>
        /// Returns the arithmetic mean of a double array.
        /// </summary>
        /// <param name="values">The array of values to get the arithmetic mean of.</param>
        /// <returns></returns>
        public static double ToDouble(double[] values)
        {
            return Sum.OfDoubles(values) / values.Length;
        }

        /// <summary>
        /// Returns the arithmetic mean of a decimal array.
        /// </summary>
        /// <param name="values">The array of values to get the arithmetic mean of.</param>
        /// <returns></returns>
        public static decimal ToDecimal(decimal[] values)
        {
            return Decimal.Divide(Sum.OfDecimals(values), Convert.ToDecimal(values.Length));
        }

        /// <summary>
        /// Returns the arithmetic mean of a 64 Bit integer array.
        /// </summary>
        /// <param name="values">The array of values to get the arithmetic mean of.</param>
        /// <returns></returns>
        public static long ToLong(long[] values)
        {
            return Sum.OfLongs(values) / values.Length;
        }

        /// <summary>
        ///  Returns the arithmetic mean of a 32 Bit integer array.
        /// </summary>
        /// <param name="values">The array of values to get the arithmetic mean of.</param>
        /// <returns></returns>
        public static int ToInt(int[] values)
        {
           return Sum.OfInts(values) / values.Length;
        }
    
        /// <summary>
        ///  Returns the arithmetic mean of a float array.
        /// </summary>
        /// <param name="values">The array of values to get the arithmetic mean of.</param>
        /// <returns></returns>
        public static float ToFloat(float[] values)
        {
            return Sum.OfFloats(values) / values.Length;
        }
    }
}