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
using System.Linq;
using System.Reflection;

using AlastairLundy.Extensions.System.Strings.Contains;
// ReSharper disable RedundantBoolCompare

namespace AlastairLundy.Extensions.System.Generics
{
    public static class GenericsAnyOfExtensions
    {
        /// <summary>
        /// Returns whether an item of type T contains any of the specified possible values
        /// </summary>
        /// <param name="source">The item to be searched.</param>
        /// <param name="possibleValues">The possible values to search for.</param>
        /// <typeparam name="T">The type of object of the item to be searched.</typeparam>
        /// <returns>true if any of the possibles values is contained in the source; returns false otherwise.</returns>
        public static bool ContainsAnyOf<T>(this T source, IEnumerable<T> possibleValues)
        {
            bool output = false;

            bool hasContainsMethod = typeof(T).GetMember("Contains").Any();

            if (typeof(T) == typeof(string))
            {
                return StringAnyOfExtensions.ContainsAnyOf(source as string, possibleValues as IEnumerable<string>);
            }
        
            foreach (T possibleValue in possibleValues)
            {
                if (source.Equals(possibleValue))
                {
                    return true;
                }
            
                if (hasContainsMethod == true)
                {
                    try
                    {
                        bool result = (bool)typeof(T)!.InvokeMember("Contains",
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, possibleValue,
                            new object[] { source })!;

                        if (result == true)
                        {
                            output = true;
                        }
                    }
                    catch
                    {
                    
                    }
                }
            }
        
            return output;
        }

        /// <summary>
        /// Returns whether an item of type T is equal to any of the specified possible values
        /// </summary>
        /// <param name="source">The item to be searched.</param>
        /// <param name="possibleValues">The possible values to search for.</param>
        /// <typeparam name="T">The type of object of the item to be searched.</typeparam>
        /// <returns>true if any of the possibles values is equal to the source; returns false otherwise.</returns>
        public static bool EqualsAnyOf<T>(this T source, IEnumerable<T> possibleValues)
        {
            return possibleValues.Select(t => source.Equals(t)).Any(containsValue => containsValue == true);
        }
    }
}