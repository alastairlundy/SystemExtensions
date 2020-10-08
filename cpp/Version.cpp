//
//
//

#include "Version.hpp"

AluminiumTech::DeveloperKit::Version::Version() {
    major = 1;
    minor = 0;
    build = 0;
    revision = 0;
}

std::string AluminiumTech::DeveloperKit::Version::toString() {
   std::string m_major = std::to_string(major);
   std::string m_minor = std::to_string(minor);
   std::string m_build = std::to_string(build);
   std::string m_revision = std::to_string(revision);

  return m_major + "." + m_minor + "." + m_build + "." + m_revision;
}

bool AluminiumTech::DeveloperKit::Version::isThisVersionHigher(Version version) {
    if(major > version.major){
        return true;
    }
    else{
        if(minor > version.minor){
            return true;
        }
        else{
            if(build > version.build){
                return true;
            }
            else{
                return (revision > version.revision);
            }
        }
    }
}

/**
 *
 * @param version
 * @return
 */
bool AluminiumTech::DeveloperKit::Version::isThisVersionLower(Version version) {
    return !isThisVersionHigher(version);
}

/**
 *
 * @param version
 * @return
 */
bool AluminiumTech::DeveloperKit::Version::equals(Version version) {
   return (major == version.major && minor == version.minor && build == version.build && revision == version.revision);
}

/**
 *
 */
AluminiumTech::DeveloperKit::Version::~Version() {
   major = 0;
   minor = 0;
   build = 0;
   revision = 0;
}