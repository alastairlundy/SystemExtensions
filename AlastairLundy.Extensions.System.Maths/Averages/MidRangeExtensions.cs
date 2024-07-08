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

// ReSharper disable RedundantExplicitArrayCreation

using System.Collections.Generic;
using System.Linq;

namespace AlastairLundy.Extensions.System.Maths.Averages
{
    /// <summary>
    /// A class to store mid-range calculation related code.
    /// </summary>
    public static class MidRangeExtensions
    {
        /// <summary>
        /// Calculates the mid-range of the values of a double array.
        /// </summary>
        /// <param name="values">The array to calculate the mid-range of.</param>
        /// <returns></returns>
        public static double MidRange(this IEnumerable<double> values)
        {
            double[] enumerable = values as double[] ?? values.ToArray();
            
            return new double[] { enumerable[0], enumerable.Last()}.ArithmeticMean();
        }

        /// <summary>
        /// Calculates the mid-range of the values of a decimal array.
        /// </summary>
        /// <param name="values">The array to calculate the mid-range of.</param>
        /// <returns></returns>
        public static decimal MidRange(this IEnumerable<decimal> values)
        {
            decimal[] enumerable = values as decimal[] ?? values.ToArray();
            
            return new decimal[] { enumerable[0], enumerable.Last()}.ArithmeticMean();
        }

        /// <summary>
        /// Calculates the mid-range of the values of a float array.
        /// </summary>
        /// <param name="values">The array to calculate the mid-range of.</param>
        /// <returns></returns>
        public static float MidRange(this IEnumerable<float> values)
        {
            float[] enumerable = values as float[] ?? values.ToArray();
            
            return new float[] { enumerable[0], enumerable.Last()}.ArithmeticMean();
        }

        /// <summary>
        /// Calculates the mid-range of the values of a 64 Bit integer array.
        /// </summary>
        /// <param name="values">The array to calculate the mid-range of.</param>
        /// <returns></returns>
        public static long MidRange(this IEnumerable<long> values)
        {
            long[] enumerable = values as long[] ?? values.ToArray();
            
            return new long[] { enumerable[0], enumerable.Last()}.ArtihmeticMean();
        }

        /// <summary>
        /// Calculates the mid-range of the values of a 32 Bit integer array.
        /// </summary>
        /// <param name="values">The array to calculate the mid-range of.</param>
        /// <returns></returns>
        public static int MidRange(this IEnumerable<int> values)
        {
            int[] enumerable = values as int[] ?? values.ToArray();
            
            return new int[] { enumerable[0], enumerable.Last()}.ArithmeticMean();
        }
    }
}