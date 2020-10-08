/*
MIT License

Copyright (c) AluminiumTech 2018-2020

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

namespace AluminiumTech.DevKit.DeveloperKit
{
    /// <summary>
    /// A class to store hashed keys and values similar to how Java's HashMap works.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class HashMapV2<TKey, TValue>
    {
        protected List<KeyValuePair<TKey, TValue>> list;

        public HashMapV2()
        {
            list = new List<KeyValuePair<TKey, TValue>>();    
        }

        /// <summary>
        /// Imports an existing HashMapV2 object and creates a new one.
        /// </summary>
        /// <param name="hashMapV2"></param>
        public void ImportHashMapV2(HashMapV2<TKey, TValue> hashMapV2)
        {
            foreach (KeyValuePair<TKey,TValue> pairs in hashMapV2.list)
            {
                Add(pairs);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionary"></param>
        public void ImportDictionary(Dictionary<TKey, TValue> dictionary)
        {
            foreach (TKey k in dictionary.Keys)
            {
                KeyValuePair<TKey, TValue> pair = new KeyValuePair<TKey, TValue>(k, dictionary[k]);

                Add(pair);
            }
        }

        /// <summary>
        /// Adds a KeyValuePair to the HashMap.
        /// </summary>
        /// <param name="pair"></param>
        public void Add(KeyValuePair<TKey, TValue> pair)
        {
            list.Add(pair);
        }
        
        /// <summary>
        /// Adds a Key and a Value to the HashMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(TKey key, TValue value)
        {
            var pair = CreateKeyValuePair(key, value);
            Add(pair);
        }
        
        /// <summary>
        /// Gets the value associated with a key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public TValue GetValue(TKey key)
        {
            foreach (KeyValuePair<TKey, TValue> pairs in list)
            {
                if (pairs.Key.Equals(key))
                {
                    return pairs.Value;
                }
            }
            
            throw new KeyNotFoundException();
        }
        
        /// <summary>
        /// Gets the value associated with a key or returns a default value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public TValue GetValueOrDefault(TKey key, TValue defaultValue)
        {
            try
            {
                return GetValue(key);
            }
            catch
            {
                return defaultValue;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ValueNotFoundException"></exception>
        public TKey GetKey(TValue value)
        {
            foreach (KeyValuePair<TKey, TValue> pairs in list)
            {
                if (pairs.Value.Equals(value))
                {
                    return pairs.Key;
                }
            }
            
            throw new DeveloperKit.ValueNotFoundException();
        }
        
        /// <summary>
        /// Remove a KeyValuePair from the HashMap.
        /// </summary>
        /// <param name="pair"></param>
        public void Remove(KeyValuePair<TKey, TValue> pair)
        {
            list.Remove(pair);
        }
        
        /// <summary>
        /// Remove a Key and a Value from a HashMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Remove(TKey key, TValue value)
        {
            var pair = CreateKeyValuePair(key, value);
            Remove(pair);
        }
        
        /// <summary>
        /// Remove all instances of a Key in a HashMap.
        /// </summary>
        /// <param name="key"></param>
        public void Remove(TKey key)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index].Key.Equals(key))
                {
                    Remove(key, GetValue(key));
                }
            }
        }
        
        /// <summary>
        /// Remove all instances of a Value in a HashMap.
        /// </summary>
        /// <param name="value"></param>
        public void Remove(TValue value)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index].Value.Equals(value))
                {
                    Remove(GetKey(value), value);
                }
            }
        }
        
        /// <summary>
        /// Removals all Key Value Pairs from the list.
        /// </summary>
        public void RemoveAllPairs()
        {
            list.Clear();
        }
        
        /// <summary>
        /// Creates a key value pair and returns it.
        /// Note: This does not add it to the HashMapV2 object.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public KeyValuePair<TKey, TValue> CreateKeyValuePair(TKey key, TValue value)
        {
            KeyValuePair<TKey, TValue> pair = new KeyValuePair<TKey, TValue>(key, value);
            return pair;
        }
        
        /// <summary>
        /// Converts a HashMapV2 object to an array.
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<TKey, TValue>[] ToArray()
        {
            return list.ToArray();
        }
        
        /// <summary>
        /// Converts a HashMapV2 object to a C# List.
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<TKey, TValue>> ToList()
        {
            return list;
        }
        
        /// <summary>
        /// Converts a HashMapV2 object to a C# Dictionary.
        /// </summary>
        /// <returns></returns>
        public Dictionary<TKey, TValue> ToDictionary()
        {
            Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
            
            foreach (KeyValuePair<TKey, TValue> pairs in list)
            {
                dictionary.Add(pairs.Key, pairs.Value);
            }

            return dictionary;
        }
    }
}