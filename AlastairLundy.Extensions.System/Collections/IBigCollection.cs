using System.Collections;

namespace AlastairLundy.Extensions.System.Collections
{
    // ReSharper disable once TypeParameterCanBeVariant
    public interface IBigCollection<T> : IEnumerable
    {
        ulong Count { get; }

        bool IsReadOnly { get; }

        void Add(T item);
        void Clear();
        void Remove(T item);
        
        bool Contains(T item);
    }
}