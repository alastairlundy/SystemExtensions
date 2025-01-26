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

namespace AlastairLundy.Extensions.Maths.Averages;

    /// <summary>
    /// 
    /// </summary>
    public static class MedianExtensions
    {
        /// <summary>
        /// Returns the median of an array of doubles.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of doubles</returns>
        public static double Median(this IEnumerable<double> values)
        {
            double[] enumerable = values as double[] ?? values.ToArray();
            
            if (enumerable.Length % 2 == 0)
            {
                double valueOne = enumerable[enumerable.Length / 2];
                double valueTwo = enumerable[(enumerable.Length / 2) - 1];
                
                return new[]{valueOne, valueTwo}.ArithmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return enumerable[(enumerable.Length / 2) + 1];
            }
        }

        /// <summary>
        /// Returns the median of an array of decimals.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of decimals</returns>
        public static decimal Median(this IEnumerable<decimal> values)
        {
            decimal[] enumerable = values as decimal[] ?? values.ToArray();
            
            if (enumerable.Length % 2 == 0)
            {
                decimal valueOne = enumerable[enumerable.Length / 2];
                decimal valueTwo = enumerable[(enumerable.Length / 2) - 1];
                
                return new[]{valueOne, valueTwo}.ArithmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return enumerable[(enumerable.Length / 2) + 1];
            }
        }

        /// <summary>
        /// Returns the median of an array of floats.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of floats</returns>
        public static float Median(this IEnumerable<float> values)
        {
            float[] enumerable = values as float[] ?? values.ToArray();
            
            if (enumerable.Length % 2 == 0)
            {
                float valueOne = enumerable[enumerable.Length / 2];
                float valueTwo = enumerable[(enumerable.Length / 2) - 1];
                
                return new[]{valueOne, valueTwo}.ArithmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return enumerable[(enumerable.Length / 2) + 1];
            }
        }

        /// <summary>
        /// Returns the median of an array of 64 Bit integers.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of 64 Bit integers</returns>
        public static long Median(this IEnumerable<long> values)
        {
            long[] enumerable = values as long[] ?? values.ToArray();
            
            if (enumerable.Length % 2 == 0)
            {
                long valueOne = enumerable[enumerable.Length / 2];
                long valueTwo = enumerable[(enumerable.Length / 2) - 1];
                
                return new[]{valueOne, valueTwo}.ArtihmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return enumerable[(enumerable.Length / 2) + 1];
            }
        }
        
        /// <summary>
        /// Returns the median of an array of 32 Bit integers.
        /// </summary>
        /// <param name="values">The array to get the median from.</param>
        /// <returns>the median of an array of 32 Bit integers</returns>
        public static int Median(this IEnumerable<int> values)
        {
            int[] enumerable = values as int[] ?? values.ToArray();
            
            if (enumerable.Length % 2 == 0)
            {
                int valueOne = enumerable[enumerable.Length / 2];
                int valueTwo = enumerable[(enumerable.Length / 2) - 1];
                
                return new[]{valueOne, valueTwo}.ArithmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return enumerable[(enumerable.Length / 2) + 1];
            }
        }
    }