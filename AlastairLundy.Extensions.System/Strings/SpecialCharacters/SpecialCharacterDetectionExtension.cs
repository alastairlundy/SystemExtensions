﻿/*
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

namespace AlastairLundy.Extensions.System.Strings.SpecialCharacters;

    public static class SpecialCharacterDetectionExtension
    {
        internal static readonly char[] SpecialCharacters =
            {',', '.', '\\', '/', '^', '*', '&', '?', '!', '#', '~', '_', '+', '-', '@', '<', '>', '=', '(', ')', '%', '$', '£', '"', ';', ':', '{', '}', '[', ']'};

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ContainsSpecialCharacter(this string s)
        {
            foreach (char c in s)
            {
                if (c.IsSpecialCharacter())
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Returns whether a character is a special character or not.
        /// </summary>
        /// <param name="c">The character to be checked.</param>
        /// <returns>true if the character is a special character, returns false otherwise.</returns>
        public static bool IsSpecialCharacter(this char c)
        {
            foreach (char ch in SpecialCharacters)
            {
                if (c.Equals(ch))
                {
                    return true;
                }
            }

            return false;
        }
    }