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

namespace AlastairLundy.Extensions.System.StringExtensions
{
    public static class UpperCaseStringDetectionExtension
    {
        /// <summary>
        /// Returns whether a character, represented as a string, is an upper case letter or not.
        /// </summary>
        /// <param name="s">The string to be checked.</param>
        /// <returns>true if a character, represented as a string, is upper case; returns false otherwise.</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static bool IsUpperCaseLetter(this string s)
        {
            string[] englishAlphabetLower =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
                "v", "w", "x", "y", "z"
            };
            
            foreach (string abc in englishAlphabetLower)
            {
                if (abc.Equals(s.ToUpper()))
                {
                    //Get out of the for loop if the character matches.
                    return true;
                }
            }

            return false;
        }
    }
}