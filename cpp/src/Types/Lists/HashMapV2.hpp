//
//
//

#ifndef DEVKIT_HASHMAPV2_HPP
#define DEVKIT_HASHMAPV2_HPP

#include "ObjectList.hpp"

#include "../KeyValuePair.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     * A class that wraps around ObjectList and KeyValuePair to act similarly to the HashMap class in Java.
     * @tparam Key
     * @tparam Value
     */
    template<typename Key, typename Value>
    class HashMapV2 {

    public:
        ~HashMapV2(){
            objectList.clear();
        }

        void put(KeyValuePair<Key, Value> pair){
            objectList.add(pair);
        }

        void put(Key key, Value value){
            KeyValuePair<Key, Value> pair;
            pair.key = key;
            pair.value = value;

            put(pair);
        }

        void remove(KeyValuePair<Key, Value> pair){
            objectList.remove(pair);
        }

        void remove(Key key){
            auto pair = getPairFromKey(key);
            remove(pair);
        }

        void remove(int_least32_t index){
            objectList.remove(index);
        }

        KeyValuePair<Key, Value> get(int_least32_t index){
            return objectList.get(index);
        }

        KeyValuePair<Key, Value> getPairFromKey(Key key){
            for(int index = 0; index < objectList.count; index++){
                KeyValuePair<Key, Value> pair = objectList.get(index);

                if(pair.key == key){
                    return pair;
                }
            }
        }

        Value getValueFromPair(Key key){
            return  getPairFromKey(key).value;
        }

        Value getValueFromPairOrDefault(Key key, Value defaultValue){
            if(getValueFromPair(key) == false){
                return defaultValue;
            }
            else{
                return getValueFromPair();
            }
        }

        ObjectList<KeyValuePair<Key, Value>> toObjectList(){
            return objectList;
        }

        int_least32_t length(){
            return objectList.count;
        }

    protected:
        ObjectList<KeyValuePair<Key, Value>> objectList;

    };
}
#endif //DEVKIT_HASHMAPV2_HPP
