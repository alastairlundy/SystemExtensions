//
//
//

#ifndef DEVKIT_STRINGFORMATTER_HPP
#define DEVKIT_STRINGFORMATTER_HPP

#include <string>
#include "../Types/Lists/HashMapV2.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     *
     */
    class StringFormatter {

    public:
        std::string* split_toArray(const std::string& word);
        std::string* split_toArray(char delimiterChar, const std::string& string);

        ObjectList<std::string> split_toObjectList(const std::string& string);
        ObjectList<std::string> split_toObjectList(char delimiterChar, const std::string& string);

        int indexOfCharacter(char* string, char character);
        int indexOfCharacter(std::string string, char character);

        AluminiumTech::DeveloperKit::HashMapV2<char, int> indexOfCharactersWithinString(char* string, char* characters);
        AluminiumTech::DeveloperKit::HashMapV2<char, int> indexOfCharactersWithinString(const std::string& string, char* characters);
        AluminiumTech::DeveloperKit::HashMapV2<char, int> indexOfCharactersWithinString(const std::string& string, const std::string& characters);

        std::string toString(char string[]);
        char *toString(std::string string);

        char *toUpper(char *);
        char *toLower(char *);

        std::string toUpper(std::string);
        std::string toLower(std::string);

        char toUpper(char);
        char toLower(char);

        std::string replaceCharacter(std::string word, char oldCharacter, char newCharacter);

        std::string replace(const std::string& word, char* oldString, char* newString);
        std::string replace(std::string word, const std::string& oldString,std::string newString);

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
