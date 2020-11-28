/**
 *
 */

#ifndef DEVELOPERKIT_TIME_HPP
#define DEVELOPERKIT_TIME_HPP

#include <cstdint>
#include "../../../../StringManipulation/deps/ResultsAveraging.hpp"

namespace AluminiumTech::DeveloperKit{
    /**
     *
     */
    class Time {

    public:
        void setNanoseconds(int64_t newNanoseconds);
        void setMilliseconds(int64_t newMilliseconds);
        void setSeconds(int64_t newSeconds);
        void setMinutes(int64_t newMinutes);
        void setHours(int64_t newHours);

        int64_t getNanoseconds();
        int64_t getMilliseconds();
        int64_t getSeconds();
        int64_t getMinutes();
        int64_t getHours();

        void removeNanoseconds(int64_t nanosecondsToRemove);
        void removeMilliseconds(int64_t millisecondsToRemove);
        void removeSeconds(int64_t secondsToRemove);
        void removeMinutes(int64_t minutesToRemove);
        void removeHours(int64_t hoursToRemove);

        void addNanoseconds(int64_t nanoseconds);
        void addMilliseconds(int64_t millisecondsToAdd);
        void addSeconds(int64_t secondsToAdd);
        void addMinutes(int64_t minutesToAdd);
        void addHours(int64_t hoursToAdd);

        AluminiumTech::DeveloperKit::Time difference(AluminiumTech::DeveloperKit::Time timeA, AluminiumTech::DeveloperKit::Time timeB);

    protected:
        int64_t nanoseconds;
        int64_t milliseconds;
        int64_t seconds;
        int64_t minutes;
        int64_t hours;

        void cleanNanoSecondsVariables();
        void cleanMilliSecondsVariables();
        void cleanSecondsVariables();
        void cleanMinutesVariables();

        AluminiumTech::DeveloperKit::ResultsAveraging resultsAveraging;
    private:


    };

}

#endif //DEVELOPERKIT_TIME_HPP
