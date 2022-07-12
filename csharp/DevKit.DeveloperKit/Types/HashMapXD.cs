using System.Collections.Generic;

namespace AluminiumTech.DeveloperKit;

/// <summary>
/// Multi Dimensional HashMap
///
/// 
/// </summary>
public class HashMapXD<TMainKey, TSubKey, TValue> : IHashMap<TSubKey, TValue>
{
    protected HashMap<TMainKey, HashMap<TSubKey, TValue>> _hashMap;

    protected HashMapXD()
    {
        _hashMap = new HashMap<TMainKey, HashMap<TSubKey, TValue>>();
    }

    public int TotalSize
    {
        get
        {
            int size = 0;
            
            foreach (var hashmap in _hashMap.ToList())
            {
                size += hashmap.Value.Size;
            }

            return size;
        }
    }
    
    public void Put(TMainKey mainKey, KeyValuePair<TSubKey, TValue> pair)
    {
        throw new System.NotImplementedException();
    }

    public void Put(TMainKey mainKey, HashMap<TSubKey, TValue> pair)
    {
        _hashMap.Put(mainKey, pair);
    }
    
    public void PutIfAbsent(TSubKey key, TValue value)
    {
        throw new System.NotImplementedException();
    }

    public void PutIfAbsent(KeyValuePair<TSubKey, TValue> pair)
    {
        throw new System.NotImplementedException();
    }

    public TValue GetValue(TSubKey key)
    {
        throw new System.NotImplementedException();
    }

    public TValue GetValueOrDefault(TSubKey key, TValue defaultValue)
    {
        throw new System.NotImplementedException();
    }

    public TSubKey GetKey(TValue value)
    {
        throw new System.NotImplementedException();
    }

    public void Remove(KeyValuePair<TSubKey, TValue> pair)
    {
        throw new System.NotImplementedException();
    }

    public void Remove(TSubKey key, TValue value)
    {
        throw new System.NotImplementedException();
    }

    public KeyValuePair<TSubKey, TValue>[] InstancesOf(TValue value)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public int IndexOf(KeyValuePair<TSubKey, TValue> pair)
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(TSubKey key)
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(TValue value)
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(KeyValuePair<TSubKey, TValue> pair)
    {
        throw new System.NotImplementedException();
    }

    public bool IsEmpty()
    {
        return TotalSize <= 0;
    }

    public TValue this[TSubKey key]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }

    public HashMap<TSubKey, TValue> this[TMainKey mainKey]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}