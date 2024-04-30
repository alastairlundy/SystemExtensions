﻿/*
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
using AlastairLundy.Extensions.System.DictionaryExtensions;
using AlastairLundy.Extensions.System.Exceptions;

namespace AlastairLundy.Extensions.System.Collections
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class HashMap<TKey, TValue> : IHashMap<TKey, TValue>
    {
        // ReSharper disable once InconsistentNaming
        protected Dictionary<TKey, TValue> _dictionary;

        /// <summary>
        /// 
        /// </summary>
        public HashMap()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }
        
        /// <summary>
        /// Add a Key and a corresponding Value to the HashMap.
        /// </summary>
        /// <param name="key">The key to be added.</param>
        /// <param name="value">The value to be associated with the key.</param>
        public void Put(TKey key, TValue value)
        {
            if (!ContainsKey(key))
            {
                _dictionary.Add(key, value);
            }

            throw new ArgumentException($"Existing key {key} found with value {GetValue(key)}. Can't put a Key that already exists.");
        }

        /// <summary>
        /// Add a KeyValuePair to the HashMap.
        /// </summary>
        /// <param name="pair">The KeyValuePair to be added.</param>
        /// <exception cref="ArgumentException"></exception>
        public void Put(KeyValuePair<TKey, TValue> pair)
        {
            Put(pair.Key, pair.Value);
        }

        /// <summary>
        /// Adds a Key and a corresponding value to the HashMap only if the key isn't already in use.
        /// If the key is already present in the HashMap no action is taken.
        /// </summary>
        /// <param name="key">The key to be added.</param>
        /// <param name="value">The value to be associated with the key.</param>
        public void PutIfAbsent(TKey key, TValue value)
        {
            if (!ContainsKey(key))
            {
                Put(key, value);
            }
        }

        /// <summary>
        /// Adds a KeyValuePair to the HashMap only if the key isn't already in use.
        /// If the key is already present in the HashMap no action is taken.
        /// </summary>
        /// <param name="pair">The KeyValuePair to be added to the hashmap.</param>
        public void PutIfAbsent(KeyValuePair<TKey, TValue> pair)
        {
            PutIfAbsent(pair.Key, pair.Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public TValue GetValue(TKey key)
        {
            if (ContainsKey(key))
            {
                return _dictionary[key];
            }
            
            throw new KeyNotFoundException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public TValue GetValueOrDefault(TKey key, TValue defaultValue)
        {
            if (ContainsKey(key))
            {
                return GetValue(key);
            }
            // ReSharper disable once RedundantIfElseBlock
            else
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Returns an IEnumerable of Keys in the HashMap.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TKey> Keys()
        {
            return _dictionary.Keys;
        }

        /// <summary>
        /// Returns an IEnumerable of Values in the HashMap.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TValue> Values()
        {
            return _dictionary.Values;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns>true if the item has been successfully removed from the HashMap, and false otherwise.</returns>
        public bool Remove(TKey key)
        {
            if (ContainsKey(key))
            {
                return _dictionary.Remove(key);
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pair"></param>
        /// <returns></returns>
        /// <exception cref="KeyValuePairNotFoundException"></exception>
        public bool Remove(KeyValuePair<TKey, TValue> pair)
        {
            if (ContainsKeyValuePair(pair))
            {
              return Remove(pair.Key);
            }

            throw new KeyValuePairNotFoundException(nameof(pair));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void RemoveInstancesOf(TValue value)
        {
            TKey[] keys = _dictionary.GetKeys(value);

            // ReSharper disable once ForCanBeConvertedToForeach
            for (int index = 0; index < keys.Length; index++)
            {
                Remove(keys[index]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="KeyNotFoundException"></exception>
        public bool Replace(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                _dictionary[key] = value;
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <exception cref="KeyValuePairNotFoundException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        public bool Replace(TKey key, TValue oldValue, TValue newValue)
        {
            if (ContainsKey(key))
            {
                if (ContainsKeyValuePair(new KeyValuePair<TKey, TValue>(key, oldValue)))
                {
                    _dictionary[key] = newValue;
                    return true;
                }

                return false;
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// Clears the contents of the HashMap.
        /// </summary>
        public void Clear()
        {
            _dictionary.Clear();
        }
        
        /// <summary>
        /// Returns the HashMap's internal Dictionary object.
        /// </summary>
        /// <returns></returns>
        public Dictionary<TKey, TValue> ToDictionary()
        {
            return _dictionary;
        }

        /// <summary>
        /// Returns whether the HasMap contains a Key or not.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ContainsValue(TValue value)
        {
            return _dictionary.ContainsValue(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pair"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public bool ContainsKeyValuePair(KeyValuePair<TKey, TValue> pair)
        {
            if (ContainsKey(pair.Key))
            {
                return _dictionary[pair.Key].Equals(pair.Value);
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public bool Equals(HashMap<TKey, TValue> map)
        {
            return _dictionary.Equals(map.ToDictionary());
        }

        /// <summary>
        /// Returns whether the HashMap is empty or not.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Count() > 0;
        }

        /// <summary>
        /// Returns the number of KeyValuePairs in the HashMap. 
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _dictionary.Count;
        }
    }
}