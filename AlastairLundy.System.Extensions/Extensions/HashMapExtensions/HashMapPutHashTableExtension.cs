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

using AlastairLundy.System.Extensions.Types;

using System.Collections;


namespace AlastairLundy.System.Extensions.HashMapExtensions
{
    public static class HashMapPutHashTableExtension
    {

        /// <summary>
        /// Adds items in a HashTable to a HashMap.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="hashMap"></param>
        /// <param name="hashtable"></param>
        public static void PutHashTable<TKey, TValue>(this HashMap<TKey, TValue> hashMap, Hashtable hashtable)
        {
            ICollection keys = hashtable.Keys;
            ICollection values = hashtable.Values;

            bool sameSize = keys.Count == values.Count;

            TKey[] keyArray = new TKey[keys.Count];
            TValue[] valArray = new TValue[values.Count];

            values.CopyTo(valArray, 0);
            keys.CopyTo(keyArray, 0);

            if (sameSize)
            {
                for (int index = 0; index < keys.Count; index++)
                {
                    hashMap.Put(keyArray[index], valArray[index]);
                }
            }
        }
    }
}
