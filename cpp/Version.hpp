//
//
//

#ifndef DEVKIT_VERSION_HPP
#define DEVKIT_VERSION_HPP

#include <string>

namespace AluminiumTech::DeveloperKit {

    /**
     *
     */
    class Version {
        public:
            int major;
            int minor;
            int build;
            int revision;

            Version();
            ~Version();

            std::string toString();

            bool isThisVersionHigher(Version version);

            bool isThisVersionLower(Version version);

            bool equals(Version version);

        protected:

    };

}
#endif //DEVKIT_VERSION_HPP
