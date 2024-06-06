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
using System.Linq;
using AlastairLundy.Extensions.System.IEnumerableExtensions;

namespace AlastairLundy.Extensions.System.Collections
{
    /// <summary>
    /// 
    /// </summary>
    public static class ArrayCombiner
    {
        /// <summary>
        /// Combines an array with another array and returns the newly combined array.
        /// </summary>
        /// <param name="array">The array to be added to.</param>
        /// <param name="arrayToBeAdded">The array to be added.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>the newly combined arrays.</returns>
        /// <exception cref="OverflowException">Thrown if the size of the new array is larger than the max size for Arrays.</exception>
        [Obsolete]
        public static T[] Combine<T>(this T[] array, T[] arrayToBeAdded)
        {
            return CombineIEnumerableExtension.Combine(array, arrayToBeAdded).ToArray();
        }
        
        /// <summary>
        /// Combines 2 arrays and outputs the newly combined array.
        /// </summary>
        /// <param name="arrayA">The first array to be combined.</param>
        /// <param name="arrayB">The second array to be combined.</param>
        /// <param name="destinationArray">The combined arrays returned to this variable.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <exception cref="OverflowException">Thrown if the size of the new array is larger than the max size for Arrays.</exception>
        [Obsolete]
        public static void Combine<T>(T[] arrayA, T[] arrayB, out T[] destinationArray)
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (arrayA.Length + arrayB.Length > int.MaxValue)
            {
                throw new OverflowException();
            }
            
            T[] newArray = new T[arrayA.Length + arrayB.Length];
            arrayA.CopyTo(newArray, 0);
            arrayB.CopyTo(newArray, arrayA.Length);

            destinationArray = newArray;
        }
    }
}