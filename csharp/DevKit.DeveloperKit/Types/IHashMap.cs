using System.Collections.Generic;

namespace AluminiumTech.DeveloperKit;

public interface IHashMap<TKey, TValue>
{
    public void Put(KeyValuePair<TKey, TValue> pair);
    public void Put(TKey key, TValue value);
    
    public void PutIfAbsent(TKey key, TValue value);
    public void PutIfAbsent(KeyValuePair<TKey, TValue> pair);

    public TValue GetValue(TKey key);
    public TValue GetValueOrDefault(TKey key, TValue defaultValue);
    public TKey GetKey(TValue value);

    public void Remove(KeyValuePair<TKey, TValue> pair);
    public void Remove(TKey key, TValue value);

    public KeyValuePair<TKey, TValue>[] InstancesOf(TValue value);

    public void Clear();

    public int IndexOf(KeyValuePair<TKey, TValue> pair);


    public bool Contains(TKey key);
    
    public bool Contains(TValue value);

    public bool Contains(KeyValuePair<TKey, TValue> pair);

    public bool IsEmpty();
    
}