//
//
//

#include "ObjectList.hpp"


template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::incrementCount() {
    count++;
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::decrementCount() {
    count--;
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::clear() {
    vec.clear();
    count = 0;
}

template<typename Object>
Object AluminiumTech::DeveloperKit::ObjectList<Object>::get(int index) {
    if(count > 0){
        return vec.at(index);
    }
}

template<typename Object>
int AluminiumTech::DeveloperKit::ObjectList<Object>::indexOf(Object object) {
    int index = 0;

    for(auto a : vec){
        if(get(index) == object){
            return index;
        }

        index++;
    }
    return 0;
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::add(Object object) {
    vec.insert(object);
    incrementCount();
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::remove(Object object) {
    if(count > 0){
        vec.remove(object);
        decrementCount();
    }
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::remove(int index) {
    if(count > 0){
        auto object = get(index);
        vec.remove(object);
        decrementCount();
    }
}

template<typename Object>
std::vector <Object> AluminiumTech::DeveloperKit::ObjectList<Object>::toVector() {
    return vec;
}

template<typename Object>
int AluminiumTech::DeveloperKit::ObjectList<Object>::capacity() {
    return vec.capacity();
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::replace(int index, Object newObject) {
    vec.at(index) = newObject;
}

template<typename Object>
void AluminiumTech::DeveloperKit::ObjectList<Object>::replace(Object oldObject, Object newObject) {
   int index = indexOf(oldObject);
   replace(index, newObject);
}

template<typename Object>
Object* AluminiumTech::DeveloperKit::ObjectList<Object>::toArray() {
    Object array[count];

    for(int index = 0; index < count; index++){
        array = get(index);
    }

    return array;
}

template<typename Object>
AluminiumTech::DeveloperKit::ObjectList<Object>::ObjectList() {

}

template<typename Object>
AluminiumTech::DeveloperKit::ObjectList<Object>::~ObjectList() {
    for(auto& a : vec){
        delete a;
    }

    delete vec;
}
