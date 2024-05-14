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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using AlastairLundy.Extensions.System.Collections;
using AlastairLundy.Extensions.System.DictionaryExtensions;
using AlastairLundy.Extensions.System.Exceptions;

namespace AlastairLundy.Extensions.System.HashMapExtensions
{
    public static class HashMapGetAllKeysExtension
    {
        /// <summary>
        /// Returns all keys associated with a specified value in a HashMap.
        /// </summary>
        /// <typeparam name="TKey">The type of Key in the HashMap.</typeparam>
        /// <typeparam name="TValue">The type of Value in the HashMap.</typeparam>
        /// <param name="hashMap">The HashMap to be searched.</param>
        /// <param name="value">The value to search for.</param>
        /// <exception cref="ValueNotFoundException">An exception that is thrown if the value is not found within the HashMap.</exception>
        /// <returns>the keys associated with the specified value in the HashMap.</returns>
        public static TKey[] GetKeys<TKey, TValue>(this HashMap<TKey, TValue> hashMap, TValue value)
        {
            if(hashMap.ContainsValue(value))
            {
                return hashMap.ToDictionary().GetKeys(value);
            }

            throw new ValueNotFoundException(nameof(hashMap));
        }
    }
}