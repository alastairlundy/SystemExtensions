//
//
//

#ifndef DEVKIT_SARCASMTEXTPROCESSOR_HPP
#define DEVKIT_SARCASMTEXTPROCESSOR_HPP


#include "../GenericStringProcessing/GenericStringProcessor.hpp"

#include <string>

namespace AluminiumTech::DeveloperKit{

    class SarcasmTextProcessor : GenericStringProcessor{

    public:
        std::string convertSarcasmWordToRegularText(std::string sarcasmText);
        std::string convertWordToSarcasmText(std::string word);

    protected:
        StringFormatter stringFormatter;

    };
}


#endif //DEVKIT_SARCASMTEXTPROCESSOR_HPP
