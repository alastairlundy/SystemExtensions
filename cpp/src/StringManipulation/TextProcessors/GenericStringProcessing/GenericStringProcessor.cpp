//
//
//

#include "GenericStringProcessor.hpp"

#include "../../../enums&constants/StringConstants.hpp"

/**
 * Capitalizes the first letter in a word.
 * @param word
 * @return
 */
std::string AluminiumTech::DeveloperKit::GenericStringProcessor::capitalizeFirstLetterOfWord(std::string word) {
   return capitalizeALetterInAWord(0, std::move(word));
}

/**
 * Capitalizes the specified letter in the word.
 * @param index
 * @param word
 * @return
 */
std::string AluminiumTech::DeveloperKit::GenericStringProcessor::capitalizeALetterInAWord(int index, std::string word) {
    if(index <= word.length()){
        word[index] = stringFormatter.toUpper(word[index]);
        return word;
    }
    return nullptr;
}

/**
 * Returns whether or not a character is a special character or not.
 * @param c
 * @return
 */
bool AluminiumTech::DeveloperKit::GenericStringProcessor::isCharacterASpecialCharacter(char c) {
    for(char index : SPECIAL_CHARACTERS){
        if(c == index){
            return true;
        }
    }
    return false;
}

/**
 * Returns whether or not a character is a lower case letter or not.
 * @param c
 * @return
 */
bool AluminiumTech::DeveloperKit::GenericStringProcessor::isCharacterALowerCaseLetter(char c) {
    for(char index : LOWER_ALPHABET){
        if(c == index){
            return true;
        }
    }
    return false;
}

/**
 * Returns whether a character is an upper case letter or not.
 * @param c
 * @return
 */
bool AluminiumTech::DeveloperKit::GenericStringProcessor::isCharacterAnUpperCaseLetter(char c) {
    for(char index : UPPER_ALPHABET){
        if(c == index){
            return true;
        }
    }
    return false;
}

/**
 *
 * @param phrase
 * @return
 */
bool AluminiumTech::DeveloperKit::GenericStringProcessor::basicTitleCaseDetection(const std::string& phrase) {
    auto words = stringFormatter.split_toObjectList(phrase);

    auto array = new bool[words.count];

    for(int index = 0; index < words.count; index++){
        array[index] = basicTitleCaseDetection(words.get(index));
    }

    return resultsAveraging.isAllPositive(array);
}

/**
 *
 * @param phrase
 * @return
 */
std::string AluminiumTech::DeveloperKit::GenericStringProcessor::phraseToTitleCase(std::string phrase) {
    auto words = stringFormatter.split_toObjectList(phrase);

    for (int index = 0; index < phrase.length(); index++) {

        if (basicTitleCaseDetection(words.get(index)))
        {
            phrase += words.get(index);
        }
        else{
            phrase += capitalizeFirstLetterOfWord(words.get(index));
        }
    }

    return phrase;
}