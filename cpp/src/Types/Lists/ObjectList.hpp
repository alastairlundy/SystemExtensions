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

    template<typename Object> class ObjectList {

    public:
        int_least32_t count;

        ObjectList(){
            count = 0;
        }
        ~ObjectList(){
            vec.clear();
        }

        int_least32_t capacity(){
            return vec.capacity();
        }

        void clear(){
            vec.clear();
            count = 0;
        }

        Object get(int_least32_t index){
            try{
                return vec.at(index);
            }
            catch(std::exception &e){
                throw &e;
            }
        }

        int_least32_t indexOf(Object object){
            int_least32_t index = 0;

            for(auto a : vec){
                if(get(index) == object){
                    return index;
                }

                index++;
            }
            return 0;
        }

        void add(Object object){
            vec.assign(1, object);
            increaseCount();
        }

        void remove(Object object){
            if(count > 0){
                vec.remove(object);
                decreaseCount();
            }
        }

        void remove(int_least32_t index){
            if (count > 0) {
                auto object = get(index);
                vec.remove(object);
                decreaseCount();
            }
        }

        void replace(int_least32_t index, Object newObject){
            vec.at(index) = newObject;
        }

        void replace(Object oldObject, Object newObject){
            int_least32_t index = indexOf(oldObject);
            replace(index, newObject);
        }

        std::vector<Object> toVector(){
            return vec;
        }

    protected:
        std::vector<Object> vec;

        void increaseCount(){
            count++;
        }

        void decreaseCount(){
            count--;
        }
    };

}
#endif //DEVKIT_OBJECTLIST_HPP
