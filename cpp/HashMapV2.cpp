//
//
//

#include "HashMapV2.hpp"

/**
 *
 * @tparam Key
 * @tparam Value
 * @return
 */
template<typename Key, typename Value>
AluminiumTech::DeveloperKit::KeyValuePair<Key, Value> *AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::toArray() {
    return nullptr;
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param key
 * @param value
 */
template<typename Key, typename Value>
void AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::put(Key key, Value value) {
    KeyValuePair<Key, Value> pair;
    pair.key = key;
    pair.value = value;

    put(pair);
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param pair
 */
template<typename Key, typename Value>
void AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::put(KeyValuePair<Key, Value> pair) {
    objectList.add(pair);
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param pair
 */
template<typename Key, typename Value>
void AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::remove(KeyValuePair<Key, Value> pair) {
    objectList.remove(pair);
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param key
 */
template<typename Key, typename Value>
void AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::remove(Key key) {
    auto pair = getPairFromKey(key);
    remove(pair);
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param index
 */
template<typename Key, typename Value>
void AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::remove(int index) {
    objectList.remove(index);
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param index
 * @return
 */
template<typename Key, typename Value>
AluminiumTech::DeveloperKit::KeyValuePair<Key, Value> AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::get(int index) {
    return objectList.get(index);
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param key
 * @return
 */
template<typename Key, typename Value>
Value AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::getValueFromPair(Key key) {
  return  getPairFromKey(key).value;
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param key
 * @param defaultValue
 * @return
 */
template<typename Key, typename Value>
Value AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::getValueFromPairOrDefault(Key key, Value defaultValue) {

    if(getValueFromPair(key) == false){
        return defaultValue;
    }
    else{
        return getValueFromPair();
    }
}

/**
 *
 * @tparam Key
 * @tparam Value
 * @param key
 * @return
 */
template<typename Key, typename Value>
AluminiumTech::DeveloperKit::KeyValuePair<Key, Value> AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::getPairFromKey(Key key) {
    for(int index = 0; index < objectList.count; index++){
        KeyValuePair<Key, Value> pair = objectList.get(index);

        if(pair.key == key){
            return pair;
        }
    }
}

template<typename Key, typename Value>
AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::HashMapV2() {

}

template<typename Key, typename Value>
AluminiumTech::DeveloperKit::HashMapV2<Key, Value>::~HashMapV2() {
    for(auto& a : objectList){
        delete a;
    }
}

