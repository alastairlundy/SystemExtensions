//
//
//

#include "SarcasmTextProcessor.hpp"

#include <utility>

/**
 *
 * @param word
 * @return
 */
std::string  AluminiumTech::DeveloperKit::SarcasmTextProcessor::convertWordToSarcasmText(std::string word) {
    std::string result;

    for(int index = 0; index < word.length(); index++){
        if((index % 2) == 0){
            result += stringFormatter.toUpper(word[index]);
        }
        else{
            result += stringFormatter.toLower(word[index]);
        }
    }

    return result;
}

/**
 *
 * @param sarcasmText
 * @return
 */
std::string AluminiumTech::DeveloperKit::SarcasmTextProcessor::convertSarcasmWordToRegularText(std::string sarcasmText) {
    return capitalizeFirstLetterOfWord(std::move(sarcasmText));
}
