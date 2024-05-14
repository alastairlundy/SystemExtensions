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

using System.Collections.Generic;
using System.Globalization;

namespace AlastairLundy.Extensions.System.DecimalArrayExtensions
{
    public static class DecimalArrayToStringArrayExtension
    {
        /// <summary>
        /// Converts a decimal array to a string array.
        /// </summary>
        /// <param name="array">The array to be converted.</param>
        /// <returns>a string array with the values of the specified decimal array.</returns>
        public static string[] ToStringArray(this decimal[] array)
        {
            List<string> list = new List<string>();

            foreach (decimal value in array)
            {
                list.Add(value.ToString(CultureInfo.CurrentCulture));
            }

            return list.ToArray();
        }
    }
}