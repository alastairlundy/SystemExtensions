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

using System.Globalization;

namespace AlastairLundy.Extensions.System.Maths
{
    public static class SignificantFigureCountingExtensions
    {
        /// <summary>
        /// Returns the number of significant figures in the specified value.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns>the number of significant figures in the specified value as an integer.</returns>
        public static int GetNumberOfSignificantFigures(this double value)
        {
            return decimal.Parse(value.ToString(CultureInfo.InvariantCulture)).GetNumberOfSignificantFigures();
        }
        
        /// <summary>
        /// Returns the number of significant figures in a decimal.
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns>the number of significant figures contained in the specified value.</returns>
        public static int GetNumberOfSignificantFigures(this decimal value)
        {
            string source = value.ToString(CultureInfo.InvariantCulture);

            int significantFigures = 0;

            bool reachedPeriod = false;

            for (int index = 0; index < source.Length; index++)
            {
                var current = source[index];

                if (current.Equals('.') && !reachedPeriod)
                {
                    reachedPeriod = true;
                }
                else if (reachedPeriod)
                {
                    if (int.Parse(current.ToString()) >= 0 && int.Parse(current.ToString()) <= 9)
                    {
                        significantFigures++;
                    }
                }
            }

            return significantFigures;
        }
    }
}