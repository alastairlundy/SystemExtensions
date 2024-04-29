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

namespace AlastairLundy.Extensions.System.Maths
{
    /// <summary>
    /// 
    /// </summary>
    public class MidRange
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static double OfDoubles(double[] values)
        {
#if NET5_0_OR_GREATER
            return ArithmeticMean.ToDouble([values[0], values[^1]]);
#else
            return ArithmeticMean.ToDouble(new double[] { values[0], values[values.Length - 1]});
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static decimal OfDecimals(decimal[] values)
        {
#if NET5_0_OR_GREATER
            return ArithmeticMean.ToDecimal([values[0], values[^1]]);
#else
            return ArithmeticMean.ToDecimal(new decimal[] { values[0], values[values.Length - 1]});
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static float OfFloats(float[] values)
        {
#if NET5_0_OR_GREATER
            return ArithmeticMean.ToFloat([values[0], values[^1]]);
#else
            return ArithmeticMean.ToFloat(new float[] { values[0], values[values.Length - 1]});
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static long OfLongs(long[] values)
        {
#if NET5_0_OR_GREATER
            return ArithmeticMean.ToLong([values[0], values[^1]]);
#else
            return ArithmeticMean.ToLong(new long[] { values[0], values[values.Length - 1]});
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int OfInts(int[] values)
        {
#if NET5_0_OR_GREATER
            return ArithmeticMean.ToInt([values[0], values[^1]]);
#else
            return ArithmeticMean.ToInt(new int[] { values[0], values[values.Length - 1]});
#endif
        }
    }
}