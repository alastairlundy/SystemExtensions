/*
        MIT License
       
       Copyright (c) 2020-2025 Alastair Lundy
       
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
using System.Linq;
using System.Text;

namespace AlastairLundy.Extensions.System.Strings.Versioning
{
    public static class AddMissingZeroesExtensions
    {
        /// <summary>
        /// Add missing zeroes to the version string if it is missing zeroes.
        /// </summary>
        /// <param name="str">The string to be modified.</param>
        /// <param name="numberOfZeroesNeeded">The number of zeroes to be added. Valid values are 0 through 3. Defaults to 3.</param>
        /// <returns>the modified string.</returns>
        /// <exception cref="ArgumentException">Thrown if the number of zeroes to be added is greater than 3.</exception>
        public static string AddMissingZeroes(this string str, int numberOfZeroesNeeded = 3)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str);

            if (numberOfZeroesNeeded < 0 || numberOfZeroesNeeded > 3)
            {
                throw new ArgumentException("Invalid number of zeroes requested. Value must be between 0 and 3.");
            }
            
            int dots = str.CountDotsInString();

            if (dots < numberOfZeroesNeeded)
            {
                while (dots < numberOfZeroesNeeded)
                {
                    stringBuilder.Append('.');
                    stringBuilder.Append('0');

                    dots = str.CountDotsInString();
                }
            }
            else if (dots > numberOfZeroesNeeded)
            {
                while (dots > numberOfZeroesNeeded)
                {
#if NET6_0_OR_GREATER || NETSTANDARD2_1
                    if (str.Last() == 0 && str[^2] == '.')
#else
                    if (str.Last() == 0 && str[str.Length - 2] == '.')
#endif
                    {
                        str = str.Remove(str.Length - 2, 1);
                    }
                    else
                    {
                        break;
                    }

                    dots = str.CountDotsInString();
                }
            }

            return stringBuilder.ToString();
        }
    }
}