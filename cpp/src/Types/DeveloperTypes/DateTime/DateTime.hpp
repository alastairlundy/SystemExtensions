//
//
//

#ifndef DEVELOPERKIT_DATETIME_HPP
#define DEVELOPERKIT_DATETIME_HPP


#include "Time/Time.hpp"
#include "Date/Date.hpp"

namespace AluminiumTech::DeveloperKit{
    class DateTime : Date, Time {

    public:
        void addNanoseconds(int64_t nanosecondsToAdd);
        void addMilliseconds(int64_t millisecondsToAdd);
        void addSeconds(int64_t secondsToAdd);
        void addMinutes(int64_t minutesToAdd);
        void addHours(int64_t hoursToAdd);

        void addDays(int64_t daysToAdd);
        void addMonths(int64_t monthsToAdd);
        void addYears(int64_t yearsToAdd);

        void removeNanoseconds(int64_t nanosecondsToRemove);
        void removeMilliseconds(int64_t millisecondsToRemove);
        void removeSeconds(int64_t secondsToRemove);
        void removeMinutes(int64_t minutesToRemove);
        void removeHours(int64_t hoursToRemove);

        void removeDays(int64_t daysToRemove);
        void removeMonths(int64_t monthsToRemove);
        void removeYears(int64_t yearsToRemove);

    protected:




    private:


    };

}

#endif //DEVELOPERKIT_DATETIME_HPP
