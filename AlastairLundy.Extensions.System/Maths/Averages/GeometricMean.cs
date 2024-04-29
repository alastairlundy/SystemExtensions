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
using System.Linq;

namespace AlastairLundy.Extensions.System.Maths
{
    
    public class GeometricMean
    {
        /// <summary>
        /// Returns the Geometric mean of an array of double values.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static double ToDouble(double[] values)
        {
            double sum = 1.0;

            foreach (double value in values)
            {
                sum *= value;
            }

            return Root.ToDouble(sum, values.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static decimal ToDecimal(decimal[] values)
        {
            decimal sum = Decimal.One;

            foreach (decimal value in values)
            {
                sum = Decimal.Multiply(sum, value);
            }

            return Root.ToDecimal(sum, Convert.ToDecimal(values.Length));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static float ToFloat(float[] values)
        {
            float sum = 1;

            foreach (float value in values)
            {
                sum *= value;
            }

            return Root.ToFloat(sum, values.Length);
        }
    }
}