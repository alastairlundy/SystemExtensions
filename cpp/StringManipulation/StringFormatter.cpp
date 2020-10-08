//
//
//

#include "StringFormatter.hpp"

#include "../enums&constants/StringConstants.hpp"

/**
 *
 * @param A
 * @param B
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::equals(std::string A, std::string B) {
    if(A.length() == B.length()){
        for(int index = 0; index < A.length(); index++)
        {
            if(A[index] == B[index]){
                //Do nothing.
            }
            else{
                return false;
            }
        }
        return true;
    }
    else{
        return false;
    }
}

/**
 *
 * @param s
 * @return
 */
char *AluminiumTech::DeveloperKit::StringFormatter::toUpper(char* s) {
    for(int letterNumber = 0; letterNumber < sizeof(s); letterNumber++){
        s[letterNumber] = toUpper(s[letterNumber]);
    }
    return s;
}

/**
 *
 * @param s
 * @return
 */
char *AluminiumTech::DeveloperKit::StringFormatter::toLower(char* s) {
    for(int letterNumber = 0; letterNumber < sizeof(s); letterNumber++){
        s[letterNumber] = toLower(s[letterNumber]);
    }
    return s;
}

/**
 *
 * @param s
 * @return
 */
std::string AluminiumTech::DeveloperKit::StringFormatter::toUpper(std::string s) {
        for(int letterNumber = 0; letterNumber < s.length(); letterNumber++){
            s[letterNumber] = toUpper(s[letterNumber]);
        }
        return s;
}

/**
 *
 * @param s
 * @return
 */
std::string AluminiumTech::DeveloperKit::StringFormatter::toLower(std::string s) {
    for(int letterNumber = 0; letterNumber < s.length(); letterNumber++){
            s[letterNumber] = toLower(s[letterNumber]);
    }
    return s;
}

/**
 *
 * @param A
 * @param B
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::equals(char* A, char* B) {
    if(sizeof(A) == sizeof(B)){
        for(int index = 0; index < sizeof(A); index++){
            if(equals(A, B)){

            }
            else{
                return false;
            }
        }
        return true;
    }
    else{
        return false;
    }
}

/**
 *
 * @param A
 * @param B
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::equals(char A, char B) {
    return (A == B);
}

/**
 *
 * @param s
 * @return
 */
char AluminiumTech::DeveloperKit::StringFormatter::toLower(char s) {
    for(int index = 0; index < UPPER_ALPHABET.length(); index++){
        if(equals(s, UPPER_ALPHABET[index])){
            s = LOWER_ALPHABET[index];
        }
    }
    return s;
}

/**
 *
 * @param s
 * @return
 */
char AluminiumTech::DeveloperKit::StringFormatter::toUpper(char s) {
    for(int index = 0; index < LOWER_ALPHABET.length(); index++){
        if(equals(s,LOWER_ALPHABET[index])){
            s = UPPER_ALPHABET[index];
        }
    }
    return s;
}

/**
 *
 * @param containedIn
 * @param largerString
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::contains(const std::string& containedIn, const std::string& largerString) {
    int numberOfContainedLetters = 0;

    for(char containedInIndex : containedIn){

        for(char largerStringIndex : largerString){

            if(equals(largerStringIndex, containedInIndex)){
                numberOfContainedLetters++;
            }
            else{
                //Do nothing
            }
        }
    }

    return (numberOfContainedLetters == containedIn.length());
}

/**
 *
 * @param containedIn
 * @param largerString
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::contains(char* containedIn, char* largerString) {
    int numberOfContainedLetters = 0;

    for(int containedInIndex = 0; containedInIndex < sizeof(containedIn); containedInIndex++){


        for(int largerStringIndex = 0; largerStringIndex < sizeof(largerString); largerStringIndex++){

            if(equals(largerString[largerStringIndex], containedIn[containedInIndex])){
                numberOfContainedLetters++;
            }
            else{
                //Do nothing
            }
        }
    }

    return (numberOfContainedLetters == sizeof(containedIn));
}

/**
 *
 * @param startingString
 * @param largerString
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::startsWith(char* startingString, char* largerString) {
    int numberOfContainedLetters = 0;

        for(int largerStringIndex = 0; largerStringIndex < sizeof(startingString); largerStringIndex++){

            if(equals(largerString[largerStringIndex], startingString[largerStringIndex])){
                numberOfContainedLetters++;
            }
            else{
                //Do nothing
            }
        }

    return (numberOfContainedLetters == sizeof(startingString));
}

/**
 *
 * @param startingString
 * @param largerString
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::startsWith(std::string startingString, std::string largerString) {
    int numberOfContainedLetters = 0;

        for(int largerStringIndex = 0; largerStringIndex < startingString.length(); largerStringIndex++){

            if(equals(largerString[largerStringIndex], startingString[largerStringIndex])){
                numberOfContainedLetters++;
            }
            else{
                //Do nothing
            }
        }

    return (numberOfContainedLetters == startingString.length());
}

/**
 *
 * @param endingString
 * @param largerString
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::endsWith(std::string endingString, std::string largerString) {
    int numberOfContainedLetters = 0;

    int startingPoint = (largerString.length() - endingString.length());
    for(int index = startingPoint; index < largerString.length(); index++){

        if(equals(largerString[index], endingString[index])){
            numberOfContainedLetters++;
        }
        else{
            //Do nothing
        }
    }

    return (numberOfContainedLetters == endingString.length());
}

/**
 *
 * @param endingString
 * @param largerString
 * @return
 */
bool AluminiumTech::DeveloperKit::StringFormatter::endsWith(char* endingString, char* largerString) {
    int numberOfContainedLetters = 0;

    for(int index = (sizeof(largerString) - sizeof(endingString)); index < sizeof(largerString); index++){

        if(equals(largerString[index], endingString[index])){
            numberOfContainedLetters++;
        }
        else{
            //Do nothing
        }
    }

    return (numberOfContainedLetters == sizeof(endingString));
}

/**
 *
 * @param string
 * @return
 */
int AluminiumTech::DeveloperKit::StringFormatter::getLength(const std::string& string) {
    int length = 0;

    for(char c : string){
        length++;
    }

    return length;
}

/**
 *
 * @param c
 * @return
 */
int AluminiumTech::DeveloperKit::StringFormatter::getLength(char* c) {
    std::string string = toString(c);

    return getLength(string);
}

/**
 *
 * @param string
 * @param specifiedChar
 * @return
 */
int AluminiumTech::DeveloperKit::StringFormatter::getNumberOfSpecifiedCharacterInString(const std::string& string, char specifiedChar) {
    int numberOfNumbers = 0;

    for(char c : string){
        if(equals(c, specifiedChar)){
            numberOfNumbers++;
        }
    }

    return numberOfNumbers;
}

/**
 *
 * @param string
 * @param specifiedChars
 * @return
 */
int AluminiumTech::DeveloperKit::StringFormatter::getNumberOfSpecifiedCharactersInString(char* string, char* specifiedChars) {
    std::string newString = toString(string);

    return getNumberOfSpecifiedCharactersInString(newString, specifiedChars);
}

/**
 *
 * @param string
 * @param specifiedChars
 * @return
 */
int AluminiumTech::DeveloperKit::StringFormatter::getNumberOfSpecifiedCharactersInString(const std::string& string, char* specifiedChars) {
    std::string newString = toString(specifiedChars);

   return getNumberOfSpecifiedCharactersInString(string, newString);
}

/**
 *
 * @param string
 * @param specifiedChars
 * @return
 */
int AluminiumTech::DeveloperKit::StringFormatter::getNumberOfSpecifiedCharactersInString(const std::string& string, const std::string& specifiedChars) {
    int numberOfNumbers = 0;

    for(char c : string){
        for(char num : specifiedChars){
            if(equals(c, num)){
                numberOfNumbers++;
            }
        }
    }

    return numberOfNumbers;
}

AluminiumTech::DeveloperKit::StringFormatter::StringFormatter() {

}

std::string AluminiumTech::DeveloperKit::StringFormatter::toString(char* string) {
    int length = strlen(string);

    std::string newString;

    for(int index = 0; index < length; index++){
        newString.append(reinterpret_cast<const char *>(string[index]));
    }

    return newString;
}

/**
 *
 * @param string
 * @return
 */
char* AluminiumTech::DeveloperKit::StringFormatter::toString(std::string string) {
    char newString[string.length()];

    for(int index = 0; index < string.length(); index++){
        newString[index]  = string[index];
    }

    return reinterpret_cast<char *>(*newString);
}