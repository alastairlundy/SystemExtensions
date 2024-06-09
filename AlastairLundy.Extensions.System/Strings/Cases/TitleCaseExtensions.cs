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

using System.Text;

namespace AlastairLundy.Extensions.System
{
    public static class TitleCaseExtensions
    {
        /// <summary>
        /// Checks whether a word is capitalized.
        /// </summary>
        /// <param name="word">The word to be checked.</param>
        /// <returns>true if the word is capitalized; returns false otherwise.</returns>
        public static bool IsWordTitleCase(this string word)
        {
            string[] letters = word.Split();
            bool[] letterCapitalization = new bool[letters.Length];

            letterCapitalization[0] = letters[0].IsUpperCaseLetter();
            
            for (int index = 1; index < letters.Length; index++)
            {
                letterCapitalization[index] = letters[index].IsLowerCaseLetter();
            }

            return letterCapitalization.IsAllTrue();
        }
        
        /// <summary>
        /// Converts a regular string to a Title Case String Like This.
        /// </summary>
        /// <param name="words">The array of strings to be converted.</param>
        /// <returns>the converted title case string.</returns>
        public static string ToTitleCase(this string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int index = 0; index < words.Length; index++)
            {
                if (words[index].IsWordTitleCase())
                {
                    stringBuilder.Append(words[index]);
                }
                else
                {
                    stringBuilder.Append(words[index].CapitalizeFirstLetter());
                }
            }

            return stringBuilder.ToString();
        }
        
        /// <summary>
        /// Returns whether the specified phrase to be checked is in Title Case or not.
        /// </summary>
        /// <param name="phrase">The phrase to be checked.</param>
        /// <returns>true if the specified phrase is in Title Case; returns false otherwise.</returns>
        public static bool IsTitleCase(this string phrase)
        {
            string[] words = phrase.Split();
            
            bool[] results = new bool[words.Length];
            
            for (int index = 0; index < words.Length; index++)
            {
                results[index] = words[index].IsWordTitleCase();
            }
            
            return results.IsAllTrue();
        }
    }
}