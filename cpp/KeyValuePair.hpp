//
//
//

#ifndef DEVKIT_KEYVALUEPAIR_HPP
#define DEVKIT_KEYVALUEPAIR_HPP

namespace AluminiumTech::DeveloperKit {

template <typename Key, typename Value> class KeyValuePair {

    public:
    Key key;
    Value value;

    KeyValuePair();
    ~KeyValuePair();

    protected:

    };
}
template<typename Key, typename Value>
AluminiumTech::DeveloperKit::KeyValuePair<Key, Value>::~KeyValuePair() {
    delete key;
    delete value;
}

template<typename Key, typename Value>
AluminiumTech::DeveloperKit::KeyValuePair<Key, Value>::KeyValuePair() {

}


#endif //DEVKIT_KEYVALUEPAIR_HPP
