//
//
//

#ifndef DEVKIT_OBJECTLIST_HPP
#define DEVKIT_OBJECTLIST_HPP

#include <vector>

namespace AluminiumTech::DeveloperKit {

/**
 * A wrapper around the C++ Standard Library 'list' class.
 */
    template<typename Object>
    class ObjectList {

    public:
        ~ObjectList();

        int count;

        int capacity();

        void clear();

        Object get(int32_t index);

        int indexOf(Object object);

        void add(Object object);

        void remove(Object object);
        void remove(int index);

        void replace(int index, Object newObject);
        void replace(Object oldObject, Object newObject);

        std::vector<Object> toVector();

        Object *toArray();

    protected:
        std::vector<Object> vec;

        void incrementCount();

        void decrementCount();
    };

}
#endif //DEVKIT_OBJECTLIST_HPP
