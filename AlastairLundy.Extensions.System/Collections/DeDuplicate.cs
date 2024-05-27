using System.Collections.Generic;

namespace AlastairLundy.Extensions.System.Collections
{
    public class DeDuplicate
    {
        /// <summary>
        /// Whether duplicates of an object exist in a ICollection.
        /// </summary>
        /// <param name="collection"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>true if duplicates are found in the ICollection; returns false otherwise.</returns>
        public static bool FoundDuplicates<T>(ICollection<T> collection)
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
        
        public static ICollection<T> FromCollection<T>(ICollection<T> collection)
        {
            
        }

        public static bool FromCollection<T>(ICollection<T> collectionToBeDeDuplicated, out ICollection<T> destinationCollection)
        {
            
        }
    }
}