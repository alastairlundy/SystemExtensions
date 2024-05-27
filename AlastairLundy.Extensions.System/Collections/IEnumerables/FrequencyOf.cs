using System.Collections.Generic;

namespace AlastairLundy.Extensions.System.Collections
{
    public static class FrequencyOf
    {
        /// <summary>
        ///  Caculates the number of times an object appears in an IEnumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="obj"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>the number of times the object appears in the IEnumerable.</returns>
        public static int Object<T>(IEnumerable<T> enumerable, T obj)
        {
            int frequency = 0;

            foreach (T item in enumerable)
            {
                if (item.Equals(obj))
                {
                    frequency++;
                }
            }

            return frequency;
        }
        
        /// <summary>
        /// Caculates the number of times objects appears in an IEnumerable.
        /// </summary>
        /// <param name="enumerable">The IEnumerable to be searched.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<T, int> Objects<T>(IEnumerable<T> enumerable)
        {
            Dictionary<T, int> items = new Dictionary<T, int>();

            foreach (T item in enumerable)
            {
                if (items.ContainsKey(item))
                {
                    items[item] += 1;
                }
                else
                {
                    items.Add(item, 1);
                }
            }

            return items;
        }
    }
}