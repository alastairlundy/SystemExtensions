//
//
//

#include <exception>
#include "ResultsAveraging.hpp"

/**
 *
 * @param results
 * @return
 */
double AluminiumTech::DeveloperKit::ResultsAveraging::averageResults(const double *results) {
    double average = 0;

    for(int_least32_t index = 0; index < sizeof(results); index++){
        average += results[index];
    }

    return (average / sizeof(results));
}

/**
 *
 * @param results
 * @return
 */
bool AluminiumTech::DeveloperKit::ResultsAveraging::isAllPositive(const bool *results) {
    for(int index = 0; index < sizeof(results); index++){

        if(results[index] == false){
            return false;
        }
        else{

        }
    }

    return true;
}

/**
 *
 * @param results
 * @return
 */
bool AluminiumTech::DeveloperKit::ResultsAveraging::isAllNegative(const bool *results) {
    for(int_least32_t index = 0; index < sizeof(results); index++){

        if(results[index] == true){
            return false;
        }
        else{

        }
    }

    return true;
}

/**
 *
 * @param results
 * @return
 */
bool AluminiumTech::DeveloperKit::ResultsAveraging::averageResults(const bool *results) {
    int_least32_t trueCounter = 0;
    int_least32_t falseCounter = 0;

    try{
        for(int index = 0; index < sizeof(results); index++){

            if(results[index] == true){
                trueCounter++;
            }
            else{
                falseCounter++;
            }

            return (trueCounter > falseCounter);
        }
        return 0;
    }
   catch(std::exception &e){
       throw &e;
   }

}

float AluminiumTech::DeveloperKit::ResultsAveraging::floatDifference(float A, float B) {
//https://stackoverflow.com/questions/10589559/shortest-way-to-calculate-difference-between-two-numbers
    return A > B ? A - B : B - A;
}

int_least8_t AluminiumTech::DeveloperKit::ResultsAveraging::intDifference(int_least8_t A, int_least8_t B) {
//https://stackoverflow.com/questions/10589559/shortest-way-to-calculate-difference-between-two-numbers
    return A > B ? A - B : B - A;
}

double AluminiumTech::DeveloperKit::ResultsAveraging::doubleDifference(double A, double B) {
//https://stackoverflow.com/questions/10589559/shortest-way-to-calculate-difference-between-two-numbers
    return A > B ? A - B : B - A;
}