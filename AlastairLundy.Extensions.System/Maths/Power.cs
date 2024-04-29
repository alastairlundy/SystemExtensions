/*
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
    /// <summary>
    /// A class to assist in getting a specified number raised to a specified power.
    /// </summary>
    public static class Power
    {
        /// <summary>
        /// Returns a specified number to a specified power.
        /// </summary>
        /// <param name="x">A decimal to be raised to a power.</param>
        /// <param name="y">A decimal that specifies a power.</param>
        /// <returns></returns>
        public static decimal ToDecimal(decimal x, decimal y)
        {
            for (decimal index = decimal.Zero; index < y; index = decimal.Add(index, decimal.One))
            {
                x = decimal.Multiply(x, x);
            }

            return x;
        }

        /// <summary>
        /// Returns a specified number to a specified power.
        /// </summary>
        /// <param name="x">A float to be raised to a power.</param>
        /// <param name="y">A float that specifies a power.</param>
        /// <returns></returns>
        public static float ToFloat(float x, float y)
        {
            for (float index = 0; index < y; index++)
            {
                x *= x;
            }

            return x;
        }
    }
}