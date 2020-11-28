//
//
//

#ifndef DEVKIT_VERSION_HPP
#define DEVKIT_VERSION_HPP

#include <string>

#include <concepts>

#include "../../../StringManipulation/StringFormatter.hpp"

namespace AluminiumTech::DeveloperKit {

    /**
     * A class to represent Version information similar to C#'s System.Version class but obviously in C++ instead.
     */
    template<typename T> requires std::integral<T>
    class Version {
        public:
            T major;
            T minor;
            T build;
            T revision;

            int api_level;

            Version();
            Version(std::string versionString);
            Version(Version const &version);
            explicit Version(int Major = 1, int Minor = 0, int Build = 0, int Revision = 0);

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
