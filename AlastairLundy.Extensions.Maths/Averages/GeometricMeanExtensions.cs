/*
        MIT License
       
       Copyright (c) 2024-2025 Alastair Lundy
       
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

using AlastairLundy.Extensions.Maths.Powers;

namespace AlastairLundy.Extensions.Maths.Averages
{
    /// <summary>
    /// A class to store code related to calculating the Geometric Mean of values.
    /// </summary>
    public static class GeometricMeanExtensions
    {
        /// <summary>
        /// Returns the Geometric mean of an array of double values.
        /// </summary>
        /// <param name="values">The values to get the Geometric Mean of.</param>
        /// <returns>the Geometric mean of the specified array.</returns>
        public static double GeometricMean(this IEnumerable<double> values)
        {
            double sum = 1.0;

            double[] enumerable = values as double[] ?? values.ToArray();
            
            foreach (double value in enumerable)
            {
                sum *= value;
            }

            return sum.Root(Convert.ToDouble(enumerable.Length));
        }

        /// <summary>
        ///  Returns the Geometric mean of an array of decimal values.
        /// </summary>
        /// <param name="values">The values to get the Geometric Mean of.</param>
        /// <returns>the Geometric mean of the specified array.</returns>
        public static decimal GeometricMean(this IEnumerable<decimal> values)
        {
            decimal sum = decimal.One;

            decimal[] enumerable = values as decimal[] ?? values.ToArray();
            
            foreach (decimal value in enumerable)
            {
                sum = decimal.Multiply(sum, value);
            }

            return sum.Root(Convert.ToDecimal(enumerable.Length));
        }

        /// <summary>
        ///  Returns the Geometric mean of an array of float values.
        /// </summary>
        /// <param name="values">The values to get the Geometric Mean of.</param>
        /// <returns>the Geometric mean of the specified array.</returns>
        public static float GeometricMean(this IEnumerable<float> values)
        {
            float sum = 1;

            float[] enumerable = values as float[] ?? values.ToArray();
            
            foreach (float value in enumerable)
            {
                sum *= value;
            }

            return sum.Root(Convert.ToSingle(enumerable.Length));
        }
    }
}