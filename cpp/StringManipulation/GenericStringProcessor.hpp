//
//
//

#ifndef DEVKIT_GENERICSTRINGPROCESSOR_HPP
#define DEVKIT_GENERICSTRINGPROCESSOR_HPP

#include "StringFormatter.hpp"
#include "deps/ResultsAveraging.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     *
     */
    class GenericStringProcessor {

    public:
        std::string capitalizeALetterInAWord(int index, std::string word);
        std::string capitalizeFirstLetterOfWord(std::string word);

        bool isCharacterASpecialCharacter(char c);
        bool isCharacterALowerCaseLetter(char c);
        bool isCharacterAnUpperCaseLetter(char c);

        bool isWordTitleCase(std::string word);

        bool basicTitleCaseDetection(const std::string& phrase);
        std::string phraseToTitleCase(std::string phrase);

    protected:
        AluminiumTech::DeveloperKit::StringFormatter stringFormatter;
        AluminiumTech::DeveloperKit::ResultsAveraging resultsAveraging;

    private:

    };

}
#endif //DEVKIT_GENERICSTRINGPROCESSOR_HPP
