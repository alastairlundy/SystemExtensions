//
//
//

#ifndef DEVKIT_HASHMAPV2_HPP
#define DEVKIT_HASHMAPV2_HPP


#include "ObjectList.hpp"

#include "KeyValuePair.hpp"

namespace AluminiumTech::DeveloperKit {

    template<typename Key, typename Value>
    class HashMapV2 {

    public:
        HashMapV2();

        ~HashMapV2();

        void put(KeyValuePair<Key, Value> pair);

        void put(Key key, Value value);

        void remove(KeyValuePair<Key, Value> pair);

        void remove(Key key);

        void remove(int index);

        KeyValuePair<Key, Value> get(int index);

        KeyValuePair<Key, Value> getPairFromKey(Key key);

        Value getValueFromPair(Key key);

        Value getValueFromPairOrDefault(Key key, Value defaultValue);

        KeyValuePair<Key, Value> *toArray();

    protected:
        ObjectList<KeyValuePair<Key, Value>> objectList;

    };
}
#endif //DEVKIT_HASHMAPV2_HPP
