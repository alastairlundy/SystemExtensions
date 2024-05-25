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

namespace AlastairLundy.Extensions.System.ArrayExtensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ArrayCombiner
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayToBeAdded"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="OverflowException"></exception>
        public static T[] Combine<T>(this T[] array, T[] arrayToBeAdded)
        {
#if NET6_0_OR_GREATER
            if (array.Length + arrayToBeAdded.Length > Array.MaxLength)
#else
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if(array.Length + arrayToBeAdded.Length > int.MaxValue)
#endif
            {

                throw new OverflowException();
            }
            
            T[] newArray = new T[array.Length + arrayToBeAdded.Length];
            
            array.CopyTo(newArray, 0);
            arrayToBeAdded.CopyTo(newArray, array.Length);

            return newArray;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayA"></param>
        /// <param name="arrayB"></param>
        /// <param name="destinationArray"></param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="OverflowException"></exception>
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