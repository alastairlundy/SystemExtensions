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
using AlastairLundy.Extensions.System.Collections;
using AlastairLundy.Extensions.System.Exceptions;

namespace AlastairLundy.Extensions.System.HashMapExtensions
{
    public static class HashMapGetKeyExtension
    {

        /// <summary>
        /// Gets the Key associated with the specified value to a HashMap.
        /// </summary>
        /// <typeparam name="TKey">The type of the Keys used.</typeparam>
        /// <typeparam name="TValue">The type of the Values used.</typeparam>
        /// <param name="hashMap">The HashMap to be added to.</param>
        /// <param name="value">The value to use to return the desired keys.</param>
        /// <returns>the key associated with the value in the HashMap. If more than one Key is associated with the value, only the first key is returned.</returns>
        /// <exception cref="ValueNotFoundException">An exception that is thrown if the specified Value is not found within the HashMap.</exception>
        public static TKey GetKey<TKey, TValue>(this HashMap<TKey, TValue> hashMap, TValue value)
        {
            if (hashMap.ContainsValue(value))
            {
                foreach (KeyValuePair<TKey, TValue> pair in hashMap.ToDictionary())
                {
                    if (pair.Value.Equals(value))
                    {
                        return pair.Key;
                    }
                }
            }

            throw new ValueNotFoundException(nameof(hashMap));
        }
    }
}
