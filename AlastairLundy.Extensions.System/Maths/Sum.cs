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
using System.Collections.Generic;

namespace AlastairLundy.Extensions.System.Maths
{
    /// <summary>
    /// A class to assist in calculating the Arithmetic sum of values.
    /// </summary>
    public static class Sum
    {
        /// <summary>
        /// Performs the sum of all the doubles specified and returns it.
        /// </summary>
        /// <param name="values">The doubles to be added up.</param>
        /// <returns>the sum of the specified doubles.</returns>
        public static double OfDoubles(IEnumerable<double> values)
        {
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }

            return sum;
        }
        
        /// <summary>
        /// Performs the sum of all the decimals specified and returns it.
        /// </summary>
        /// <param name="values">The decimals to be added up.</param>
        /// <returns>the sum of the specified decimals.</returns>
        public static decimal OfDecimals(IEnumerable<decimal> values)
        {
            decimal sum = decimal.Zero;

            foreach (decimal value in values)
            {
                sum = decimal.Add(sum, value);
            }
            
            return sum;
        }

        /// <summary>
        /// Performs the sum of all the 64 Bit Integers specified and returns it.
        /// </summary>
        /// <param name="values">The 64 Bit Integers to be added up.</param>
        /// <returns>the sum of the specified 64 Bit Integers.</returns>
        public static long OfLongs(IEnumerable<long> values)
        {
            long sum = 0;

            foreach (long value in values)
            {
                sum += value;
            }

            return sum;
        }

        /// <summary>
        /// Performs the sum of all the 32 Bit Integers specified and returns it.
        /// </summary>
        /// <param name="values">The 32 Bit Integers to be added up.</param>
        /// <returns>the sum of the specified 32 Bit Integers.</returns>
        public static int OfInts(IEnumerable<int> values)
        {
            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }

            return sum;
        }

        /// <summary>
        /// Performs the sum of all the floats specified and returns it.
        /// </summary>
        /// <param name="values">The floats to be added up.</param>
        /// <returns>the sum of the specified floats.</returns>
        public static float OfFloats(IEnumerable<float> values)
        {
            float sum = 0;

            foreach (float value in values)
            {
                sum += value;
            }

            return sum;
        }
    }
}