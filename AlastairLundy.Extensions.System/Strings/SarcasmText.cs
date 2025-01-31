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

using System.Collections.Generic;
using System.Linq;
using System.Text;

#if NETSTANDARD2_1 || NET8_0_OR_GREATER
#nullable enable
#endif

namespace AlastairLundy.Extensions.System.Strings
{
    public static class SarcasmText
    {
        /// <summary>
        /// Attempts to encode a string input from normal text to sArCaSm tExT.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <param name="output">The converted string if successful; null otherwise.</param>
        /// <returns>true if the conversion was successful; returns false otherwise.</returns>
#if NETSTANDARD2_1 || NET8_0_OR_GREATER
        public static bool TryEncode(string input, out string? output)
#else
        public static bool TryEncode(string input, out string output)
#endif
        {
            try
            {
                output = Encode(input);
                return true;
            }
            catch
            {
                output = null;
                return false;
            }
        }

        /// <summary>
        /// Attempts to decode a string input from sArCaSm tExT to normal text.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <param name="output">The converted string if successful; null otherwise.</param>
        /// <returns>true if the conversion was successful; returns false otherwise.</returns>
#if NETSTANDARD2_1 || NET8_0_OR_GREATER
        public static bool TryDecode(string input, out string? output)
#else
        public static bool TryDecode(string input, out string output)
#endif
        {
            try
            {
                output = Decode(input);
                return true;
            }
            catch
            {
                output = null;
                return false;
            }
        }

        /// <summary>
        /// Converts an IEnumerable of chars from normal text to sArCaSm tExT. 
        /// </summary>
        /// <param name="chars">The IEnumerable of chars to be converted.</param>
        /// <returns>the converted chars.</returns>
        public static IEnumerable<char> Encode(IEnumerable<char> chars)
        {
            char[] enumerable = chars as char[] ?? chars.ToArray();
            
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int index = 0; index < enumerable.Count(); index++)
            {
                stringBuilder.Append(index % 2 == 0
                    ? enumerable[index].ToString().ToUpper()
                    : enumerable[index].ToString().ToLower());
            }

            return stringBuilder.ToString().ToCharArray();
        }
        
        /// <summary>
        /// Converts a word in normal text to sArCaSm tExT.
        /// </summary>
        /// <param name="word">The word to be converted.</param>
        /// <returns>the converted word.</returns>
        public static string Encode(string word)
        {
            string[] words = word.Split(' ');

            StringBuilder stringBuilder = new StringBuilder();
            
            if (words.Length > 1)
            {
                foreach (string s in words)
                {
                    stringBuilder.Append(Encode(s.ToCharArray()));
                    stringBuilder.Append(' ');
                }
                
                return stringBuilder.ToString();
            }
            else
            {
                return Encode(word.ToCharArray()).ToString()!;
            }
        }
        
        /// <summary>
        /// Converts words in normal text to sArCaSm tExT.
        /// </summary>
        /// <param name="words">The IEnumerable of words to be converted.</param>
        /// <returns>the converted words.</returns>
        public static IEnumerable<string> Encode(IEnumerable<string> words)
        {
            string[] enumerable = words as string[] ?? words.ToArray();

            List<string> newWords = new List<string>();

            foreach (string word in enumerable)
            {
                newWords.Add(Encode(word));
            }

            return newWords.ToArray();
        }

        /// <summary>
        /// Converts an IEnumerable of chars in sArCaSm tExT to normal text.
        /// </summary>
        /// <param name="chars">The IEnumerable of chars to be converted.</param>
        /// <returns>the converted chars.</returns>
        public static IEnumerable<char> Decode(IEnumerable<char> chars)
        {
            char[] enumerable = chars as char[] ?? chars.ToArray();
            
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(char.Parse(enumerable[0].ToString().ToUpper()));
            
            for (int index = 1; index < enumerable.Count(); index++)
            {
                stringBuilder.Append(char.Parse(enumerable[index].ToString().ToLower()));
            }

            return stringBuilder.ToString().ToCharArray();
        }

        /// <summary>
        /// Converts a word in sArCaSm tExT to normal text.
        /// </summary>
        /// <param name="word">The word to be converted.</param>
        /// <returns>the converted word.</returns>
        public static string Decode(string word)
        {
            string[] words = word.Split(' ');
            
            if (words.Length > 1)
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (string newWord in words)
                {
                    stringBuilder.Append(Decode(newWord.ToCharArray()));
                    stringBuilder.Append(' ');
                }

                return stringBuilder.ToString();
            }
            else
            {
                return Decode(word.ToCharArray()).ToString()!;
            }
        }

        /// <summary>
        /// Converts words in sArCaSm tExT to normal text.
        /// </summary>
        /// <param name="words">The IEnumerable of words to be converted.</param>
        /// <returns>the converted words.</returns>
        public static IEnumerable<string> Decode(IEnumerable<string> words)
        {
            string[] enumerable = words as string[] ?? words.ToArray();

            string[] newEnumerable = new string[enumerable.Length];

            newEnumerable[0] = enumerable[0].Remove(0, 1);
            newEnumerable[0] = newEnumerable[0].Insert(0, enumerable[0][0].ToString().ToUpper());
            
            for (int index = 1; index < enumerable.Count(); index++)
            {
                newEnumerable[index] = Decode(enumerable[index]);
            }

            return newEnumerable;
        }
    }
}