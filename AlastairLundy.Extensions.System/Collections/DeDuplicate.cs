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
using System.Collections.Generic;
using System.Linq;

namespace AlastairLundy.Extensions.System.Collections
{
    /// <summary>
    /// 
    /// </summary>
    public class DeDuplicate
    {
        /// <summary>
        /// Whether duplicates of an object exist in a ICollection.
        /// </summary>
        /// <param name="collection"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>true if duplicates are found in the ICollection; returns false otherwise.</returns>
        public static bool FoundDuplicate<T>(IEnumerable<T> collection)
        {
            Dictionary<T, int> frequency = FrequencyOf.Objects(collection);

            foreach (int frequencyValue in frequency.Values)
            {
                if (frequencyValue > 1)
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumerable"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static IEnumerable<T> FromCollection<T>(IEnumerable<T> enumerable)
        {
            Dictionary<T, int> frequency = FrequencyOf.Objects(enumerable);

            if (frequency.Keys.Count == 0 || frequency.Keys.Count < 1)
            {
                throw new NullReferenceException();
            }
            
            return frequency.Keys.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collectionToBeDeDuplicated"></param>
        /// <param name="destinationCollection"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool TryFromCollection<T>(IEnumerable<T> collectionToBeDeDuplicated, out IEnumerable<T> destinationCollection)
        {
            T[] toBeDeDuplicated = collectionToBeDeDuplicated as T[] ?? collectionToBeDeDuplicated.ToArray();
            
            if (!FoundDuplicate(toBeDeDuplicated))
            {
                destinationCollection = toBeDeDuplicated;
                return false;
            }

            destinationCollection = FromCollection(toBeDeDuplicated);
            return true;
        }
    }
}