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
using System.Collections;
using System.Collections.Generic;

using AlastairLundy.System.Extensions.Exceptions;

namespace AlastairLundy.System.Extensions.Types
{
    /// <summary>
    /// A class to store hashed keys and values similar to how Java's HashMap works.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class HashMap<TKey, TValue>
    {
           // ReSharper disable once FieldCanBeMadeReadOnly.Global
        protected List<KeyValuePair<TKey, TValue>> KeyValuePairs;

        public HashMap()
        {
            KeyValuePairs = new List<KeyValuePair<TKey, TValue>>();
        }
        
        /// <summary>
        /// Gets the number of elements in the HashMap.
        /// </summary>
        public int Size => KeyValuePairs.Count;

        /// <summary>
        /// Imports an existing HashMap object and creates a new one.
        /// </summary>
        /// <param name="hashMap"></param>
        public void ImportHashMap(HashMap<TKey, TValue> hashMap)
        {
            ImportList(hashMap.ToList());
        }

        /// <summary>
        /// Adds items in a list to the HashMap
        /// </summary>
        /// <param name="list"></param>
        public void ImportList(List<KeyValuePair<TKey, TValue>> list)
        {
            ImportArray(list.ToArray());   
        }

        /// <summary>
        /// Adds items in an array to the HashMap.
        /// </summary>
        /// <param name="array"></param>
        public void ImportArray(KeyValuePair<TKey, TValue>[] array)
        {
            foreach (KeyValuePair<TKey,TValue> pairs in array)
            {
                Put(pairs);
            }
        }

        /// <summary>
        /// Adds items in a HashTable to the HashMap
        /// </summary>
        /// <param name="hashtable"></param>
        public void ImportHashtable(Hashtable hashtable)
        {
            var keys = hashtable.Keys;
            var values = hashtable.Values;

            var sameSize = keys.Count == values.Count;

            TKey[] keyArray = new TKey[keys.Count];
            TValue[] valArray = new TValue[values.Count];

            values.CopyTo(valArray, 0);
            keys.CopyTo(keyArray,0);

            if (sameSize)
            {
                for (int index = 0; index < keys.Count; index++)
                {
                    Put(new KeyValuePair<TKey, TValue>(keyArray[index], valArray[index]));
                }
            }
        }

        /// <summary>
        /// Adds items in a dictionary to a HashMap.
        /// </summary>
        /// <param name="dictionary"></param>
        public void ImportDictionary(Dictionary<TKey, TValue> dictionary)
        {
            foreach (TKey key in dictionary.Keys)
            {
                Put(new KeyValuePair<TKey, TValue>(key, dictionary[key]));
            }
        }

        /// <summary>
        /// Adds a KeyValuePair to the HashMap.
        /// </summary>
        /// <param name="pair"></param>
        public void Put(KeyValuePair<TKey, TValue> pair)
        {
            KeyValuePairs.Add(pair);
        }
        
        /// <summary>
        /// Adds a Key and a Value to the HashMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Put(TKey key, TValue value)
        {
            Put(new KeyValuePair<TKey, TValue>(key, value));
        }

        /// <summary>
        /// Puts the Key and associated Value into the HashMap if the Key is not already present in the HashMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void PutIfAbsent(TKey key, TValue value)
        {
            PutIfAbsent(new KeyValuePair<TKey, TValue>(key, value));
        }

        /// <summary>
        ///  Puts the KeyValuePair into the HashMap if the Key is not already present in the HashMap.
        /// </summary>
        /// <param name="pair"></param>
        public void PutIfAbsent(KeyValuePair<TKey, TValue> pair)
        {
            if (!ContainsKey(pair.Key))
            {
                Put(pair);
            }
        }

        /// <summary>
        /// Gets the value associated with a key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public TValue GetValue(TKey key)
        {
                if (ContainsKey(key))
                {
                    foreach (KeyValuePair<TKey, TValue> pairs in KeyValuePairs)
                    {
                        if (pairs.Key.Equals(key))
                        {
                            return pairs.Value;
                        }
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
        /// Returns an array of keys associated with the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ValueNotFoundException"></exception>
        public TKey[] GetKeys(TValue value)
        {
                List<TKey> keys = new List<TKey>();
                
                if (ContainsValue(value))
                {
                    foreach (KeyValuePair<TKey, TValue> pairs in KeyValuePairs)
                    {
                        if (pairs.Value.Equals(value))
                        {
                            keys.Add(pairs.Key);
                        }
                    }
                }

                if (keys.Count > 0)
                {
                    return keys.ToArray();
                }
                else
                {
                    throw new ValueNotFoundException(nameof(KeyValuePairs));
                }
        }
        
        /// <summary>
        /// Remove a KeyValuePair from the HashMap.
        /// </summary>
        /// <param name="pair"></param>
        public void Remove(KeyValuePair<TKey, TValue> pair)
        {
            if (KeyValuePairs.Count > 0)
            {
                if (ContainsKeyValuePair(pair))
                {
                    KeyValuePairs.Remove(pair);
                }

                throw new KeyValuePairNotFoundException(nameof(KeyValuePairs));
            }

            throw new NullReferenceException();
        }

        /// <summary>
        /// Remove a Key in a HashMap.
        /// </summary>
        /// <param name="key"></param>
        public void Remove(TKey key)
        {
            if (KeyValuePairs.Count > 0)
                {
                    if (ContainsKey(key))
                    {
                        // ReSharper disable once ForCanBeConvertedToForeach
                        for (int index = 0; index < KeyValuePairs.Count; index++)
                        {
                            if (KeyValuePairs[index].Key.Equals(key))
                            {
                                Remove(KeyValuePairs[index]);
                            }
                        }
                    }

                    throw new KeyNotFoundException();
                }

            throw new NullReferenceException();
        }
        
        /// <summary>
        /// Remove all instances of a Value in a HashMap.
        /// </summary>
        /// <param name="value"></param>
        public void RemoveAllInstancesOf(TValue value)
        {
                if (ContainsValue(value))
                {
                    var itemsToRemove = GetKeys(value);
                    
                    // ReSharper disable once ForCanBeConvertedToForeach
                    for (int index = 0; index < itemsToRemove.Length; index++)
                    {
                       Remove(itemsToRemove[index]);
                    }
                }

                throw new ValueNotFoundException(nameof(KeyValuePairs));
        }

        /// <summary>
        /// Replaces the value of a key value pair if the existing value of the key value pair is not null.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="Exception"></exception>
        public void Replace(TKey key, TValue value)
        {
                if (ContainsKey(key))
                {
                    for (int index = 0; index < KeyValuePairs.Count; index++)
                    {
                        if (KeyValuePairs[index].Value == null)
                        {
                            KeyValuePairs[index] = new KeyValuePair<TKey, TValue>(key, value);
                        }
                    }
                }

                throw new KeyNotFoundException();
        }
        
        /// <summary>
        /// Replaces the old value if it is associated with the key and replace it with the new value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <exception cref="ValueNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="Exception"></exception>
        public void Replace(TKey key, TValue oldValue, TValue newValue)
        {
                if (ContainsKey(key))
                {
                    if (ContainsValue(oldValue)){
                        for (int index = 0; index < KeyValuePairs.Count; index++)
                        {
                            if (KeyValuePairs[index].Key.Equals(key))
                            {
                                KeyValuePairs[index] = new KeyValuePair<TKey, TValue>(key, newValue);
                            }
                        }
                    }

                    throw new ValueNotFoundException(nameof(KeyValuePairs));
                }

                throw new KeyNotFoundException();
        }
        
        /// <summary>
        /// Removals all Key Value Pairs from the list.
        /// </summary>
        public void Clear()
        {
            KeyValuePairs.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pair"></param>
        /// <returns></returns>
        /// <exception cref="KeyValuePairNotFoundException"></exception>
        public int IndexOf(KeyValuePair<TKey, TValue> pair)
        {
            if (ContainsKeyValuePair(pair))
            {
                for (int index = 0; index < KeyValuePairs.Count; index++)
                {
                    if (KeyValuePairs[index].Equals(pair))
                    {
                        return index;
                    }
                }
            }

            throw new KeyValuePairNotFoundException(nameof(KeyValuePairs));
        }

        /// <summary>
        ///  Gets the index of the Key associated with the KeyValuePair in the internal KeyValuePair List.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public int IndexOf(TKey key)
        {
            if (ContainsKey(key))
            {
                for (int index = 0; index < KeyValuePairs.Count; index++)
                {
                    if (KeyValuePairs[index].Key.Equals(key))
                    {
                        return index;
                    }
                }
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// Returns an array of KeyValuePair objects where the specified value is found.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ValueNotFoundException"></exception>
        public KeyValuePair<TKey, TValue>[] InstancesOf(TValue value)
        {
            List<KeyValuePair<TKey, TValue>> instances = new List<KeyValuePair<TKey, TValue>>();

            foreach (var pair in KeyValuePairs)
            {
                if (pair.Value.Equals(value))
                {
                    instances.Add(pair);
                }
            }

            if (instances.Count > 0)
            {
                return instances.ToArray();
            }

            throw new ValueNotFoundException(nameof(KeyValuePairs));
        }

        /// <summary>
        /// Converts a HashMap object to an array.
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<TKey, TValue>[] ToArray()
        {
            return KeyValuePairs.ToArray();
        }
        
        /// <summary>
        /// Converts a HashMap object to a C# List.
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<TKey, TValue>> ToList()
        {
            return KeyValuePairs;
        }
        
        /// <summary>
        /// Converts a HashMap object to a C# Dictionary.
        /// </summary>
        /// <returns></returns>
        public Dictionary<TKey, TValue> ToDictionary()
        {
            Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
            
            foreach (KeyValuePair<TKey, TValue> pairs in KeyValuePairs)
            {
                dictionary.Add(pairs.Key, pairs.Value);
            }

            return dictionary;
        }

        /// <summary>
        /// Returns whether the hashmap contains the specified key. 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(TKey key)
        {
            foreach (var pair in KeyValuePairs)
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns whether the hashmap contains the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ContainsValue(TValue value)
        {
            foreach (var pair in KeyValuePairs)
            {
                if (pair.Value.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks to see if a specified Key Value Pair exists in the HashMap.
        /// This works by checking to see if a Key is in the HashMap and whether that Key is associated with the specified value.
        /// </summary>
        /// <param name="pair">The KeyValuePair to compare against this HashMap.</param>
        /// <returns>Returns whether or not the specified Key Value Pair exists in the HashMap as a bool. True means it exists and False means it does not exist.</returns>
        /// <exception cref="ValueNotFoundException">This exception is thrown when the Value does not exist in the HashMap regardless of what the key is.</exception>
        /// <exception cref="KeyNotFoundException">This exception is thrown when the HashMap does not contain the Key specified.</exception>
        public bool ContainsKeyValuePair(KeyValuePair<TKey, TValue> pair)
        {
            if (ContainsKey(pair.Key))
            {
                if (ContainsValue(pair.Value))
                {
                    return GetValue(pair.Key).Equals(pair.Value);
                }

                throw new ValueNotFoundException(nameof(KeyValuePairs));
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// Checks to see whether a HashMap is equals to another hashmap.
        /// </summary>
        /// <param name="hashMap"></param>
        /// <returns></returns>
        public bool Equals(HashMap<TKey, TValue> hashMap)
        {
            foreach (var pair in hashMap.ToList())
            {
                if (!ContainsKeyValuePair(pair))
                {
                    return false;
                }
                else if (ContainsKeyValuePair(pair))
                {
                    if (!pair.Value.Equals(GetValue(pair.Key)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Returns whether the hashmap is empty or not.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Size == 0;
        }
        
        /// <summary>
        /// An alternative to using Get(TValue value), Put(TKey key, TValue value), or Replace(TKey key, TValue oldValue, TValue newValue) .
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="KeyNotFoundException"></exception>
        public TValue this[TKey key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return GetValue(key);
                }

                throw new KeyNotFoundException();
            }
            set
            {
                if (ContainsKey(key))
                {
                    Replace(key, value);
                }
                else
                {
                    Put(key, value);
                }
            }
        }
    }
}