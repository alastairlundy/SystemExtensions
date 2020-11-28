//
//
//

#ifndef DEVKIT_HASHMAPV2_HPP
#define DEVKIT_HASHMAPV2_HPP

#include "../ObjectList/ObjectList.hpp"

#include "../../KeyValuePair.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     * A class that wraps around ObjectList and KeyValuePair to act similarly to the HashMap class in Java.
     * @tparam Key
     * @tparam Value
     */
    template<typename Key, typename Value>
    class HashMapV2 {

    public:
        ~HashMapV2();

        void put(KeyValuePair<Key, Value> pair);
        void put(Key key, Value value);

        void remove(KeyValuePair<Key, Value> pair);
        void remove(Key key);
        void remove(int32_t index);

        KeyValuePair<Key, Value> get(int32_t index);

        KeyValuePair<Key, Value> getPairFromKey(Key key);

        Value getValueFromPair(Key key);
        Value getValueFromPairOrDefault(Key key, Value defaultValue);

        KeyValuePair<Key, Value> *toArray();
        ObjectList<KeyValuePair<Key, Value>> toObjectList();

        int length();

    protected:
        ObjectList<KeyValuePair<Key, Value>> objectList;

    };
}
#endif //DEVKIT_HASHMAPV2_HPP
