//
//
//

#include "Time.hpp"

/**
 *
 * @param newSeconds
 */
void AluminiumTech::DeveloperKit::Time::setSeconds(int64_t newSeconds) {
    seconds = newSeconds;
    cleanSecondsVariables();
}

/**
 *
 * @param newMinutes
 */
void AluminiumTech::DeveloperKit::Time::setMinutes(int64_t newMinutes) {
    minutes = newMinutes;
    cleanMinutesVariables();
}

/**
 *
 * @param newHours
 */
void AluminiumTech::DeveloperKit::Time::setHours(int64_t newHours) {
   hours = newHours;
   cleanMinutesVariables();
}

/**
 * Returns the number of seconds specified within the
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Time::getSeconds() {
    return seconds;
}

/**
 * Sets a specified number of milliseconds.
 * @param newMilliseconds
 */
void AluminiumTech::DeveloperKit::Time::setMilliseconds(int64_t newMilliseconds) {
    milliseconds = newMilliseconds;
}

/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Time::getMinutes() {
    return minutes;
}

/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Time::getHours() {
    return hours;
}

/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Time::getMilliseconds() {
    return milliseconds;
}
/**
 *
 * @return
 */
int64_t AluminiumTech::DeveloperKit::Time::getNanoseconds() {
    return nanoseconds;
}

/**
 * Add a specified number of milliseconds to the time object.
 * @param millisecondsToAdd
 */
void AluminiumTech::DeveloperKit::Time::addMilliseconds(int64_t millisecondsToAdd) {
    milliseconds += millisecondsToAdd;
    cleanMilliSecondsVariables();
}

/**
 * Adds a specified number of seconds to the time object.
 * @param secondsToAdd
 */
void AluminiumTech::DeveloperKit::Time::addSeconds(int64_t secondsToAdd) {
    seconds +=  secondsToAdd;
    cleanSecondsVariables();
}

/**
 * Adds a specified number of minutes to the time object.
 * @param minutesToAdd
 */
void AluminiumTech::DeveloperKit::Time::addMinutes(int64_t minutesToAdd) {
    minutes += minutesToAdd;
    cleanMinutesVariables();
}

/**
 * Adds a specified number of hours to the time object.
 * @param hoursToAdd
 */
void AluminiumTech::DeveloperKit::Time::addHours(int64_t hoursToAdd) {
    hours += hoursToAdd;
    cleanMinutesVariables();
}

/**
 * Sets a specified number of nanoseconds.
 * @param newNanoseconds
 */
void AluminiumTech::DeveloperKit::Time::setNanoseconds(int64_t newNanoseconds) {
    nanoseconds = newNanoseconds;
    cleanNanoSecondsVariables();
}

/**
 * Adds a specified number of nanoseconds to the time object.
 * @param nanoseconds
 */
void AluminiumTech::DeveloperKit::Time::addNanoseconds(int64_t nanosecondsToAdd) {
    nanoseconds += nanosecondsToAdd;
    cleanNanoSecondsVariables();
}

/**
 * Removes a specified number of nanoseconds.q
 * @param nanosecondsToRemove
 */
void AluminiumTech::DeveloperKit::Time::removeNanoseconds(int64_t nanosecondsToRemove) {
   nanoseconds -= nanosecondsToRemove;
   cleanNanoSecondsVariables();
}

/**
 * Removes a specified amount of milliseconds.
 * @param millisecondsToRemove
 */
void AluminiumTech::DeveloperKit::Time::removeMilliseconds(int64_t millisecondsToRemove) {
    milliseconds -= millisecondsToRemove;
    cleanMilliSecondsVariables();
}

/**
 * Removes a specified amount of seconds.
 * @param secondsToRemove
 */
void AluminiumTech::DeveloperKit::Time::removeSeconds(int64_t secondsToRemove) {
    seconds -= secondsToRemove;
    cleanSecondsVariables();
}

/**
 * Removes a specified number of minutes.
 * @param minutesToRemove
 */
void AluminiumTech::DeveloperKit::Time::removeMinutes(int64_t minutesToRemove) {
    minutes -= minutesToRemove;
    cleanMinutesVariables();
}

/**
 * Removes a specified number of hours.
 * @param hoursToRemove
 */
void AluminiumTech::DeveloperKit::Time::removeHours(int64_t hoursToRemove) {
    hours -= hoursToRemove;
    cleanMinutesVariables();
}

/**
 *
 */
void AluminiumTech::DeveloperKit::Time::cleanNanoSecondsVariables() {
    while(nanoseconds > 1000){
        nanoseconds = nanoseconds / 1000;
        milliseconds++;
    }

    while(nanoseconds < 0){
        nanoseconds = 0;
    }
}

/**
 *
 */
void AluminiumTech::DeveloperKit::Time::cleanMilliSecondsVariables() {
    while(milliseconds > 1000){
        milliseconds = milliseconds / 1000;
        seconds++;
    }

    while(milliseconds < 0){
        nanoseconds -= 1000;
        milliseconds++;
    }
}

/**
 *
 */
void AluminiumTech::DeveloperKit::Time::cleanSecondsVariables() {
    while(seconds > 60){
        seconds = seconds / 60;
        minutes++;
    }

    while(seconds < 0){
        milliseconds -= 1000;
        seconds++;
    }
}

/**
 *
 */
void AluminiumTech::DeveloperKit::Time::cleanMinutesVariables() {
    while(minutes > 60){
        minutes = minutes / 60;
        hours++;
    }

    if(hours < 0)
    {
       hours = 0;
        minutes += 60;
    }
}

/**
 *
 * @param timeA
 * @param timeB
 * @return
 */
AluminiumTech::DeveloperKit::Time
AluminiumTech::DeveloperKit::Time::difference(AluminiumTech::DeveloperKit::Time timeA,
                                                AluminiumTech::DeveloperKit::Time timeB) {
    AluminiumTech::DeveloperKit::Time time;

    int64_t hoursDifference = resultsAveraging.intDifference(timeA.getHours(), timeB.getHours());
    int64_t minutesDifference = resultsAveraging.intDifference(timeA.getMinutes(), timeB.getMinutes());
    int64_t secondsDifference = resultsAveraging.intDifference(timeA.getSeconds(), timeB.getSeconds());
    int64_t millisecondsDifference = resultsAveraging.intDifference(timeA.getMilliseconds(), timeB.getMilliseconds());
    int64_t nanosecondDifference = resultsAveraging.intDifference(timeA.getNanoseconds(), timeB.getNanoseconds());

    time.addNanoseconds(nanosecondDifference);
    time.addMilliseconds(millisecondsDifference);
    time.addSeconds(secondsDifference);
    time.addMinutes(minutesDifference);
    time.addHours(hoursDifference);

    return time;
}