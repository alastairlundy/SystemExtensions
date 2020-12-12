//
//
//

#ifndef DEVELOPERKIT_STOPWATCH_HPP
#define DEVELOPERKIT_STOPWATCH_HPP

#include <chrono>

#include "../DateTime/Time/Time.hpp"
#include "../../Lists/ObjectList.hpp"

namespace AluminiumTech::DeveloperKit{
    /**
     * A relatively high resolution Stopwatch that wraps around the C++ STL's Chrono class.
     * Time is captured in milliseconds.
     * Supports pausing and resuming.
     */
    class Stopwatch{

        public:
            void start();
            void stop();

            void pause();
            void resume();

            void reset();

           int64_t getElapsedMilliseconds();

            AluminiumTech::DeveloperKit::Time getElapsedTime();


            ~Stopwatch();

        protected:
            std::chrono::time_point<std::chrono::high_resolution_clock> startTimePoint;
            std::chrono::time_point<std::chrono::high_resolution_clock> endTimePoint;

            AluminiumTech::DeveloperKit::ObjectList<int64_t> durationMilliseconds;

        private:


    };

}

#endif //DEVELOPERKIT_STOPWATCH_HPP
