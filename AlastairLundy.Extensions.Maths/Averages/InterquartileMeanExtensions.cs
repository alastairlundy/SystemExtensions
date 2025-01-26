/*
        MIT License
       
       Copyright (c) 2024-2025 Alastair Lundy
       
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

using System.Collections;

namespace AlastairLundy.Extensions.Maths.Averages;

    // ReSharper disable once UnusedType.Global
    public static class InterquartileMeanExtensions
    {
        private static IEnumerable<T> RemoveUnneededQuartiles<T>(IEnumerable<T> values)
        {
            T[] enumerable = values as T[] ?? values.ToArray();
            Array.Sort(enumerable);

            int quartileSize = enumerable.Length / 4;
            
                List<T> list = new List<T>();

                for (int index = 0; index < enumerable.Length; index++)
                {
                    if (index < (quartileSize - 1) || Math.Abs(enumerable.Length - index) < (quartileSize - 1))
                    {
                        //Do nothing
                    }
                    else
                    {
                        list.Add(enumerable[index]);
                    }
                }

                return list.ToArray();
        }

        private static IEnumerable<T> GetFractionalObservanceValues<T>(int numberOfValues, T[] values)
        {
            Array.Sort(values);

            List<T> list = new List<T>();
            List<T> newList = new List<T>();

            int numberRemoved = 0;

            foreach (T value in values)
            {
                list.Add(value);
            }

            bool removeUpperNumber = false;
            while (numberRemoved != numberOfValues)
            {
                if (removeUpperNumber)
                {
                    newList.Add(list[^1]);
                    list.RemoveAt(list.Count - 1);
                    removeUpperNumber = false;
                }
                else
                {
                    newList.Add(list[0]);
                    list.RemoveAt(0);
                    removeUpperNumber = true;
                }
                
                numberRemoved++;
            }

            return newList.ToArray();
        }
        
        internal static T[] Remove<T>(int numberOfValuesToRemove, T[] values)
        {
            List<T> newValues = new List<T>();
            
            Array.Sort(values);
            
            T[] toBeRemoved = GetFractionalObservanceValues(numberOfValuesToRemove, values).ToArray();

            foreach (T value in values)
            {
                newValues.Add(value);
            }
            
            foreach (var removable in toBeRemoved)
            {
                newValues.Remove(removable);
            }

            return newValues.ToArray();
        }
        
        /// <summary>
        /// Returns the Interquartile Mean of an array of decimals.
        /// </summary>
        /// <param name="values">The array to get the Interquartile Mean of.</param>
        /// <returns>The Interquartile Mean of the specified decimal array.</returns>
        public static decimal InterquartileMean(this IEnumerable<decimal> values)
        {
            decimal[] enumerable = values as decimal[] ?? values.ToArray();
            
            decimal[] newValues = RemoveUnneededQuartiles(enumerable).ToArray();

            if (enumerable.Length % 2 == 0)
            {
                return newValues.ArithmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                int normalQuartile = enumerable.Length / 4;
                double actualQuartile = enumerable.Length / 4.0;

                double fractionalObservation = actualQuartile - Convert.ToDouble(normalQuartile);
                fractionalObservation = 1.0 - fractionalObservation;

                decimal fractionalObersvationValues = decimal.Zero;

                foreach (decimal removable in Remove(normalQuartile, newValues))
                {
                    fractionalObersvationValues = decimal.Add(fractionalObersvationValues, removable);
                }

                fractionalObersvationValues =
                    decimal.Multiply(Convert.ToDecimal(fractionalObservation), fractionalObersvationValues);

                decimal fullObservationValues = decimal.Zero;
                
                foreach (decimal newValue in newValues)
                {
                    if (newValue.Equals(newValues.First()) || newValue.Equals(newValues.Last()))
                    {
                        //Do nothing
                    }
                    else
                    {
                        fullObservationValues = decimal.Add(fullObservationValues, newValue);
                    }
                }

                decimal interquartileMean = decimal.Add(fractionalObersvationValues, fullObservationValues);

                decimal observances = decimal.Multiply(decimal.One,
                    decimal.Subtract(Convert.ToDecimal(newValues.Length), Convert.ToDecimal(fractionalObservation)));

                observances = decimal.Add(observances,
                    decimal.Multiply(
                        decimal.Subtract(Convert.ToDecimal(actualQuartile),
                            Convert.ToDecimal(normalQuartile)),
                        Convert.ToDecimal(Remove(Convert.ToInt32(fractionalObservation),
                            newValues).Length)));
                
                return decimal.Divide(interquartileMean, observances);
            }
        }

        /// <summary>
        /// Returns the Interquartile Mean of an array of doubles.
        /// </summary>
        /// <param name="values">The array to get the Interquartile Mean of.</param>
        /// <returns>the Interquartile Mean of the specified double array.</returns>
        public static double InterquartileMean(this IEnumerable<double> values)
        {
            double[] enumerable = values as double[] ?? values.ToArray();
            double[] newValues = RemoveUnneededQuartiles(enumerable).ToArray();

            if (enumerable.Length % 2 == 0)
            {
                return newValues.ArithmeticMean();
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                int normalQuartile = enumerable.Length / 4;
                double actualQuartile = enumerable.Length / 4.0;

                double fractionalObservation = actualQuartile - Convert.ToDouble(normalQuartile);
                fractionalObservation = 1.0 - fractionalObservation;

                double fractionalObersvationValues = 0.0;

                foreach (double removable in Remove(normalQuartile, newValues))
                {
                    fractionalObersvationValues += removable;
                }

                fractionalObersvationValues = fractionalObservation * fractionalObersvationValues;

                double fullObservationValues = 0.0;
                
                foreach (double newValue in newValues)
                {
                    if (newValue.Equals(newValues.First()) || newValue.Equals(newValues.Last()))
                    {
                        //Do nothing
                    }
                    else
                    {
                        fullObservationValues += newValue;
                    }
                }

                double interquartileMean = fractionalObersvationValues + fullObservationValues;

                double observances = 1.0 * (Convert.ToDouble(newValues.Length)) - fractionalObservation;

                observances += ((actualQuartile - Convert.ToDouble(normalQuartile)) *
                               Convert.ToInt32(Remove(Convert.ToInt32(fractionalObservation), newValues).Length));
                
                return interquartileMean / observances;
            }
        }
    }