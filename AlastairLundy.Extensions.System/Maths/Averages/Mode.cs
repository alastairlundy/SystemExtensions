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

using AlastairLundy.Extensions.System.DictionaryExtensions;

namespace AlastairLundy.Extensions.System.Maths.Averages
{
    /// <summary>
    /// A class to store mode calculation related code.
    /// </summary>
    public class Mode
    {
        internal static Dictionary<TKey, long> CountUsage<TKey>(TKey[] values)
        {
            Dictionary<TKey, long> pairs = new Dictionary<TKey, long>();
            
            foreach(TKey value in values)
            {
                if (pairs.ContainsKey(value))
                {
                    pairs[value] += 1;
                }
                else
                {
                    pairs.Add(value, 1);
                }
            }

            return pairs;
        }

        internal static int[] GetModeFrequencies(int[] values)
        {
            List<int> modeFrequencies = new List<int>();

            int[] descending = values;
            Array.Sort(descending);
            Array.Reverse(descending);
            
            modeFrequencies.Add(descending[0]);
            
            for(int index = 0; index < descending.Length; index++)
            {
                int next = descending[index + 1] < descending.Length ? descending[index + 1] : descending[index];
                
                if (!descending[index].Equals(next))
                {
                    if (descending[index] == descending[0])
                    {
                        modeFrequencies.Add(descending[index]);
                    }
                }
            }

            return modeFrequencies.ToArray();
        }
        
        /// <summary>
        /// Gets the modes for a list of objects (presumably numbers).
        /// </summary>
        /// <param name="values"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        internal static T[] GetModes<T>(T[] values)
        {
            List<T> mode = new List<T>();
            
            Dictionary<T, int> pairs = FrequencyOf.Objects(values);

            foreach (int modeFrequency in GetModeFrequencies(pairs.Values.ToArray()))
            {
                foreach (T key in pairs.GetKeys(modeFrequency))
                {
                    mode.Add(key);
                }
            }

            return mode.ToArray();
        }
        
        /// <summary>
        /// Returns the mode of an array of doubles.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static double[] OfDoubles(double[] values)
        {
            return GetModes<double>(values);
        }
        
        /// <summary>
        /// Returns the mode of an array of decimals.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static decimal[] OfDecimals(decimal[] values)
        {
            return GetModes<decimal>(values);
        }

        /// <summary>
        /// Returns the mode of an array of 64 Bit integers.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static long[] OfLongs(long[] values)
        {
            return GetModes<long>(values);
        }

        /// <summary>
        /// Returns the mode of an array of ints.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static int[] OfInts(int[] values)
        {
            return GetModes<int>(values);
        }

        /// <summary>
        /// Returns the mode of an array of floats.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static float[] OfFloats(float[] values)
        {
            return GetModes<float>(values);
        }
    }
}