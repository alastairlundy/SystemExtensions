//
//
//

#include "ClickBaitTextProcessor.hpp"

/**
 *
 * @param phrase
 * @param checkForBasicClickBait
 * @return
 */
std::string AluminiumTech::DeveloperKit::ClickBaitTextProcessor::basicClickBaitCreation(std::string phrase,
                                                                                        bool checkForBasicClickBait) {
    if(checkForBasicClickBait){
        auto isClickBait = basicClickBaitDetection(phrase);

        if(isClickBait){
            return phrase;
        }
    }

    return phraseToTitleCase(phrase);
}

/**
 *
 * @param phrase
 * @return
 */
bool AluminiumTech::DeveloperKit::ClickBaitTextProcessor::basicClickBaitDetection(std::string phrase) {

    auto wordsSplit = stringFormatter.split_toObjectList(phrase);

    bool wordCapitalization[wordsSplit.count];

    for(int index = 1; index < wordsSplit.count; index++){

        std::string word = wordsSplit[index];
        wordCapitalization[index] = isCharacterAnUpperCaseLetter(word[0]);

    }

    for(int index = 0; index < sizeof(wordCapitalization); index++){
        if(wordCapitalization[index] == true){
            return true;
        }
    }

    return false;
}

/**
 *
 * @param phrase
 * @param checkForBasicClickBait
 * @return
 */
std::string
AluminiumTech::DeveloperKit::ClickBaitTextProcessor::removeClickBait(std::string phrase, bool checkForBasicClickBait) {

    if(checkForBasicClickBait){
        auto isClickBait = basicClickBaitDetection(phrase);

        if(!isClickBait){
            return phrase;
        }
    }

    auto wordSplitter = stringFormatter.split_toObjectList(phrase);
    phrase = capitalizeFirstLetterOfWord(wordSplitter.get(0));

    for(int index = 1; index < wordSplitter.count; index++){
        phrase += stringFormatter.toLower(wordSplitter.get(index));
    }

    return phrase;
}