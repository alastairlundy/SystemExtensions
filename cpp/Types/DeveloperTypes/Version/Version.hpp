//
//
//

#ifndef DEVKIT_VERSION_HPP
#define DEVKIT_VERSION_HPP

#include <string>

#include <concepts>

#include "../../../StringManipulation/TextProcessors/StringFormatter/StringFormatter.hpp"

namespace AluminiumTech::DeveloperKit {

    template<typename T> requires std::integral<T>

    /**
     * A class to represent Version information similar to C#'s System.Version class but obviously in C++ instead.
     */
    class Version {
        public:
            T major;
            T minor;
            T build;
            T revision;

            int api_level;

            Version();
            Version(std::string versionString);
            explicit Version(T Major = 1, T Minor = 0, T Build = 0, T Revision = 0);

            ~Version();

            std::string toString();

            bool isThisVersionHigher(Version version);
            bool isThisVersionLower(Version version);

            bool equals(Version version);

        protected:
            AluminiumTech::DeveloperKit::StringFormatter stringFormatter;
    };
}
#endif //DEVKIT_VERSION_HPP