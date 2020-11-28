//
//
//

#ifndef DEVELOPERKIT_DATE_HPP
#define DEVELOPERKIT_DATE_HPP


#include <cstdint>

namespace AluminiumTech::DeveloperKit{
    /**
     *
     */
    class Date {

    public:
        int64_t getDay();
        int64_t getMonth();
        int64_t getYear();

        void setDay(int64_t newDay);
        void setMonth(int64_t newMonth);
        void setYear(int64_t newYear);

        void addDays(int64_t daysToAdd);
        void addMonths(int64_t monthsToAdd);
        void addYears(int64_t yearsToAdd);

        void removeDays(int64_t daysToRemove);
        void removeMonths(int64_t monthsToRemove);
        void removeYears(int64_t yearsToRemove);

    protected:
        int64_t day;
        int64_t month;
        int64_t year;

        void yearCleanup();
        void monthCleanup();
        void dayCleanup();


    private:

    };
}


#endif //DEVELOPERKIT_DATE_HPP
