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
        /// Gets the Key associated with the specified value in the HashMap.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="hashmap"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ValueNotFoundException"></exception>
        public static TKey GetKey<TKey, TValue>(this HashMap<TKey, TValue> hashmap, TValue value)
        {
            if (hashmap.ContainsValue(value))
            {
                foreach (KeyValuePair<TKey, TValue> pair in hashmap.ToDictionary())
                {
                    if (pair.Value.Equals(value))
                    {
                        return pair.Key;
                    }
                }
            }

            throw new ValueNotFoundException(nameof(hashmap));
        }
    }
}
