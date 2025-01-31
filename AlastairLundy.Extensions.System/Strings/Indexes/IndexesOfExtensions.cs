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
using System.Collections.Generic;

namespace AlastairLundy.Extensions.System.Strings.Indexes
{
    public static class IndexesOfExtensions
    {
        /// <summary>
        /// Gets the indexes of the specified char in a string.
        /// </summary>
        /// <param name="toBeSearched">The string to be searched.</param>
        /// <param name="expected">The char to look for.</param>
        /// <param name="ignoreCase">Whether to ignore the case of the expected char.</param>
        /// <returns>The indexes if the char is found; An array with a single element of -1 otherwise.</returns>
        public static IEnumerable<int> IndexesOf(this string toBeSearched, char expected, bool ignoreCase)
        {
            List<int> indexes = new List<int>();

            for(int index = 0; index < toBeSearched.Length; index++)
            {
                if (toBeSearched[index].Equals(expected) ||
                    (ignoreCase && toBeSearched[index].ToString().ToLower().Equals(expected.ToString().ToLower())))
                {
                    indexes.Add(index);
                }
            }

            return indexes;
        }
    
        /// <summary>
        /// Gets the indexes of the specified string within a string.
        /// </summary>
        /// <param name="toBeSearched">The string to be searched.</param>
        /// <param name="expected">The string to look for.</param>
        /// <param name="ignoreCase">Whether to ignore the case of the expected string.</param>
        /// <returns>The indexes if the string is found; An array with a single element of -1 otherwise.</returns>
        [Obsolete("This method is deprecated and will be removed in a future version. Please use IndexesOf(string, string, StringComparison) instead.")]
        public static IEnumerable<int> IndexesOf(this string toBeSearched, string expected, bool ignoreCase)
        {
            StringComparison comparer = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            return IndexesOf(toBeSearched, expected, comparer);
        }
    
        /// <summary>
        /// Gets the indexes of the specified string within a string.
        /// </summary>
        /// <param name="toBeSearched">The string to be searched.</param>
        /// <param name="expected">The string to look for.</param>
        /// <param name="comparer">The type of comparison to use when evaluating equality of strings.</param>
        /// <returns>The indexes if the string is found; An array with a single element of -1 otherwise.</returns>
        public static IEnumerable<int> IndexesOf(this string toBeSearched, string expected, StringComparison comparer)
        {
            List<int> indexes = new List<int>();
        
            bool ignoreCase = comparer == StringComparison.OrdinalIgnoreCase ||
                              comparer == StringComparison.CurrentCultureIgnoreCase
                              || comparer == StringComparison.InvariantCultureIgnoreCase;

            if (toBeSearched.Contains(expected) || ignoreCase && toBeSearched.ToLower().Contains(expected.ToLower()))
            {
                int index = toBeSearched.IndexOf(expected, comparer);
            
                while (index != -1)
                {
                    indexes.Add(index);
                    index = toBeSearched.IndexOf(expected, index + 1, comparer);
                }

                return indexes;
            }
            else
            {
                return [-1];
            }
        }
    }
}