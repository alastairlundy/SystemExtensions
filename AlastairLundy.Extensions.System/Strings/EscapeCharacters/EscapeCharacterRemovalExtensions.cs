﻿/*
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

// ReSharper disable CheckNamespace

using System.Linq;
using AlastairLundy.Extensions.System.Generics;

namespace AlastairLundy.Extensions.System.Strings
{
    public static class EscapeCharacterRemovalExtensions
    {
        /// <summary>
        /// Returns whether the string contains an Escape Character.
        /// </summary>
        /// <param name="str">The string to be searched.</param>
        /// <returns>true if the string contains an Escape Character; returns false otherwise.</returns>
        public static bool ContainsEscapeCharacters(this string str)
        {
            return CharacterConstants.EscapeCharacters.Any(x => x.Equals(str));
        }
        
        /// <summary>
        /// Removes escape characters from a string.
        /// </summary>
        /// <param name="str">The string to be searched.</param>
        /// <returns>the modified string if one or more escape characters were found; returns the original string otherwise.</returns>
        public static string RemoveEscapeCharacters(this string str)
        {
            string newStr = str;
                
            if (ContainsEscapeCharacters(str))
            {
                foreach (string escapeChar in CharacterConstants.EscapeCharacters)
                {
                    if (newStr.Contains(escapeChar))
                    {
                        newStr = newStr.Replace(escapeChar, string.Empty);
                    }
                }
            }

            return newStr;
        }
    }
}