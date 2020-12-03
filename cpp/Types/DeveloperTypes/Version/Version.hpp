//
//
//

#ifndef DEVKIT_VERSION_HPP
#define DEVKIT_VERSION_HPP

#include <string>

#include "../../../StringManipulation/TextProcessors/StringFormatter/StringFormatter.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     * A class to represent Version information similar to C#'s System.Version class but obviously in C++ instead.
     */
    class Version {
        public:
            int_least32_t major;
            int_least32_t minor;
            int_least32_t build;
            int_least32_t revision;

            int_least32_t api_level;

            Version(int_least32_t Major = 1, int_least32_t Minor = 0, int_least32_t Build = 0, int_least32_t Revision = 0, int_least32_t Api_level = 1);

            ~Version();

            AluminiumTech::DeveloperKit::Version convertStringToVersion(std::string versionString);

            std::string toString();

            bool isThisVersionHigher(const Version& version);
            bool isThisVersionLower(const Version& version);

            bool equals(const Version& version);

        protected:
            AluminiumTech::DeveloperKit::StringFormatter stringFormatter;
    };
}
#endif //DEVKIT_VERSION_HPP