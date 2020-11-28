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
 * @param word
 * @return
 */
bool AluminiumTech::DeveloperKit::GenericStringProcessor::isWordTitleCase(std::string word) {
    ObjectList<bool> letterCapitalization;

    letterCapitalization.add(isCharacterAnUpperCaseLetter(word[0]));

    for(int index = 1; index < word.length(); index++){
        letterCapitalization.add(isCharacterALowerCaseLetter(word[index]));
    }

    return resultsAveraging.isAllPositive(letterCapitalization.toArray());
}

/**
 *
 * @param phrase
 * @return
 */
bool AluminiumTech::DeveloperKit::GenericStringProcessor::basicTitleCaseDetection(const std::string& phrase) {
    auto words = stringFormatter.split_toObjectList(phrase);

    ObjectList<bool> results;

    for(int index = 0; index < words.count; index++){
        results.add(isWordTitleCase(words.get(index)));
    }

    return resultsAveraging.isAllPositive(results.toArray());
}

/**
 *
 * @param phrase
 * @return
 */
std::string AluminiumTech::DeveloperKit::GenericStringProcessor::phraseToTitleCase(std::string phrase) {
    auto words = stringFormatter.split_toObjectList(phrase);

    for (int index = 0; index < phrase.length(); index++) {

        if (isWordTitleCase(words.get(index)))
        {
            phrase += words.get(index);
        }
        else{
            phrase += capitalizeFirstLetterOfWord(words.get(index));
        }
    }

    return phrase;
}