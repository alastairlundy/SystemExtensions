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

namespace AlastairLundy.Extensions.System.Maths
{
    
    public static class Root
    {
        /// <summary>
        /// Returns the Nth Root of a value.
        /// </summary>
        /// <param name="value">The value to get the Nth root of.</param>
        /// <param name="n">The root</param>
        /// <returns></returns>
        public static double ToDouble(double value, double n)
        {
            return Math.Pow(value, 1.0 / n);
        }

        /// <summary>
        /// Returns the Nth Root of a value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static decimal ToDecimal(decimal value, decimal n)
        {
            return Power.ToDecimal(value, decimal.Divide(decimal.One, n));
        }

        /// <summary>
        ///  Returns the Nth Root of a value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static float ToFloat(float value, float n)
        {
            return Power.ToFloat(value, 1 / n);
        }
    }
}