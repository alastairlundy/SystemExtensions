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

namespace AluminiumTech.DevKit.DeveloperKit
{
    public interface IJHashMap<TKey, TValue> : IHashMap<TKey, TValue>
    {
        public void ImportJHashMap(JHashMap<TKey, TValue> hashMap);

        public void Put(KeyValuePair<TKey, TValue> pair);
        public void Put(TKey key, TValue value);

        public void PutIfAbsent(TKey key, TValue value);
        public void PutIfAbsent(KeyValuePair<TKey, TValue> pair);

        public TValue GetValue(TKey key);
        public TValue GetValueOrDefault(TKey key, TValue defaultValue);

        public TKey GetKey(TValue value);

        public void Remove(KeyValuePair<TKey, TValue> pair);
        public void Remove(TKey key, TValue value);
        public void Remove(TKey key);
        public void RemoveAllInstancesOf(TValue value);

        public void Replace(TKey key, TValue value);
        public void Replace(TKey key, TValue oldValue, TValue newValue);

        public void Clear();

        public int IndexOf(KeyValuePair<TKey, TValue> pair);
        public int IndexOf(TKey key);

        public KeyValuePair<TKey, TValue> CreateKeyValuePair(TKey key, TValue value);

        public bool ContainsKey(TKey key);
        public bool ContainsValue(TValue value);
        public bool ContainsKeyValuePair(KeyValuePair<TKey, TValue> pair);

        public bool Equals(JHashMap<TKey, TValue> hashMap);
        
        public bool IsEmpty();
    }
}