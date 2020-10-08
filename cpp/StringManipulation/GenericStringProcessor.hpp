//
//
//

#ifndef DEVKIT_GENERICSTRINGPROCESSOR_HPP
#define DEVKIT_GENERICSTRINGPROCESSOR_HPP

#include "StringFormatter.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     *
     */
    class GenericStringProcessor {

    public:
        GenericStringProcessor();
        ~GenericStringProcessor();

        std::string capitalizeALetterInAWord(int index, std::string word);
        std::string capitalizeFirstLetterOfWord(std::string word);

        bool isCharacterASpecialCharacter(char c);
        bool isCharacterALowerCaseLetter(char c);
        bool isCharacterAnUpperCaseLetter(char c);

        bool isWordTitleCase(std::string word);

        bool basicTitleCaseDetection(std::string word);

    protected:
        AluminiumTech::DeveloperKit::StringFormatter stringFormatter;

    private:

    };

}
#endif //DEVKIT_GENERICSTRINGPROCESSOR_HPP
