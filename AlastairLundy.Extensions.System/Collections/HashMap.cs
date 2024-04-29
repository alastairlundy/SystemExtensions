using System;
using System.Collections.Generic;
using AlastairLundy.Extensions.System.DictionaryExtensions;
using AlastairLundy.Extensions.System.Exceptions;
using NotImplementedException = System.NotImplementedException;

namespace AlastairLundy.Extensions.System.Collections
{
    public class HashMap<TKey, TValue> : IHashMap<TKey, TValue>
    {
        // ReSharper disable once InconsistentNaming
        protected Dictionary<TKey, TValue> _dictionary;

        public HashMap()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }
        
        public void Put(TKey key, TValue value)
        {
            Put(new KeyValuePair<TKey, TValue>(key, value));
        }

        public void Put(KeyValuePair<TKey, TValue> pair)
        {
            if (!ContainsKey(pair.Key))
            {
                _dictionary.Add(pair.Key, pair.Value);
            }

            throw new ArgumentException($"Existing key {pair.Key} found with value {GetValue(pair.Key)}. Can't put a Key that already exists.");
        }

        public void PutIfAbsent(TKey key, TValue value)
        {
            if (!ContainsKey(key))
            {
                Put(key, value);
            }
        }

        public void PutIfAbsent(KeyValuePair<TKey, TValue> pair)
        {
            PutIfAbsent(pair.Key, pair.Value);
        }

        public TValue GetValue(TKey key)
        {
            if (ContainsKey(key))
            {
                return _dictionary[key];
            }
            
            throw new KeyNotFoundException();
        }

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

        public IEnumerable<TKey> Keys()
        {
            return _dictionary.Keys;
        }

        public IEnumerable<TValue> Values()
        {
            return _dictionary.Values;
        }

        public void Remove(TKey key)
        {
            _dictionary.Remove(key);
        }

        public void Remove(KeyValuePair<TKey, TValue> pair)
        {
            if (ContainsKey(pair.Key) && ContainsValue(pair.Value))
            {
                _dictionary.Remove(pair.Key);
            }
        }

        public void RemoveInstancesOf(TValue value)
        {
            TKey[] keys = _dictionary.GetKeys(value);

            // ReSharper disable once ForCanBeConvertedToForeach
            for (int index = 0; index < keys.Length; index++)
            {
                Remove(keys[index]);
            }
        }

        public void Replace(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                _dictionary[key] = value;
            }

            throw new KeyNotFoundException();
        }

        public void Replace(TKey key, TValue oldValue, TValue newValue)
        {
            if (ContainsKey(key))
            {
                if (ContainsKeyValuePair(new KeyValuePair<TKey, TValue>(key, oldValue)))
                {
                    _dictionary[key] = newValue;
                }

                throw new KeyValuePairNotFoundException(nameof(_dictionary));
            }

            throw new KeyNotFoundException();
        }

        public void Clear()
        {
            _dictionary.Clear();
        }
        
        public Dictionary<TKey, TValue> ToDictionary()
        {
            return _dictionary;
        }

        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        public bool ContainsValue(TValue value)
        {
            return _dictionary.ContainsValue(value);
        }

        public bool ContainsKeyValuePair(KeyValuePair<TKey, TValue> pair)
        {
            if (ContainsKey(pair.Key))
            {
                return _dictionary[pair.Key].Equals(pair.Value);
            }

            throw new KeyNotFoundException();
        }

        public bool Equals(HashMap<TKey, TValue> map)
        {
            return _dictionary.Equals(map.ToDictionary());
        }

        public bool IsEmpty()
        {
            return Count() > 0;
        }

        public int Count()
        {
            return _dictionary.Count;
        }
    }
}