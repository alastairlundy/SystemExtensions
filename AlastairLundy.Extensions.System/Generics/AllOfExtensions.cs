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

// ReSharper disable RedundantBoolCompare

namespace AlastairLundy.Extensions.System.Generics
{
    public static class AllOfExtensions
    {
        /// <summary>
        /// Returns whether an item of type T contains all the specified possible values
        /// </summary>
        /// <param name="source">The item to be searched.</param>
        /// <param name="possibleValues">The possible values to search for.</param>
        /// <typeparam name="T">The type of object of the item to be searched.</typeparam>
        /// <returns>true if all the possibles values is contained in the source; returns false otherwise.</returns>
        public static bool ContainsAllOf<T>(this T source, IEnumerable<T> possibleValues)
        {
            bool output = false;

            bool hasContainsMethod = typeof(T).GetMember("Contains").Any();
        
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
#if NETSTANDARD2_1 || NET8_OR_GREATER
                        bool result = (bool)typeof(T)!.InvokeMember("Contains",
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, possibleValue,
                            new object[] { source })!;
#else
                        bool result = (bool)typeof(T).InvokeMember("Contains",
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null, possibleValue,
                            new object[] { source });
#endif

                        if (result == true)
                        {
                            output = true;
                        }
                    }
                    // ReSharper disable once EmptyGeneralCatchClause
                    catch
                    {
                    
                    }
                }
            }
        
            return output;
        }
    
        /// <summary>
        /// Returns whether an item of type T is equal to all the specified possible values
        /// </summary>
        /// <param name="source">The item to be searched.</param>
        /// <param name="possibleValues">The possible values to search for.</param>
        /// <typeparam name="T">The type of object of the item to be searched.</typeparam>
        /// <returns>true if all the possibles values is equal to the source; returns false otherwise.</returns>
        public static bool EqualsAllOf<T>(this T source, IEnumerable<T> possibleValues)
        {
            // ReSharper disable once RedundantBoolCompare
            return possibleValues.Select(t => source.Equals(t)).All(hasValue => hasValue == true);
        }
    }
}