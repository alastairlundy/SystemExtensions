//
//
//

#include "Stopwatch.hpp"

/**
 * Starts the stopwatch.
 */
void AluminiumTech::DeveloperKit::Stopwatch::start() {
    startTimePoint = std::chrono::high_resolution_clock::now();
}

/**
 * Does the same thing as pausing but may be used when there is no intention to resume the stopwatch.
 */
void AluminiumTech::DeveloperKit::Stopwatch::stop() {
    pause();
}

/**
 * Stops the stopwatch and stores the duration so far in an ObjectList.
 * Can be resumed at any time.
 */
void AluminiumTech::DeveloperKit::Stopwatch::pause() {
    endTimePoint = std::chrono::high_resolution_clock::now();

    //https://stackoverflow.com/questions/31255486/c-how-do-i-convert-a-stdchronotime-point-to-long-and-back
    auto endTimeMs = std::chrono::time_point_cast<std::chrono::milliseconds>(endTimePoint);
    auto startTimeMs = std::chrono::time_point_cast<std::chrono::milliseconds>(startTimePoint);

    auto startEpoch = startTimeMs.time_since_epoch();
    auto endEpoch = endTimeMs.time_since_epoch();

    auto startValue = std::chrono::duration_cast<std::chrono::milliseconds>(startEpoch);
    auto endValue = std::chrono::duration_cast<std::chrono::milliseconds>(endEpoch);

    long long startTime = startValue.count();
    long long endTime = endValue.count();

    auto difference = endTime - startTime;

    if(difference < 0){

    }
    else{
        durationMilliseconds.add(difference);
    }

}

/**
 * Resume from the current time.
 */
void AluminiumTech::DeveloperKit::Stopwatch::resume() {
    start();
}

/**
 * Resets the stopwatch time.
 */
void AluminiumTech::DeveloperKit::Stopwatch::reset() {
    durationMilliseconds.clear();
}

/**
 * Returns the elapsed milliseconds.
 * @return
 */
long long AluminiumTech::DeveloperKit::Stopwatch::getElapsedMilliseconds() {
    long long milliseconds = 0;

    for(auto item : durationMilliseconds.toVector()){
        milliseconds += item;
    }

    return milliseconds;
}

/**
 * Returns the elapsed time as a Time object.
 * @return
 */
AluminiumTech::DeveloperKit::Time AluminiumTech::DeveloperKit::Stopwatch::getElapsedTime() {
    AluminiumTech::DeveloperKit::Time time;
    time.addMilliseconds(getElapsedMilliseconds());
    return time;
}

AluminiumTech::DeveloperKit::Stopwatch::~Stopwatch() {
    durationMilliseconds.clear();
}