//
//
//

#ifndef DEVELOPERKIT_RESULTSAVERAGING_HPP
#define DEVELOPERKIT_RESULTSAVERAGING_HPP

#include <cstdint>

namespace AluminiumTech::DeveloperKit {

    class ResultsAveraging {

    public:
        double averageResults(const double* results);

        bool isAllPositive(const bool* results);
        bool isAllNegative(const bool* results);

        bool averageResults(const bool* results);

        float floatDifference(float A, float B);

        int_least8_t intDifference(int_least8_t A, int_least8_t B);

        double doubleDifference(double A, double B);

    protected:


    private:


    };
}

#endif //DEVELOPERKIT_RESULTSAVERAGING_HPP
