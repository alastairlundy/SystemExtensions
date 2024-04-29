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

namespace AlastairLundy.Extensions.System.DoubleExtensions
{
    public static class SignificantFigureCountingExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int GetNumberOfSignificantFigures(this double val)
        {
            var source = val.ToString(CultureInfo.InvariantCulture);
            
            int significantFigures = 0;
            
            bool reachedPeriod = false;
            
            for (int index = 0; index < source.Length; index++)
            {
                var current = source[index];

                if (current.Equals('.') && !reachedPeriod)
                {
                    reachedPeriod = true;

                    if(int.Parse(current.ToString()) > 0 && int.Parse(current.ToString()) <= 9)
                    {
                        significantFigures++;
                    }
                }
                else if(reachedPeriod)
                {
                    if(int.Parse(current.ToString()) >= 0 && int.Parse(current.ToString()) <= 9)
                    {
                        significantFigures++;
                    }
                }
            }

            return significantFigures;
        }
    }
}