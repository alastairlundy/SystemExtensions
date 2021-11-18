/* BSD 3-Clause License
    
    Copyright (c) 2020-2021, AluminiumTech DevKit
    All rights reserved.
    
    Redistribution and use in source and binary forms, with or without
    modification, are permitted provided that the following conditions are met:
    
    1. Redistributions of source code must retain the above copyright notice, this
       list of conditions and the following disclaimer.
    
    2. Redistributions in binary form must reproduce the above copyright notice,
       this list of conditions and the following disclaimer in the documentation
       and/or other materials provided with the distribution.
    
    3. Neither the name of the copyright holder nor the names of its
       contributors may be used to endorse or promote products derived from
       this software without specific prior written permission.
    
    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
    AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
    IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
    DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
    FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
    DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
    SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
    CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
    OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
    OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Collections;
using System.Collections.Generic;

using AluminiumTech.DevKit.DeveloperKit.Exceptions;

namespace AluminiumTech.DevKit.DeveloperKit
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
            KeyValuePairs = new();
        }

        public int Size => KeyValuePairs.Count;

        /// <summary>
        /// Imports an existing HashMap object and creates a new one.
        /// </summary>
        /// <param name="hashMap"></param>
        public void ImportHashMap(HashMap<TKey, TValue> hashMap)
        {
            ImportList(hashMap.ToList());
        }

        public void ImportList(List<KeyValuePair<TKey, TValue>> list)
        {
            ImportArray(list.ToArray());   
        }

        public void ImportArray(KeyValuePair<TKey, TValue>[] array)
        {
            foreach (KeyValuePair<TKey,TValue> pairs in array)
            {
                Put(pairs);
            }
        }

        public void ImportHashtable(Hashtable hashtable)
        {
            var keys = hashtable.Keys;
            var vals = hashtable.Values;

            var sameSize = keys.Count == vals.Count;

            TKey[] keyArray = new TKey[keys.Count];
            TValue[] valArray = new TValue[vals.Count];

            vals.CopyTo(valArray, 0);
            keys.CopyTo(keyArray,0);

            if (sameSize)
            {
                for (int index = 0; index < keys.Count; index++)
                {
                    Put(CreateKeyValuePair(keyArray[index], valArray[index]));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionary"></param>
        public void ImportDictionary(Dictionary<TKey, TValue> dictionary)
        {
            foreach (TKey key in dictionary.Keys)
            {
                Put(CreateKeyValuePair(key, dictionary[key]));
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
            Put(CreateKeyValuePair(key, value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void PutIfAbsent(TKey key, TValue value)
        {
            PutIfAbsent(CreateKeyValuePair(key, value));
        }

        /// <summary>
        /// 
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
            try
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
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw new Exception(exception.ToString());
            }
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
            try
            {
                if (ContainsValue(value))
                {
                    foreach (KeyValuePair<TKey, TValue> pairs in KeyValuePairs)
                    {
                        if (pairs.Value.Equals(value))
                        {
                            return pairs.Key;
                        }
                    }
                }
                
                throw new ValueNotFoundException();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw new Exception(exception.ToString());
            }
        }
        
        /// <summary>
        /// Remove a KeyValuePair from the HashMap.
        /// </summary>
        /// <param name="pair"></param>
        public void Remove(KeyValuePair<TKey, TValue> pair)
        {
            KeyValuePairs.Remove(pair);
        }
        
        /// <summary>
        /// Remove a Key and a Value from a HashMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Remove(TKey key, TValue value)
        {
            Remove(CreateKeyValuePair(key, value));
        }
        
        /// <summary>
        /// Remove all instances of a Key in a HashMap.
        /// </summary>
        /// <param name="key"></param>
        public void Remove(TKey key)
        {
            try
            {
                if (ContainsKey(key))
                {
                    for (int index = 0; index < KeyValuePairs.Count; index++)
                    {
                        if (KeyValuePairs[index].Key.Equals(key))
                        {
                            Remove(key, GetValue(key));
                        }
                    }
                }

                throw new KeyNotFoundException();
            }
            catch (Exception exception)
            {
               Console.WriteLine(exception.ToString());
               throw new Exception(exception.ToString());
            }
        }
        
        /// <summary>
        /// Remove all instances of a Value in a HashMap.
        /// </summary>
        /// <param name="value"></param>
        public void RemoveAllInstancesOf(TValue value)
        {
            try
            {
                if (ContainsValue(value))
                {
                    for (int index = 0; index < KeyValuePairs.Count; index++)
                    {
                        if (KeyValuePairs[index].Value.Equals(value))
                        {
                            Remove(GetKey(value), value);
                        }
                    }
                }

                throw new ValueNotFoundException();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw new Exception(exception.ToString());
            }
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
            try
            {
                if (ContainsKey(key))
                {
                    for (int index = 0; index < KeyValuePairs.Count; index++)
                    {
                        if (KeyValuePairs[index].Value == null)
                        {
                            KeyValuePairs[index] = new (key, value);
                        }
                    }
                }

                throw new KeyNotFoundException();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw new Exception(exception.ToString());
            }
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
            try
            {
                if (ContainsKey(key))
                {
                    if (ContainsValue(oldValue)){
                        for (int index = 0; index < KeyValuePairs.Count; index++)
                        {
                            if (KeyValuePairs[index].Key.Equals(key))
                            {
                                KeyValuePairs[index] = new (key, newValue);
                            }
                        }
                    }

                    throw new ValueNotFoundException();
                }

                throw new KeyNotFoundException();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
                throw new Exception(exception.ToString());
            }
        }
        
        /// <summary>
        /// Removals all Key Value Pairs from the list.
        /// </summary>
        public void Clear()
        {
            KeyValuePairs.Clear();
        }
        
        /// <summary>
        /// Creates a key value pair and returns it.
        /// Note: This does not add it to the HashMap object.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public KeyValuePair<TKey, TValue> CreateKeyValuePair(TKey key, TValue value)
        {
            return new (key, value);
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
        /// Returns whether the hashmap is empty or not.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return !(KeyValuePairs.Count > 0);
        }
    }
}