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

namespace AlastairLundy.Extensions.System.Maths.Averages
{
    /// <summary>
    /// 
    /// </summary>
    public class Median
    {
        /// <summary>
        /// Returns the median of an array of doubles.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of doubles</returns>
        public static double OfDoubles(double[] values)
        {
            if (values.Length % 2 == 0)
            {
                double valueOne = values[values.Length / 2];
                double valueTwo = values[(values.Length / 2) - 1];

#if NET5_0_OR_GREATER
                return ArithmeticMean.ToDouble([valueOne, valueTwo]);
#else
                return ArithmeticMean.ToDouble(new double[]{valueOne, valueTwo});
#endif
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return values[(values.Length / 2) + 1];
            }
        }

        /// <summary>
        /// Returns the median of an array of decimals.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of decimals</returns>
        public static decimal OfDecimals(decimal[] values)
        {
            if (values.Length % 2 == 0)
            {
                decimal valueOne = values[values.Length / 2];
                decimal valueTwo = values[(values.Length / 2) - 1];
                
#if NET5_0_OR_GREATER
                return ArithmeticMean.ToDecimal([valueOne, valueTwo]);
#else
                return ArithmeticMean.ToDecimal(new decimal[]{valueOne, valueTwo});
#endif
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return values[(values.Length / 2) + 1];
            }
        }

        /// <summary>
        /// Returns the median of an array of floats.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of floats</returns>
        public static float OfFloats(float[] values)
        {
            if (values.Length % 2 == 0)
            {
                float valueOne = values[values.Length / 2];
                float valueTwo = values[(values.Length / 2) - 1];
                
#if NET5_0_OR_GREATER
                return ArithmeticMean.ToFloat([valueOne, valueTwo]);
#else
                return ArithmeticMean.ToFloat(new float[]{valueOne, valueTwo});
#endif
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return values[(values.Length / 2) + 1];
            }
        }

        /// <summary>
        /// Returns the median of an array of 64 Bit integers.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of 64 Bit integers</returns>
        public static long OfLongs(long[] values)
        {
            if (values.Length % 2 == 0)
            {
                long valueOne = values[values.Length / 2];
                long valueTwo = values[(values.Length / 2) - 1];
                
#if NET5_0_OR_GREATER
                return ArithmeticMean.ToLong([valueOne, valueTwo]);
#else
                return ArithmeticMean.ToLong(new long[]{valueOne, valueTwo});
#endif
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return values[(values.Length / 2) + 1];
            }
        }
        
        /// <summary>
        /// Returns the median of an array of 32 Bit integers.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of 32 Bit integers</returns>
        public static int OfInts(int[] values)
        {
            if (values.Length % 2 == 0)
            {
                int valueOne = values[values.Length / 2];
                int valueTwo = values[(values.Length / 2) - 1];
                
#if NET5_0_OR_GREATER
                return ArithmeticMean.ToInt([valueOne, valueTwo]);
#else
                return ArithmeticMean.ToInt(new int[]{valueOne, valueTwo});
#endif
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return values[(values.Length / 2) + 1];
            }
        }
    }
}