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

namespace AlastairLundy.Extensions.Maths.Averages;

    /// <summary>
    /// A class to store mode calculation related code.
    /// </summary>
    public static class ModeExtensions
    {
        internal static IEnumerable<int> GetModeFrequencies(IEnumerable<int> values)
        {
            List<int> modeFrequencies = new List<int>();

            int[] descending = values.ToArray();
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
        internal static IEnumerable<T> GetModes<T>(IEnumerable<T> values)
        {
            List<T> mode = new List<T>();
            
            Dictionary<T, int> pairs = values.FrequencyOfAll();

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
        public static IEnumerable<double> Mode(this IEnumerable<double> values)
        {
            return GetModes(values);
        }
        
        /// <summary>
        /// Returns the mode of an array of decimals.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static IEnumerable<decimal> Mode(this IEnumerable<decimal> values)
        {
            return GetModes(values);
        }

        /// <summary>
        /// Returns the mode of an array of 64 Bit integers.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static IEnumerable<long> Mode(this IEnumerable<long> values)
        {
            return GetModes(values);
        }

        /// <summary>
        /// Returns the mode of an array of ints.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static IEnumerable<int> Mode(this IEnumerable<int> values)
        {
            return GetModes(values);
        }

        /// <summary>
        /// Returns the mode of an array of floats.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static IEnumerable<float> Mode(this IEnumerable<float> values)
        {
            return GetModes(values);
        }

        /// <summary>
        /// Returns the mode of an array of shorts.
        /// </summary>
        /// <param name="values">The array to determine the mode from.</param>
        /// <returns>the mode(s) of the specified array.</returns>
        public static IEnumerable<short> Mode(this IEnumerable<short> values)
        {
            return GetModes(values);
        }
    }