


#ifndef DEVELOPERKIT_CLICKBAITTEXTPROCESSOR_HPP
#define DEVELOPERKIT_CLICKBAITTEXTPROCESSOR_HPP


#include "../GenericStringProcessor.hpp"

namespace AluminiumTech::DeveloperKit{
    class ClickBaitTextProcessor : GenericStringProcessor{

    public:
        std::string basicClickBaitCreation(std::string phrase, bool checkForBasicClickBait = true);

        bool basicClickBaitDetection(std::string phrase);

        std::string removeClickBait(std::string phrase, bool checkForBasicClickBait = true);

    protected:


    private:


    };
}


#endif //DEVELOPERKIT_CLICKBAITTEXTPROCESSOR_HPP
