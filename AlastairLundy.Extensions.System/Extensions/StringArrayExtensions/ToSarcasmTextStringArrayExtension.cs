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

namespace AlastairLundy.Extensions.System.StringArrayExtensions
{
    public static class ToSarcasmTextStringArrayExtension
    {
        /// <summary>
        /// Takes an array of ordinary words and converts each one to sArCaSm Text.
        /// </summary>
        public static string ToSarcasmText(this string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var word in words)
            {
                char[] chars = word.ToCharArray();

                for (int index = 0; index < chars.Length; index++)
                {
                    stringBuilder.Append(index % 2 == 0
                        ? chars[index].ToString().ToUpper()
                        : chars[index].ToString().ToLower());
                }
            }

            return stringBuilder.ToString();
        }
    }
}