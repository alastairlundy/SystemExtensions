//
//
//

#include "Date.hpp"

/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Date::getDay() {
    return day;
}

/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Date::getMonth() {
    return month;
}

/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Date::getYear() {
    return year;
}



/**
 *
 * @param day
 */
void AluminiumTech::DeveloperKit::Date::setDay(int64_t newDay) {
    if(newDay > 31 || newDay < 1){

    }
    else{
        day = newDay;
    }
}

/**
 *
 * @param month
 */
void AluminiumTech::DeveloperKit::Date::setMonth(int64_t newMonth) {
    if(newMonth > 12 || newMonth < 1){

    }
    else{
        month = newMonth;
    }
}

/**
 *
 * @param year
 */
void AluminiumTech::DeveloperKit::Date::setYear(int64_t newYear) {
    year = newYear;
}

/**
 *
 * @param daysToAdd
 */
void AluminiumTech::DeveloperKit::Date::addDays(int64_t daysToAdd) {
    if(daysToAdd % 365 > 0){
        auto daysToYears = daysToAdd / 365;
        day = day / 365;
        addYears(daysToYears);
    }

    dayCleanup();
}

/**
 *
 * @param monthsToAdd
 */
void AluminiumTech::DeveloperKit::Date::addMonths(int64_t monthsToAdd) {
    for (int64_t monthToStartAt = month; monthToStartAt < monthsToAdd; monthToStartAt++) {
        if (month == 13) {
            month -= 12;
            addYears(1);
        } else {
            month++;
        }
    }

    monthCleanup();
}

/**
 *
 * @param yearsToAdd
 */
void AluminiumTech::DeveloperKit::Date::addYears(int64_t yearsToAdd) {
        year += yearsToAdd;

        yearCleanup();
}

void AluminiumTech::DeveloperKit::Date::yearCleanup() {
    dayCleanup();
    monthCleanup();

    while(year > 12){
        month -= 12;
        year++;
    }
}

void AluminiumTech::DeveloperKit::Date::monthCleanup() {
    dayCleanup();

    while(month > 12){
        month -= 12;
        year++;
    }
}

void AluminiumTech::DeveloperKit::Date::dayCleanup() {
 while(day > 30){
     day -= 30;
    month++;
 }
}

/**
 *
 * @param daysToRemove
 */
void AluminiumTech::DeveloperKit::Date::removeDays(int64_t daysToRemove) {
   while(day > 0 && daysToRemove > 0){
       day++;
       daysToRemove--;
   }

   dayCleanup();
}

/**
 *
 * @param monthsToRemove
 */
void AluminiumTech::DeveloperKit::Date::removeMonths(int64_t monthsToRemove) {
    while(month > 0 && monthsToRemove > 0){
        month++;
        monthsToRemove--;
    }

    monthCleanup();
}

/**
 *
 * @param yearsToRemove
 */
void AluminiumTech::DeveloperKit::Date::removeYears(int64_t yearsToRemove) {
    while(year > 0 && yearsToRemove > 0){
        year++;
        yearsToRemove--;
    }

    yearCleanup();
}
