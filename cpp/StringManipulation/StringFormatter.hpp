//
//
//

#ifndef DEVKIT_STRINGFORMATTER_HPP
#define DEVKIT_STRINGFORMATTER_HPP

#include <string>

namespace AluminiumTech::DeveloperKit {

    class StringFormatter {

    public:
        StringFormatter();

        std::string toString(char string[]);
        char *toString(std::string string);

        char *toUpper(char *);
        char *toLower(char *);

        std::string toUpper(std::string);
        std::string toLower(std::string);

        char toUpper(char);
        char toLower(char);

        bool equals(std::string A, std::string B);
        bool equals(char A, char B);
        bool equals(char *A, char *B);

        bool contains(const std::string &containedIn, const std::string &largerString);
        bool contains(char *containedIn, char *largerString);

        bool startsWith(std::string startingString, std::string largerString);
        bool startsWith(char *startingString, char *largerString);

        bool endsWith(std::string endingString, std::string largerString);
        bool endsWith(char *endingString, char *largerString);

        int getLength(char *c);
        int getLength(const std::string &string);

        int getNumberOfSpecifiedCharacterInString(const std::string &string, char specifiedChar);
        int getNumberOfSpecifiedCharactersInString(char string[], char specifiedChars[]);
        int getNumberOfSpecifiedCharactersInString(const std::string &string, char specifiedChars[]);
        int getNumberOfSpecifiedCharactersInString(const std::string &string, const std::string &specifiedChars);


    protected:

    };
}

#endif //DEVKIT_STRINGFORMATTER_HPP
